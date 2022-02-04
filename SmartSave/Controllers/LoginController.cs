﻿using SmartLogic;

using SmartSave.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using SmartDataAccess;
using SmartHelper;
using SmartDomain;
using System;
using Microsoft.AspNetCore.Http;
using System.Threading;
using SmartInterfaces;
using SmartMail;
using SmartLog;
using System.Linq;

namespace SmartSave.Controllers
{
    [AllowAnonymous]
    [OverrideMenuComponentFilter]
    public class LoginController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly ILoginService _service;
        private readonly IMailService _mailService;
        private readonly IClientService _clientService;
        private readonly IUserService _userService;

        public LoginController(DatabaseContext context, ILoginService service, IMailService mailService,
        IClientService clientService, IUserService userService)
        {
            _context = context;
            _service = service;
            _mailService = mailService;
            _clientService = clientService;
            _userService = userService;

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
            if (UtilityService.IsNotNull(maintanance))
                return RedirectToAction("MaintananceMode", "Maintanance");

            var licence = GetData.LicenceMode();
            if (UtilityService.IsNotNull(licence))
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
            if (UtilityService.IsNotNull(user))
            {
                if (user.IsActive)
                {
                    UtilityService.CurrentUserName = user.UserName;
                    UtilityService.UserFullName = user.UserFullName;
                    UtilityService.UserProfileImage = user.ProfileImage;
                    UtilityService.CurrentUserTypeID = user.UserTypeID;
                    UtilityService.CanOverrideMaintananceMode = user.CanOverrideMaintananceMode;
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
                        IsReverify=user.ReVerify
                    };
                    var result = _service.GeneratePinCode(userAuthenticate);
                    if (UtilityService.IsNotNull(result.PinCode))
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
                if (UtilityService.IsNotNull(client))
                    return RedirectToAction("ViewClient", "Client", new { id = client.ClientID });
                else
                    return RedirectToAction("Dashboard", "Home");
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

            Email email = new Email();
            email.To = userAuthenticate.EmailAddress;
            email.AttachmentFromMemory = null;
            string _emailBody = @$"Hello {userAuthenticate.FullName},<br/><br/>" +
                          "Your one time passcode for <a href = " + UtilityService.SiteURL + ">" + UtilityService.ApplicationName + "</a> is : <br/>" +
                          "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>" + Encryption.Decrypt(userAuthenticate.PinCode) + "</b><br/>" +
                           "Please be aware that this code is valid until "
                            + userAuthenticate.ExpiryDate + ".<br/><br/>" +
                           @"Regards,<br/><br/><b>" + UtilityService.ApplicationName + " Customer Service</b><br/><br/><br/>"
                           + "Please do not reply to this email.<br/><br/>" +
                            @"For any questions or information, please contact: email " + UtilityService.CustomerServiceEmail + ", or call " + UtilityService.ApplicationName + "customer service  at  " + UtilityService.CustomerServiceNumber + ".<br/><br/>";
            email.Body = UtilityService.HtmlDecode(_emailBody);
            email.Subject = UtilityService.SiteEnvironment == SiteEnvironment.Production ? $"Passcode for {UtilityService.ApplicationName}" : $"{UtilityService.SiteEnvironment} - Passcode for {UtilityService.ApplicationName}";
            bool emailSuccessResult = _mailService.SendMail(email).Result;
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
                PinCode = confirmCode.Code,
                DoNotAskForTheDay = confirmCode.DoNotAskForTheDay,
                
            };

            if (UtilityService.IsNotNull(confirmCode.Code))
            {                
                UserAuthenticationCode userAuthenticationCode = await _service.ConfirmCode(userAuthenticate);
                if (UtilityService.IsNotNull(userAuthenticationCode))
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
        public async Task<IActionResult> ForgotPassword(ForgotPasswordViewModel model)
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
            if (UtilityService.IsNotNull(result))
            {
                string pincode = result.PinCode;
                Email email = new Email();
                email.To = model.EmailAddress;
                email.AttachmentFromMemory = null;
                string _emailBody = @"We have sent you this email in response to your request to reset your password on " + UtilityService.ApplicationName + ".<br/><br/>" +
                              "To reset your password for <a href = " + UtilityService.SiteURL + ">" + UtilityService.ApplicationName + "</a>, please follow the link below:<a href = " + UtilityService.SiteURLPasswordReset + ">Password Reset Link </a>." +
                              "CONFIRMATION CODE <b>" + Encryption.Decrypt(pincode) + "</b><br/><br/>" +
                               "We recommend that you keep your password secure and not share it with anyone.If you feel your password has been compromised, you can change it by  logging in to  " +
                               "<a href = " + UtilityService.SiteURL + ">" + UtilityService.ApplicationName + " </a>  ,going to your profile and clicking the  <b>'Change Email Address or Password'</b> link.<br/><br/>" +
                               @"If you need help, or you have any other questions, feel free to email " + UtilityService.CustomerServiceEmail + ", or call " + UtilityService.ApplicationName + "customer service  at  " + UtilityService.CustomerServiceNumber + ".<br/><br/> Regards,<br/><br/><br/><b>" + UtilityService.ApplicationName + " Customer Service</b>.";
                email.Body = UtilityService.HtmlDecode(_emailBody);
                email.Subject = $"Password Reset -{UtilityService.ApplicationName}";
                bool emailSuccessResult = await _mailService.SendMail(email);
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
            if (UtilityService.IsNotNull(pinReset))
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
        public ActionResult PasswordReset(int id)
        {
            HttpContext.Session.SetString("UserIDKey", id.ToString());
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PasswordReset(PasswordResetModel model)
        {

            if (model.Password.Equals(model.ConfirmPassword))
            {
                int userID = Convert.ToInt32(HttpContext.Session.GetString("UserIDKey"));
                int result = await _service.PasswordChange(userID, model.Password);
                if (result > 0)
                {
                    TempData[MessageDisplayType.Success.ToString()] = "Password Reset Completed Successfully";
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
            if (UtilityService.IsNotNull(client))
            {

                // check if user does not already have a user  account 
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
                if (UtilityService.IsNotNull(result))
                {
                    string pincode = result.PinCode;
                    Email email = new Email();
                    email.To = model.EmailAddress;
                    email.AttachmentFromMemory = null;
                    string _emailBody = @"We have sent you this email in response to your request to create an account on " + UtilityService.ApplicationName + ".<br/><br/>" +
                                  "To continue  with this process on <a href = " + UtilityService.SiteURL + ">" + UtilityService.ApplicationName + "</a> , please follow the link below : <a href = " + UtilityService.SiteURLAccountCreation + ">Account Creation  Link </a> ." +
                                    "CONFIRMATION CODE <b>" + Encryption.Decrypt(pincode) + "</b><br/><br/>" +
                                   "We recommend that you keep your account details secure and not share it with anyone.If you feel your credentials have  been compromised, " +
                                    @"or you have any other questions, feel free to email " + UtilityService.CustomerServiceEmail + ", or call " + UtilityService.ApplicationName + "customer service  at  " + UtilityService.CustomerServiceNumber + ".<br/><br/> Regards,<br/><br/><br/>" + UtilityService.ApplicationName + " Customer Service";
                    email.Body = UtilityService.HtmlDecode(_emailBody);
                    email.Subject = $"Account Creation - {UtilityService.ApplicationName}";
                    bool emailSuccessResult = await _mailService.SendMail(email);
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
            if (UtilityService.IsNotNull(pinReset))
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
            user.UserName = client.UserName;
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

                Email email = new Email();
                email.To = client.EmailAddress;
                email.AttachmentFromMemory = null;
                string _emailBody = @"Your user account has been created successfully  account on " + UtilityService.ApplicationName + ".<br/><br/>" +
                                   "We recommend that you keep your account details secure and not share it with anyone.If you feel your credentials have  been compromised, " +
                                @"or you have any other questions, feel free to email " + UtilityService.CustomerServiceEmail + ", or call " + UtilityService.ApplicationName + "customer service  at  " + UtilityService.CustomerServiceNumber + ". Your login password is <b>" + _userService.GetCredential(result) + "</b>.<br/><br/> Regards,<br/><br/><br/>" + UtilityService.ApplicationName + " Customer Service";
                email.Body = UtilityService.HtmlDecode(_emailBody);
                email.Subject = $"New Account Created - {UtilityService.ApplicationName}";
                bool emailSuccessResult = await _mailService.SendMail(email);
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