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
using Microsoft.AspNetCore.Http;

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
            return View(_service.GetUserRoles(id));
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
                        Subject = "New User Account Created",
                        Body = String.Format(UtilityService.GetMessageToDisplay("PASSWORDGENERATED"), user.UserFullName, "GymAdmin", Encryption.Decrypt(user.Password))
                    };

                    _mailservice.SendMail(mail, true);
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
           
            HttpContext.Session.SetString("UserID", id.ToString());
            PopulateDropDownLists();
            return View(await _service.FindUser(id, username));
        }


        [HttpPost]
        public async Task<IActionResult> ViewUser(User user)
        {
            PopulateDropDownLists();
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
               [HttpPost]
        public async Task<IActionResult> AddUserRoles(string[] selectedRoles, UserRole user)
        {

            if (await (_service.UpdateRoles(user.UserID, selectedRoles)) == 0)
            {
                ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            }

            return RedirectToAction("ViewUser", new { id=user.UserID });

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

        public void PopulateDropDownLists()
        {
            int userID = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
            var allRoles = _service.GetAllRoles();
            var userRoles = new HashSet<int>(_service.GetUserRoles(userID)?.Select(p => p.RoleID));
            var viewModel = new List<CheckBoxListItem>();
            foreach (var role in allRoles)
            {
                viewModel.Add(new CheckBoxListItem
                {
                    ID = role.RoleID,
                    Name = role.Name,
                    IsChecked = userRoles.Contains(role.RoleID)
                });
            }
            ViewBag.RolesList = viewModel;

        }
        private IList<Department> GetDepartments()
        {
            IList<Department> departments = _departmentservice.GetDepartments().ToList();
            return departments;
        }
    }
}