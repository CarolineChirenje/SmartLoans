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
               public CoursesController(ICourseService service)
        {
            _service = service;
           
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


        public async Task<IActionResult> ChangeCoursestatus(int id, bool status)
        {
            if (await (_service.ActionCourse(id, status ? DatabaseAction.Deactivate : DatabaseAction.Reactivate)) == 0)
                ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewCourse", new { id });
        }


        /// <summary>
        /// Course Outline
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 

        [HttpPost]
        public async Task<IActionResult> AddCourseOutline(CourseOutline courseOutline)
        {
            if (ModelState.IsValid)
            {

                if (await (_service.Save(courseOutline)) == 0)
                {
                    ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewCourse", new { id = courseOutline.CourseID });
                }

            }
            return RedirectToAction("ViewCourse", new { id = courseOutline.CourseID });
        }

        public async Task<IActionResult> ViewCourseOutline(int outlineid, int courseid)
        {
            if (outlineid == 0)
                return RedirectToAction("ViewCourse", new { id = courseid});

            return View(await _service.FindCourseOutline(outlineid));
        }


        [HttpPost]
        public async Task<IActionResult> ViewCourseOutline(CourseOutline courseoutline)
        {
            if (ModelState.IsValid)
            {
                CourseOutline update = await _service.FindCourseOutline(courseoutline.CourseOutlineID);
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(courseoutline)) == 0)
                        ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewCourseOutline", new { id = courseoutline.CourseOutlineID });
                }
                return RedirectToAction("ViewCourseOutline", new { id = courseoutline.CourseOutlineID });
            }
            ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewCourseOutline", new { id = courseoutline.CourseOutlineID });
        }
        public async Task<IActionResult> ActionNote(int outlineid, int courseid)
        {
            if (await (_service.ActionCourseOutline(outlineid, DatabaseAction.Remove)) == 0)
                ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewCourse", new { id = courseid });
        }
    }
}