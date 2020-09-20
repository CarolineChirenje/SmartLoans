using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLogic;
using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Mvc.Rendering;
using SmartHelper;
using SmartDomain;
using Microsoft.AspNetCore.Http;
using SmartSave.Models;

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

            HttpContext.Session.SetString("CourseID", id.ToString());
            PopulateDropDownList();
            return View(await _service.FindCourse(id));
        }


        [HttpPost]
        public async Task<IActionResult> ViewCourse(Course Course)
        {
            PopulateDropDownList();
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
            if (await (_service.ActionCourse(id, DatabaseAction.Remove)) == 0)
            {
                ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewCourse", new { id });

            }
            return RedirectToAction(nameof(Courses));

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
            CourseOutline _courseoutline = await _service.FindCourseOutline(courseoutline.CourseOutlineID);
            if (ModelState.IsValid)
            {
               
                if (UtilityService.IsNotNull(_courseoutline))
                {
                    if (await (_service.Update(courseoutline)) == 0)
                    {
                        ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                        return View(_courseoutline);
                    } }
                _courseoutline = await _service.FindCourseOutline(courseoutline.CourseOutlineID);

                return View(_courseoutline);
            }
            ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(_courseoutline);
        }
        public async Task<IActionResult> ActionCourseOutline(int outlineid, int courseid)
        {
            if (await (_service.ActionCourseOutline(outlineid, DatabaseAction.Remove)) == 0)
            {
                ViewData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewCourseOutline", new { id = outlineid });
            }
            return RedirectToAction("ViewCourse", new { id = courseid });
        }
        public void PopulateDropDownList()
        {
            int courseID = Convert.ToInt32(HttpContext.Session.GetString("CourseID"));
            var courseOutlines = _service.GetCourseOutlines(courseID);
            var viewModel = new List<CheckBoxListItem>();
            foreach (var session in courseOutlines)
            {
                viewModel.Add(new CheckBoxListItem
                {
                    ID = session.CourseOutlineID,
                    Name = session.Name,
                    IsChecked =false
                });
            }
            ViewBag.SessionsList = viewModel;
            
        
        }
    }
}