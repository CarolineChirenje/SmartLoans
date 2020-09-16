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
    public class LoginController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly ILoginService _service;
        private readonly IMailService _mailService;

        public LoginController(DatabaseContext context, ILoginService service, IMailService mailService)
        {
            _context = context;
            _service = service;
            _mailService = mailService;
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
                ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
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
                    return RedirectToLocal(returnUrl);
                }

                else
                {
                    ViewData[MessageDisplayType.Warning.ToString()] = UtilityService.GetMessageToDisplay("USERINACTIVE");
                    return View(model);
                }
            }
            else
            {
                ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("USERLOGIN");
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
                ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return View(model);
            }

            string pincode = await _service.ResetPassword(model.EmailAddress);
            if (UtilityService.IsNotNull(pincode))
            {

                Email email = new Email();
                email.To = model.EmailAddress;
                email.AttachmentFromMemory = null;
                string _emailBody = @"We have sent you this email in response to your request to reset your password on " + UtilityService.ApplicationName + ".<br/><br/>" +
                              "To reset your password for <a href = " + UtilityService.SiteURL + ">" + UtilityService.ApplicationName + "</a>, please follow the link below:<a href = " + UtilityService.SiteURLPasswordReset + ">Password Reset Link </a>." +
                              "CONFIRMATION CODE <b>" + Encryption.Decrypt(pincode) + "</b><br/><br/>" +
                               "We recommend that you keep your password secure and not share it with anyone.If you feel your password has been compromised, you can change it by going to your "+
                               "<a href = " + UtilityService.SiteURL + " >" + UtilityService.ApplicationName + " </ a > logging in and going to your profile and click the  'Change Email Address or Password' link.<br/><br/>" +
                               @"If you need help, or you have any other questions, feel free to email " + UtilityService.CustomerServiceEmail + ", or call " + UtilityService.ApplicationName + "customer service  at  " + UtilityService.CustomerServiceNumber + ".<br/><br/> Regards,<br/><br/><br/>" + UtilityService.ApplicationName + " Customer Service";
                email.Body = UtilityService.HtmlDecode(_emailBody);
                email.Subject = $"Password Reset -{UtilityService.ApplicationName}";


                if (_mailService.SendMail(email, false))
                {
                    ViewData[MessageDisplayType.Success.ToString()] = $"We have sent an email {model.EmailAddress} with the password reset details.";
                    return View(model);
                }

                else
                {
                    ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return View(model);
                }
            }
            else
            {
                ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return View(model);
            }
        }

        [AllowAnonymous]
        public ActionResult ForgotPasswordConfirmation() => View();

        [HttpPost]
        public async Task<IActionResult> ForgotPasswordConfirmation(string Code)
        {


            UserPinReset pinReset = await _service.ConfirmCode(Code);
            if (UtilityService.IsNotNull(pinReset))
            {
                DateTime calculatedExpiryDate = pinReset.ExpiryDate;
                if (DateTime.Now > calculatedExpiryDate)
                {
                    ViewData[MessageDisplayType.Error.ToString()] = $"This pin expired on {UtilityService.ShowDateTime(calculatedExpiryDate)}";
                    return View(Code);
                }
                else
                {
                    return RedirectToAction("PasswordReset", new { id = pinReset.UserID });

                }

            }
            else
            {
                ViewData[MessageDisplayType.Error.ToString()] = "A match for the code provided could not be found";
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
                    ViewData[MessageDisplayType.Success.ToString()] = "Password Reset Complete";
                    return View(model);
                }
                else
                {
                    ViewData[MessageDisplayType.Error.ToString()] = "An error occurred failed to reset password";
                    return View(model);
                }
            }
            else
            {
                ViewData[MessageDisplayType.Error.ToString()] = "Passwords do not match";
                return View(model);
            }
        }
    }
}