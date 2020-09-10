using Microsoft.AspNetCore.Mvc;
using SmartSave.Models;
using SmartLogic;

namespace SmartSave.Controllers
{
    public class HomeController : Controller
    {

        private readonly IDashboardService _service;
        public HomeController(IDashboardService service)
        {
            _service = service;
        }

        public IActionResult Dashboard()
        {

            DashBoardViewModel dashboard = new DashBoardViewModel
            {
                ProductPayments = _service.GetProductPayments(),
                Enquiries = 0,//_service.GetOpenEnquiries(),
                NewClientsCount = _service.GetNewClientRegistrations(),
                EventsThisWeek = 0,//_service.GetEventsThisWeek(),
                Notices = _service.GetOpenNotices()
              
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
    }
}
