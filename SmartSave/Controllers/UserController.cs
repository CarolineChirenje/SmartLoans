using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLogic;

using SmartSave.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartDomain;
using SmartHelper;

namespace SmartSave.Controllers
{
    public class UserController : Controller
    {
        IUserService _service;
        IRoleService _roleservice;
        IDepartmentService _departmentservice;
        IMailService _mailservice;
        public UserController(IUserService service, IRoleService roleservice, IDepartmentService departmentService, IMailService mailService)
        {
            _service = service;
            _roleservice = roleservice;
            _departmentservice = departmentService;
            _mailservice = mailService;
        }

        // GET: User
        public async Task<IActionResult> Users()
        {
            return View(await _service.Users());
        }
        public async Task<IActionResult> UserRoles(int id)
        {
            User user = await _service.FindUser(id);
            ViewBag.UserName = user.UserFullName ?? "No Name";
            ViewBag.UserID = user.UserID;
            return View( _service.GetUserRoles(id));
        }



        public IActionResult AddUser()
        {
            ViewBag.DepartmentList = GetDepartments();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddUser(User user)
        {
            if (UtilityService.StringParameterHasValue(String.Concat(user.FirstName, ' ', user.LastName)))
            {
                user.UserName = UtilityService.GenerateUserName(user.FirstName, user.LastName);
                if (await (_service.Save(user)) == 0)
                    ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                else
                {
                    Email mail = new Email
                    {
                        To = user.EmailAddress,
                        Subject="New User Account Created",
                        Body = String.Format(UtilityService.GetMessageToDisplay("PASSWORDGENERATED"), user.UserFullName, "GymAdmin", Encryption.Decrypt(user.Password))
                    };

                    _mailservice.SendMail(mail,true);
                }

                return RedirectToAction(nameof(Users));
            }
            return View(user);
        }


        // GET:
        public async Task<IActionResult> ViewUser(int id = 0, string username = null)
        {
            if (id == 0 && username == null)
                return RedirectToAction(nameof(Users));
            ViewBag.DepartmentList = GetDepartments();
            return View(await _service.FindUser(id, username));
        }


        [HttpPost]
        public async Task<IActionResult> ViewUser(User user)
        {
            if (ModelState.IsValid)
            {
                User update = await _service.FindUser(user.UserID);
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(update)) == 0)
                        ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(Users));
                }
                return View(user);
            }
            ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(user);
        }

        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.Delete(id)) > 0)
                return RedirectToAction(nameof(Users));
            else
            {
                ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewUser", new { id });
            }
        }

        // UserRoles
        public async Task<IActionResult> ViewUserRoles(int id)
        {
            User user = await _service.FindUser(id);
            ViewBag.UserName = user.UserFullName ?? "No Name";
            ViewBag.UserID = user.UserID;
            CheckBoxModel model = new CheckBoxModel
            {
                LinkedID = id,
                AvailableItems = GetAvailableListItems(id)
            };
            return View(model);

        }


        [HttpPost]
        public async Task<IActionResult> ViewUserRoles(CheckBoxModel model)
        {
            if (ModelState.IsValid)
            {
                if (await (_service.SaveUserRoles(model.LinkedID, model.SelectedItems.ToList())) > 0)
                    return RedirectToAction(nameof(Users));
                else
                {
                    ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewUser", new { model.LinkedID });
                }
            }
            model.AvailableItems = GetAvailableListItems(model.LinkedID);
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> AddUserRoles(CheckBoxModel model)
        {
            if (ModelState.IsValid)
            {
                if (await (_service.SaveUserRoles(model.LinkedID, model.SelectedItems.ToList())) > 0)
                    return RedirectToAction(nameof(Users));
                else
                {
                    ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewUser", new { model.LinkedID });
                }
            }
            model.AvailableItems = GetAvailableListItems(model.LinkedID);
            return View(model);
        }
        public async Task<IActionResult> DeleteUserRole(int id, int userid)
        {
            if (await (_service.ActionUserRole(id, userid, DatabaseAction.Remove)) > 0)
                return RedirectToAction(nameof(Users));
            else
            {
                ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewUser", new { id });
            }
        }
        public async Task<IActionResult> ChangeUserRoleStatus(int id, int userid, bool status)
        {
            if (await (_service.ActionUserRole(id, userid, status ? DatabaseAction.Deactivate : DatabaseAction.Reactivate)) > 0)
                return RedirectToAction(nameof(Users));
            else
            {
                ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewUser", new { id });
            }
        }

        // this must return unticked  checkboxs if Department has no Department otherwise it will return ticked and unticked boxes 
        // #ndini ndadaro
        public List<CheckBoxListItem> GetAvailableListItems(int id)
        {
            List<Role> allRoles = _roleservice.GetRoles();
            List<Role> userRoles =    _service.GetUserRoles(id);
            List<Role> availableRoles = allRoles.Except(userRoles).ToList();
            var AvailableListItems = new List<CheckBoxListItem>();
            foreach (var role in availableRoles)
            {
                AvailableListItems.Add(new CheckBoxListItem()
                {
                    ID = role.RoleID,
                    Value = role.Name,
                    IsChecked = false //On the add view, checkbox are selected by default

                    //   IsChecked = userRoles.Where(x => x.ID == role.RoleID).Any()
                });
            }
            return AvailableListItems;
        }
        private IList<Department> GetDepartments()
        {
            IList<Department> departments = _departmentservice.GetDepartments().ToList();
            return departments;
        }
    }
}