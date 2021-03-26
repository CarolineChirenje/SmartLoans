using SmartLogic;

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

namespace SmartSave.Controllers
{
    [AllowAnonymous]
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

        // GET: /Account/Login
        [AllowAnonymous]
        public ActionResult Login() => View();
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
                    UtilityService.CurrentUserTypeID = user.UserTypeID;
                    if (DateTime.Now > user.PasswordExpiryDate)
                        return RedirectToAction("PasswordReset", new { id = user.UserID });

                    else
                    {
                        if (user.UserTypeID == (int)TypeOfUser.Employee)
                        {
                            Client client = await _clientService.ClientDetails(user.EmailAddress, user.IDNumber);
                            if (UtilityService.IsNotNull(client))
                            {
                                return RedirectToAction("ViewClient", "Client", new { id = client.ClientID });
                            }
                            else
                            return RedirectToLocal(returnUrl);
                        }
                        else
                            return RedirectToLocal(returnUrl);

                    }
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
        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Dashboard", "Home");
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

            string pincode = await _service.ResetPassword(model.EmailAddress,null,false);
            if (UtilityService.IsNotNull(pincode))
            {

                Email email = new Email();
                email.To = model.EmailAddress;
                email.AttachmentFromMemory = null;
                string _emailBody = @"We have sent you this email in response to your request to reset your password on " + UtilityService.ApplicationName + ".<br/><br/>" +
                              "To reset your password for <a href = " + UtilityService.SiteURL + ">" + UtilityService.ApplicationName + "</a>, please follow the link below:<a href = " + UtilityService.SiteURLPasswordReset + ">Password Reset Link </a>." +
                              "CONFIRMATION CODE <b>" + Encryption.Decrypt(pincode) + "</b><br/><br/>" +
                               "We recommend that you keep your password secure and not share it with anyone.If you feel your password has been compromised, you can change it by going to your " +
                               "<a href = " + UtilityService.SiteURL + ">" + UtilityService.ApplicationName + " </a> logging in and going to your profile and clicking the  <b>'Change Email Address or Password'</b> link.<br/><br/>" +
                               @"If you need help, or you have any other questions, feel free to email " + UtilityService.CustomerServiceEmail + ", or call " + UtilityService.ApplicationName + "customer service  at  " + UtilityService.CustomerServiceNumber + ".<br/><br/> Regards,<br/><br/><br/><b>" + UtilityService.ApplicationName + " Customer Service</b>.";
                email.Body = UtilityService.HtmlDecode(_emailBody);
                email.Subject = $"Password Reset -{UtilityService.ApplicationName}";


                if (_mailService.SendMail(email, false))
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


            UserAuthenticationCode pinReset = await _service.ConfirmCode(Code);
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
                    TempData[MessageDisplayType.Success.ToString()] = "Password Reset Complete";
                    return View(model);
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

            Client client = await _clientService.ClientDetails(model.EmailAddress, model.IDNumber);
            if (UtilityService.IsNotNull(client))
            {

                // check if user does not already have a user  account 
                bool _accountExists = await _service.UserAccountExists(client.EmailAddress, client.IDNumber);
                if (_accountExists)
                {
                    TempData[MessageDisplayType.Error.ToString()] = $"An account registered  with the following Email Address {client.EmailAddress} and ID Number {client.IDNumber} already exists please try to do a password reset if you have forgotten your details or contact our Customer Service Support on {UtilityService.CustomerServiceNumber}   for further help";
                    return View(model);
                }
                string pincode = await _service.ResetPassword(model.EmailAddress,  model.IDNumber,true);
                if (UtilityService.IsNotNull(pincode))
                {
                    Email email = new Email();
                    email.To = model.EmailAddress;
                    email.AttachmentFromMemory = null;
                    string _emailBody = @"We have sent you this email in response to your request to create an account on " + UtilityService.ApplicationName + ".<br/><br/>" +
                                  "To continue  with this process on <a href = " + UtilityService.SiteURL + ">" + UtilityService.ApplicationName + "</a>, please follow the link below:<a href = " + UtilityService.SiteURLAccountCreation + ">Account Creation  Link </a>." +
                                    "CONFIRMATION CODE <b>" + Encryption.Decrypt(pincode) + "</b><br/><br/>" +
                                   "We recommend that you keep your account details secure and not share it with anyone.If you feel your credentials have  been compromised, " +
                                    @"or you have any other questions, feel free to email " + UtilityService.CustomerServiceEmail + ", or call " + UtilityService.ApplicationName + "customer service  at  " + UtilityService.CustomerServiceNumber + ".<br/><br/> Regards,<br/><br/><br/>" + UtilityService.ApplicationName + " Customer Service";
                    email.Body = UtilityService.HtmlDecode(_emailBody);
                    email.Subject = $"Account Creation - {UtilityService.ApplicationName}";


                    if (_mailService.SendMail(email, false))
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


            UserAuthenticationCode pinReset = await _service.ConfirmCode(Code, true);
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
            Client client = _clientService.FindClient(id).Result;
            return View(client);
        }

        [HttpPost]
        public async Task<IActionResult> FinaliseAccount()
        {


            int userID = Convert.ToInt32(HttpContext.Session.GetString("UserIDKey"));

            Client client = _clientService.FindClient(userID).Result;

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
                if (_mailService.SendMail(email, false))
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