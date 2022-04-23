using Microsoft.AspNetCore.Mvc;
using SmartLoan.Models;
using SmartLogic;
using SmartHelper;

namespace SmartLoan.Controllers
{
    [OverrideMenuComponentFilter]
    public class HomeController : Controller
    {

        private readonly IDashboardService _service;

        public HomeController(IDashboardService service) => _service = service;

        public IActionResult Dashboard()
        {

            DashBoardViewModel dashboard = new DashBoardViewModel
            {
                ProductPayments = _service.GetProductPayments(),
                NewClientsCount = _service.GetNewClientRegistrations(),
                UserToDoList = _service.GetUserToDoList(),
                Notices = _service.GetOpenNotices(),
                NewLoans = _service.GetNewLoans(),
                ClientWithLoans = _service.GetClientWithLoans(),
                ClientWithoutLoans = _service.GetClientWithLoans(),
                Birthdays = _service.GetBirthdays()

            };
            return View(dashboard);

        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult UnAuthorizedAccess(string name) => View(new Access { Name = name });
    }
}
