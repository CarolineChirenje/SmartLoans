using SmartLogic;
using SmartLoan.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using SmartDataAccess;
using SmartHelper;
using SmartDomain;
using System;
using Microsoft.AspNetCore.Http;
using SmartInterfaces;
using SmartMail;
using SmartLog;
using System.Linq;
using SmartExtensions;
using SmartAsync;
using Microsoft.Extensions.Caching.Memory;
using System.Collections.Generic;

namespace SmartLoan.Controllers
{
    [AllowAnonymous]
    [OverrideMenuComponentFilter]
    public class LoginController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly ILoginService _service;
        private readonly IClientService _clientService;
        private readonly IUserService _userService;
        private readonly IMenuService _menuService;
        public LoginController(IMenuService menuService, DatabaseContext context, ILoginService service,
        IClientService clientService, IUserService userService)
        {
            _context = context;
            _service = service;
            _clientService = clientService;
            _userService = userService;
            _menuService = menuService;
        }
        public IActionResult UserNotFound()
        {
            return View();
        }
        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login()
        {
            var maintanance = GetData.MaintananceMode();
            if (maintanance.IsNotNull())
                return RedirectToAction("MaintananceMode", "Maintanance");

            var licence = GetData.LicenceMode();
            if (licence.IsNotNull())
                return RedirectToAction("LicenceMode", "Licence");
            return View();
        }

        public ActionResult Logout()
        {
            UtilityService.ClearUserNames();
            return RedirectToAction(nameof(Login));
        }
        // POST: /Account/Login
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return View(model);
            }

            User user = await _service.Login(model.EmailAddress, model.Password);
            if (user.IsNotNull())
            {
                if (user.IsActive)
                {
                    UserAppData.CurrentUserName = user.EmailAddress;
                    UserAppData.UserFullName = user.UserFullName;
                    UserAppData.UserProfileImage = user.ProfileImage;
                    UserAppData.CurrentUserTypeID = user.UserTypeID;
                    UserAppData.CanOverrideMaintananceMode = user.CanOverrideMaintananceMode;

                    UserAppData.UserType = (TypeOfUser)user.UserTypeID;
                    var userRoles = user.UserRoles.ToList();
                    var userRolePermissions = userRoles.SelectMany(r => r.Roles.RolePermissions).ToList();
                    UserAppData.Roles = userRoles.Select(r => r.RoleID).ToList();
                    UserAppData.UserRoleID = userRoles.FirstOrDefault()?.UserRoleID ?? 0;
                    UserAppData.UserRole = userRoles.FirstOrDefault()?.Roles.Name;
                    UserAppData.Permissions = userRolePermissions.Select(p => p.PermissionID).ToList();
                    UserAppData.SiteEnvironment = UtilityService.GetEnvironment;
                    UserAppData.IsNotAdmin = user.UserTypeID != (int)TypeOfUser.Administrator;
                    UserAppData.ApplicationName = UtilityService.GetApplicationName;
                    UserAppData.CompanyID = user.CompanyID??0;
                    UserAppData.GrantAccessToTestEnvironment = user.GrantAccessToTestEnvironment;
                    UserAppData.UserEmailAddress = user.EmailAddress;

                    GetAppData().Wait();
                    if (DateTime.Now > user.PasswordExpiryDate)
                        return RedirectToAction("PasswordReset", new { id = user.UserID });
                    else
                        return RedirectToSystem(returnUrl, user);
                }
                else
                {
                    TempData[MessageDisplayType.Warning.ToString()] = UtilityService.GetMessageToDisplay("USERINACTIVE");
                    return View(model);
                }
            }
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("USERLOGIN");
                return View(model);
            }
        }

        public async Task GetAppData()
        {
            AppData.MenuGroups = await _menuService.DisplayMenuGroups();
            AppData.SettingsMenu = await _menuService.DisplayLayouts(LayoutComponent.Settings);
            AppData.DeveloperMenu = await _menuService.DisplayLayouts(LayoutComponent.Khonapo_Fund);
            AppData.ReportMenu = await _menuService.DisplayLayouts(LayoutComponent.Reporting);
            AppData.ClientMenu = await _menuService.DisplayLayouts(LayoutComponent.Client);
            AppData.KhonapoMenu = await _menuService.DisplayLayouts(LayoutComponent.Khonapo_Fund);
            AppData.EmployeeMenu = await _menuService.DisplayLayouts(LayoutComponent.Employees);
            AppData.EmployerMenu = await _menuService.DisplayLayouts(LayoutComponent.Employers);

        }

        private ActionResult RedirectToSystem(string returnUrl, User user = null)
        {
            if (user == null)
                return RedirectToLocal(returnUrl);
            bool accessDefaultGrant = user.UserAccessGrants.Any(a => a.AllowUntil > DateTime.Now);
            if (UtilityService.AllowTwoFactorAuthentication && !accessDefaultGrant)
            {
                try
                {
                    HttpContext.Session.SetString("UserIDKey", user.UserID.ToString());
                    UserAuthenticate userAuthenticate = new UserAuthenticate()
                    {
                        EmailAddress = user.EmailAddress,
                        FullName = user.UserFullName,
                        CodeType = CodeType.Multi_Factor_Authenticator,
                        UserID = user.UserID,
                        IsReverify = user.ReVerify
                    };
                    var result = _service.GeneratePinCode(userAuthenticate);
                    if (result.PinCode.IsNotNull())
                    {
                        userAuthenticate.PinCode = result.PinCode;
                        userAuthenticate.ExpiryDate = UtilityService.ShowDateTime(result.ExpiryDate);
                        return RedirectToAction("Authenticate", "Login", userAuthenticate);
                    }
                    else
                        return RedirectToLocal(returnUrl);
                }
                catch (Exception ex)
                {
                    CustomLog.Log(LogSource.Logic_Base, ex);
                    return RedirectToLocal(returnUrl);
                }
            }
            else
                return RedirectToLandingPage(user);
        }
        private ActionResult RedirectToLandingPage(User user)
        {
            if (user.UserTypeID == (int)TypeOfUser.Employee)
            {
                ClientPeek client = _clientService.GetClient(user.EmailAddress, user.IDNumber).Result;
                if (client.IsNotNull())
                    return RedirectToAction("ViewClient", "Client", new { id = client.ClientID });
                else
                    return RedirectToAction("Dashboard", "External");
            }

            else if (user.UserTypeID == (int)TypeOfUser.Employer)
            {
                if (user.CompanyID.HasValue)
                    return RedirectToAction("Clients", "Client", new { companyID = user.CompanyID.Value });
                else
                    return RedirectToAction("Dashboard", "External");
            }
            else
                return RedirectToAction("Dashboard", "Home");

        }
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Dashboard", "Home");

        }
        public ActionResult Authenticate(UserAuthenticate userAuthenticate)
        {
            Email email = EmailService.SendPassCode(userAuthenticate);
            bool emailSuccessResult = RabbitQueue.Publish(email);
            if (emailSuccessResult)
                return RedirectToAction("Verify", "Login", userAuthenticate);
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return View();
            }

        }
        public ActionResult ReVerify(int id)
        {
            User user = _service.GetUser(id).Result;
            user.ReVerify = true;
            return RedirectToSystem(string.Empty, user);
        }
        public ActionResult Verify(UserAuthenticate userAuthenticate)
        {
            if (userAuthenticate == null)
                return RedirectToSystem(string.Empty, null);
            return View(userAuthenticate);
        }
        [HttpPost]
        public async Task<IActionResult> Verify(ConfirmCode confirmCode)
        {
            int userID = Convert.ToInt32(HttpContext.Session.GetString("UserIDKey"));
            UserAuthenticate userAuthenticate = new UserAuthenticate()
            {
                UserID = confirmCode.UserID == 0 ? userID : confirmCode.UserID,
                CodeType = CodeType.Multi_Factor_Authenticator,
                PinCode = confirmCode.Code.Trim(),
                DoNotAskForTheDay = confirmCode.DoNotAskForTheDay,

            };

            if (confirmCode.Code.IsNotNull())
            {
                UserAuthenticationCode userAuthenticationCode = await _service.ConfirmCode(userAuthenticate);
                if (userAuthenticationCode.IsNotNull())
                {
                    DateTime calculatedExpiryDate = userAuthenticationCode.ExpiryDate;
                    if (DateTime.Now > calculatedExpiryDate)
                    {
                        TempData[MessageDisplayType.Error.ToString()] = $"This pin expired on {UtilityService.ShowDateTime(calculatedExpiryDate)}";
                        userAuthenticate.Success = false;
                        return View(userAuthenticate);
                    }
                    else
                        return RedirectToLandingPage(userAuthenticationCode.User);
                }
                else
                {
                    TempData[MessageDisplayType.Error.ToString()] = "Pass Code Mismatch";
                    userAuthenticate.Success = false;
                    return View(userAuthenticate);
                }
            }
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = "Invalid Confirmation Code";
                userAuthenticate.Success = false;
                return View(userAuthenticate);
            }
        }


        [AllowAnonymous]
        public ActionResult ForgotPassword() => View();

        [HttpPost]
        public ActionResult ForgotPassword(ForgotPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return View(model);
            }
            UserAuthenticate authenticate = new UserAuthenticate()
            {
                IsAccountCreation = false,
                EmailAddress = model.EmailAddress,
                CodeType = CodeType.Password_Reset
            };
            var result = _service.GeneratePinCode(authenticate);
            if (result.IsNotNull())
            {
                authenticate.PinCode = result.PinCode;
                Email email = EmailService.SendPasswordReset(authenticate);
                bool emailSuccessResult = RabbitQueue.Publish(email);
                if (emailSuccessResult)
                {
                    TempData[MessageDisplayType.Success.ToString()] = $"We have sent an email {model.EmailAddress} with the password reset details.";
                    return View(model);
                }
                else
                {
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return View(model);
                }
            }
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return View(model);
            }
        }

        [AllowAnonymous]
        public ActionResult ForgotPasswordConfirmation() => View();

        [HttpPost]
        public async Task<IActionResult> ForgotPasswordConfirmation(string Code)
        {
            int userID = Convert.ToInt32(HttpContext.Session.GetString("UserIDKey"));
            UserAuthenticate userAuthenticate = new UserAuthenticate()
            {
                UserID = userID,
                CodeType = CodeType.Password_Reset,
                PinCode = Code
            };

            UserAuthenticationCode pinReset = await _service.ConfirmCode(userAuthenticate);
            if (pinReset.IsNotNull())
            {
                DateTime calculatedExpiryDate = pinReset.ExpiryDate;
                if (DateTime.Now > calculatedExpiryDate)
                {
                    TempData[MessageDisplayType.Error.ToString()] = $"This pin expired on {UtilityService.ShowDateTime(calculatedExpiryDate)}";
                    return View(Code);
                }
                else
                {
                    return RedirectToAction("PasswordReset", new { id = pinReset.UserID });
                }
            }
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = "A match for the code provided could not be found";
                return View(Code);
            }
        }

        [AllowAnonymous]
        public ActionResult PasswordReset(int id, int resetTypeID = 1)
        {
            HttpContext.Session.SetString("UserIDKey", id.ToString());
            PasswordResetModel model = new PasswordResetModel()
            { UserID = id, ResetTypeID = resetTypeID };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> PasswordReset(PasswordResetModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Password.Equals(model.ConfirmPassword))
                {
                    int userID = Convert.ToInt32(HttpContext.Session.GetString("UserIDKey"));
                    int result = await _service.PasswordChange(userID, model.Password);
                    if (result > 0)
                    {
                        TempData[MessageDisplayType.Success.ToString()] = "Password Reset Completed Successfully";
                        if (model.ResetTypeID == 2)
                            return RedirectToAction("ViewUser", "User", new { id = model.UserID });

                        return RedirectToAction("Login");
                    }
                    else
                    {
                        TempData[MessageDisplayType.Error.ToString()] = "An error occurred failed to reset password";
                        return View(model);
                    }
                }
                else
                {
                    TempData[MessageDisplayType.Error.ToString()] = "Passwords do not match";
                    return View(model);
                }
            }
            {
             
                return View(model);
            }

        }



        [AllowAnonymous]
        public ActionResult RegisterAccount() => View();

        [HttpPost]
        public async Task<IActionResult> RegisterAccount(RegisterAccountViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return View(model);
            }

            ClientPeek client = await _clientService.GetClient(model.EmailAddress, model.IDNumber);
            if (client.IsNotNull())
            {        // check if user does not already have a user  account 
                bool _accountExists = await _service.UserAccountExists(client.EmailAddress, client.IDNumber);
                if (_accountExists)
                {
                    TempData[MessageDisplayType.Error.ToString()] = $"An account registered  with the following Email Address {client.EmailAddress} and ID Number {client.IDNumber} already exists please try to do a password reset if you have forgotten your details or contact our Customer Service Support on {UtilityService.CustomerServiceNumber}   for further help";
                    return View(model);
                }
                UserAuthenticate authenticate = new UserAuthenticate()
                {
                    IsAccountCreation = true,
                    EmailAddress = model.EmailAddress,
                    IDNumber = model.IDNumber,
                    CodeType = CodeType.Password_Reset
                };
                var result = _service.GeneratePinCode(authenticate);
                if (result.IsNotNull())
                {
                    authenticate.PinCode = result.PinCode;
                    Email email = EmailService.SendAccountCreationCode(authenticate);
                    bool emailSuccessResult = RabbitQueue.Publish(email);
                    if (emailSuccessResult)
                    {
                        TempData[MessageDisplayType.Success.ToString()] = $"We have sent an email to {model.EmailAddress} with further  details regarding account creation.";
                        return View(model);
                    }
                    else
                    {
                        TempData[MessageDisplayType.Success.ToString()] = $"Failed to send email with further  details regarding account creation.Please contact our Customer Service Support on {UtilityService.CustomerServiceNumber} for help.";
                        return View(model);
                    }
                }
                else
                {
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return View(model);
                }
            }
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = "A match has not been found";
                return View(model);
            }
        }



        [AllowAnonymous]
        public ActionResult CreateAccountConfirmation() => View();

        [HttpPost]
        public async Task<IActionResult> CreateAccountConfirmation(string Code)
        {
            UserAuthenticate userAuthenticate = new UserAuthenticate()
            {
                PinCode = Code,
                IsAccountCreation = true
            };
            UserAuthenticationCode pinReset = await _service.ConfirmCode(userAuthenticate);
            if (pinReset.IsNotNull())
            {
                DateTime calculatedExpiryDate = pinReset.ExpiryDate;
                if (DateTime.Now > calculatedExpiryDate)
                {
                    TempData[MessageDisplayType.Error.ToString()] = $"This pin expired on {UtilityService.ShowDateTime(calculatedExpiryDate)}";
                    return View(Code);
                }
                else
                {
                    return RedirectToAction("FinaliseAccount", new { id = pinReset.ClientID });
                }
            }
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = "A match for the code provided could not be found";
                return View(Code);
            }
        }

        [AllowAnonymous]
        public ActionResult FinaliseAccount(int id)
        {
            HttpContext.Session.SetString("UserIDKey", id.ToString());
            ClientForm client = _clientService.FindClient(id).Result;
            return View(client);
        }

        [HttpPost]
        public async Task<IActionResult> FinaliseAccount()
        {
            int userID = Convert.ToInt32(HttpContext.Session.GetString("UserIDKey"));
            ClientPeek client = _clientService.GetClient(clientID: userID).Result;
            User user = new User();
            user.EmailAddress = client.EmailAddress;
            user.FirstName = client.FirstName;
            user.LastName = client.LastName;
                       user.IDNumber = client.IDNumber;
            user.IsActive = true;
            user.UserTypeID = (int)TypeOfUser.Employee;
            int result = await _userService.Save(user, false);
            if (result == 0)
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return View(user);
            }
            else
            {
                string password = _userService.GetCredential(result);
                Email email = EmailService.SendAccountCreationConfirmation(client.EmailAddress, password);
                bool emailSuccessResult = RabbitQueue.Publish(email);
                if (emailSuccessResult)
                {
                    TempData[MessageDisplayType.Success.ToString()] = $"Account creation complete.We have sent an email to {client.EmailAddress} with your login credentials.";
                    return View(client);
                }
                else
                {
                    TempData[MessageDisplayType.Success.ToString()] = $"Account has been created successfully but we failed to send an  email with further  details regarding account creation.Please contact our Customer Service Support on {UtilityService.CustomerServiceNumber} for help.";
                    return View(client);
                }

            }
        }


    }
}