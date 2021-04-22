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
                               NewClientsCount = _service.GetNewClientRegistrations(),
                CoursePrograms = _service.GetNewCourses(),
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
