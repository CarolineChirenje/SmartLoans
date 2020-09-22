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
using SmartDataAccess;

namespace SmartSave.Controllers
{
    public class UserController : Controller
    {
        IUserService _service;
        IRoleService _roleservice;
        IDepartmentService _departmentservice;
        IMailService _mailservice;
        IEmailTemplateService _emailTemplateService;
        public UserController(IUserService service, IRoleService roleservice,
        IDepartmentService departmentService, IMailService mailService, IEmailTemplateService emailTemplateService)
        {
            _service = service;
            _roleservice = roleservice;
            _departmentservice = departmentService;
            _mailservice = mailService;
            _emailTemplateService = emailTemplateService;
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
            PopulateDropDownLists();
            ViewBag.DepartmentList = GetDepartments();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddUser(User user)
        {
            PopulateDropDownLists();
            if (UtilityService.StringParameterHasValue(String.Concat(user.FirstName, ' ', user.LastName)))
            {
                user.UserName = UtilityService.GenerateUserName(user.FirstName, user.LastName);
                int result=await  _service.Save(user);
                if (result == 0)
                {
                    ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return View(user);
                }
                else
                {
                    EmailTemplate emailTemplate = _emailTemplateService.GetEmailTemplate((int)EmailTypeList.New_User_Account_Created).Result;
                    Email email = new Email();
                    email.To = user.EmailAddress;
            
                    if (UtilityService.IsNotNull(emailTemplate))
                    {
                        email.Body = emailTemplate.Body + String.Format(UtilityService.GetMessageToDisplay("PASSWORDGENERATED"), user.UserFullName, UtilityService.ApplicationName, Encryption.Decrypt(user.Password));
                        email.Subject = emailTemplate.Subject;
                    }
                    else{

                        email.Body = UtilityService.HtmlDecode(String.Format(UtilityService.GetMessageToDisplay("PASSWORDGENERATED"), user.UserFullName, UtilityService.ApplicationName, Encryption.Decrypt(user.Password)));
                        email.Subject = "New Account Created";
                    }
                    _mailservice.SendMail(email);
                  
                    return RedirectToAction("ViewUser", new { id=result });
                }

           
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
                    if (await (_service.Update(user)) == 0)
                    {
                        ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                        return View(user);
                    }
                }
                return RedirectToAction("ViewUser", new { id=user.UserID });
            }
            ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewUser", new { id = user.UserID });
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


            var userTypeList = _service.GetUserTypes().Select(t => new
            {
                t.UserTypeID,
                Name = t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.UserTypeList = new SelectList(userTypeList, "UserTypeID", "Name");


        }
        private IList<Department> GetDepartments()
        {
            IList<Department> departments = _departmentservice.GetDepartments().ToList();
            return departments;
        }
    }
}