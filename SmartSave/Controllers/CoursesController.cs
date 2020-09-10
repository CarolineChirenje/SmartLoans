using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLogic;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc.Rendering;
using SmartHelper;
using SmartDomain;

namespace SmartSave.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseService _service;
        private readonly IDepartmentService _departmentService;
        public CoursesController(ICourseService service, IDepartmentService departmentService)
        {
            _service = service;
            _departmentService = departmentService;
        }

        public async Task<IActionResult> Courses()
        {
            return View(await _service.Courses());
        }

        public IActionResult AddCourse()
        {
                       return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddCourse(Course Course)
        {
          
            if (ModelState.IsValid)
            {
                if (await (_service.Save(Course)) == 0)
                    ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction(nameof(Courses));
            }
            ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Course);
        }
        // GET:
        public async Task<IActionResult> ViewCourse(int id = 0)
        {
            
            if (id == 0)
                return RedirectToAction(nameof(Courses));
          
            return View(await _service.FindCourse(id));
        }


        [HttpPost]
        public async Task<IActionResult> ViewCourse(Course Course)
        {
           
            if (ModelState.IsValid)
            {
                Course update = await (_service.FindCourse(Course.CourseID));
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(Course)) == 0)
                        ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(Courses));
                }
                return View(Course);
            }
            ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Course);
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.Delete(id)) > 0)
                return RedirectToAction(nameof(Courses));
            else
            {
                ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewCourse", new { id });
            }

        }
        public async Task<IActionResult> ChangeCoursestatus(int id, bool status)
        {
            if (await (_service.ActionCourse(id, status ? DatabaseAction.Deactivate : DatabaseAction.Reactivate)) == 0)
                ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewCourse", new { id });
        }

        }
}