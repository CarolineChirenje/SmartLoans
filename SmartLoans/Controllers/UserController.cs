using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLogic;

using SmartLoan.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartDomain;
using SmartHelper;
using Microsoft.AspNetCore.Http;
using SmartDataAccess;
using System.IO;
using SmartMail;
using SmartAsync;
using SmartExtensions;
using Microsoft.Extensions.Logging;

namespace SmartLoan.Controllers
{
    public class UserController : BaseController<UserController>
    {
        private readonly IUserService _service;
        readonly IRoleService _roleservice;
        readonly IDepartmentService _departmentservice;
        readonly IEmailTemplateService _emailTemplateService;
        readonly ICompanyService _companyService;
        public UserController(IUserService service, IRoleService roleservice,
        IDepartmentService departmentService, IEmailTemplateService emailTemplateService, ICompanyService companyService)
        {
            _service = service;
            _roleservice = roleservice;
            _departmentservice = departmentService;
            _emailTemplateService = emailTemplateService;
            _companyService = companyService;
        }

        // GET: User
        public async Task<IActionResult> Users()
        {
            Permissions permission = Permissions.View_User;
            if (!UserAppData.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

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
        public async Task<IActionResult> AddUser(User user, IFormFile ProfileImage)
        {
            PopulateDropDownLists();
            if (UtilityService.StringParameterHasValue(String.Concat(user.FirstName, ' ', user.LastName)))
            {

                if (_service.EmailExists(user.EmailAddress))
                {
                    TempData[MessageDisplayType.Error.ToString()] = $"A User Account with the same email address {user.EmailAddress} already exists";
                    return View(user);
                }
               
                // To convert the  uploaded Photo as Byte Array before save to DB    
                if (ProfileImage != null)
                {
                    if (ProfileImage.Length > 0)
                    {
                        //Getting FileName
                        // var fileName = Path.GetFileName(ProfileImage.FileName);
                        //Getting file Extension
                        // var fileExtension = Path.GetExtension(fileName);

                        using var target = new MemoryStream();
                        ProfileImage.CopyTo(target);
                        user.ProfileImage = target.ToArray();
                    }
                }
                int result = await _service.Save(user);
                if (result == 0)
                {
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return View(user);
                }
                else
                {
                    EmailTemplate emailTemplate = _emailTemplateService.GetEmailTemplate((int)EmailTypeList.New_User_Account_Created).Result;
                    Email email = new Email
                    {
                        To = user.EmailAddress
                    };

                    if (emailTemplate.IsNotNull())
                    {
                        email.Body = emailTemplate.Body + _service.GetCredential(result);
                        email.Subject = emailTemplate.Subject;
                    }
                    else
                    {                        email.AttachmentFromMemory = null;
                        string _emailBody = @"Dear  " + user.UserFullName + ",<br/><br/> Your user account has been created successfully  account on " + UserAppData.ApplicationName + ".<br/><br/>" +
                                   "We recommend that you keep your account details secure and not share it with anyone.If you feel your credentials have  been compromised, " +
                                @"or you have any other questions, feel free to email " + UtilityService.CustomerServiceEmail + ", or call " + UserAppData.ApplicationName + " customer service  at  " + UtilityService.CustomerServiceNumber + ". Your login password is <b>" + _service.GetCredential(result) + "</b>.<br/><br/> Regards,<br/><br/><br/>" + UserAppData.ApplicationName + " Customer Service";
                        email.Body = UtilityService.HtmlDecode(_emailBody);
                        email.Subject = $"New Account Created - {UserAppData.ApplicationName}";
                    }
                    RabbitQueue.Publish(email);
                    return RedirectToAction("ViewUser", new { id = result });
                }
            }
            return View(user);
        }
        public ActionResult RetrieveImage(int id)
        {
            User user = _service.FindUser(id).Result;
            if (user.IsNull())
                return null;
            byte[] ProfileImage = user.ProfileImage;
            if (ProfileImage != null)
                return File(ProfileImage, "image/png");
            else
                return null;
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
        public async Task<IActionResult> ViewUser(User user, IFormFile ProfileImage)
        {
            PopulateDropDownLists();
            if (ModelState.IsValid)
            {
                User update = await _service.FindUser(user.UserID);
                if (update.IsNotNull())
                { // To convert the  uploaded Photo as Byte Array before save to DB    
                    if (ProfileImage != null)
                    {
                        if (ProfileImage.Length > 0)
                        {
                            //Getting FileName
                            // var fileName = Path.GetFileName(ProfileImage.FileName);
                            //Getting file Extension
                            // var fileExtension = Path.GetExtension(fileName);

                            using var target = new MemoryStream();
                            ProfileImage.CopyTo(target);
                            user.ProfileImage = target.ToArray();
                        }
                    }
                    if (await (_service.Update(user)) == 0)
                    {
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                        return View(user);
                    }
                }
                return RedirectToAction("ViewUser", new { id = user.UserID });
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewUser", new { id = user.UserID });
        }

        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.Delete(id)) > 0)
                return RedirectToAction(nameof(Users));
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewUser", new { id });
            }
        }

        // UserRoles
        [HttpPost]
        public async Task<IActionResult> AddUserRoles(string[] selectedRoles, UserRole userRole)
        {

            if (await (_service.UpdateRoles(userRole.UserID, selectedRoles)) == 0)
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            }
            return RedirectToAction("ViewUser", new { id = userRole.UserID });

        }

        public async Task<IActionResult> DeleteUserRole(int id, int userid)
        {
            if (await (_service.ActionUserRole(id, userid, DatabaseAction.Remove)) > 0)
                return RedirectToAction(nameof(Users));
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewUser", new { id });
            }
        }
        public async Task<IActionResult> ChangeUserRoleStatus(int id, int userid, bool status)
        {
            if (await (_service.ActionUserRole(id, userid, status ? DatabaseAction.Deactivate : DatabaseAction.Reactivate)) > 0)
                return RedirectToAction(nameof(Users));
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewUser", new { id });
            }
        }
        [HttpPost]
        public ActionResult GetCompanies(int UserTypeID)
        {
            SelectList companyList = null;
            if (UserTypeID == (int)TypeOfUser.Employer)
            {
                List<Company> companies = _companyService.GetActiveCompanies();
                companies.Select(t => new
                {
                    t.CompanyID,
                    t.Name,
                });
                companyList = new SelectList(companies, "CompanyID", "Name");
            }
            return Json(companyList);
        }


        /// <summary>
        /// To Do List
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 

        [HttpPost]
        public async Task<IActionResult> AddToDo(UserToDo userToDo)
        {
            if (ModelState.IsValid)
            {
                bool duplicate = await _service.IsDuplicate(userToDo);
                if (duplicate)
                {
                    TempData["Error"] = "To Do Item Already Exists";
                    return View(userToDo);
                }
                if (await (_service.Save(userToDo)) == 0)
                {
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return View(userToDo);
                }

            }
            return RedirectToAction("Dashboard", "Home");

        }
        public ActionResult ToDoList(int id)
        {
            try
            {
                Permissions permission = Permissions.View_To_Do;
                if (!UserAppData.HasPermission(permission))
                    return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

               
                var todoList = _service.ToDoList(id);
                return View(todoList);
            }
            catch (Exception ex)
            {
                Logger.Log(LogLevel.Debug, ex.ToString());
                return RedirectToAction("Error", "Home");
            }
        }
       public async Task<IActionResult> ViewUserToDo(int id)
        {
            if (id == 0)
                return RedirectToAction("Dashboard", "Home");
            return View(await _service.FindToDo(id));
        }
        [HttpPost]
        public async Task<IActionResult> ViewUserToDo(UserToDo userToDo)
        {
          
            if (ModelState.IsValid)
            {
                UserToDo update = await _service.FindToDo(userToDo.UserToDoID);
                if (update.IsNotNull())
                {
                    if (await (_service.Update(userToDo)) == 0)
                        TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewUserToDo", new { id = userToDo.UserToDoID });
                }
                return RedirectToAction("Dashboard","Home");
            }
            TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewUserToDo", new { id = userToDo.UserToDoID });
        }
        public async Task<IActionResult> DeleteToDo(int id)
        {
            if (await (_service.DeleteToDo(id)) == 0)
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("Dashboard", "Home");
        }
        public void PopulateDropDownLists()
        {
            int userID = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
            var allRoles = _service.GetAllRoles().OrderBy(r => r.Name);
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
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.UserTypeList = new SelectList(userTypeList, "UserTypeID", "Name");

            var companyList = _companyService.GetActiveCompanies().Select(t => new
            {
                t.CompanyID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.CompanyList = new SelectList(companyList, "CompanyID", "Name");

        }
        private IList<Department> GetDepartments()
        {
            IList<Department> departments = _departmentservice.GetDepartments().ToList();
            return departments;
        }
    }
}