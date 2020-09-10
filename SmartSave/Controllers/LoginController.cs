using SmartLogic;

using SmartSave.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using SmartDataAccess;
using SmartHelper;
using SmartDomain;

namespace SmartSave.Controllers
{
    public class LoginController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly    ILoginService _service;

        public LoginController(DatabaseContext context, ILoginService service)
        {
            _context = context;
            _service = service;
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

            User user =await _service.Login(model.EmailAddress, model.Password);
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


    }
}