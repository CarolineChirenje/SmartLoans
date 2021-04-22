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
using System.IO;
using SmartReporting;
using MigraDocCore.Rendering;
using MigraDocCore.DocumentObjectModel;
namespace SmartSave.Controllers
{
    public class CoursesController : BaseController<CoursesController>
    {
        private readonly ICourseService _service;
        private readonly ISettingService _settingService;

        public CoursesController(ICourseService service, ISettingService settingService)
        {
            _service = service;
            _settingService = settingService;
        }

        public async Task<IActionResult> Courses(bool newCoursesOnly = false)
        {
            if (newCoursesOnly)
                return View(await _service.NewCourses());

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
                if (await _service.IsDuplicate(Course))
                {
                    TempData[MessageDisplayType.Error.ToString()] = "Failed to Create Course a Course with the same Title Already Exists";
                    return View(Course);
                }
                if (await (_service.Save(Course)) == 0)
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction(nameof(Courses));
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
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
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(Courses));
                }
                return View(Course);
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(Course);
        }


        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.ActionCourse(id, DatabaseAction.Remove)) == 0)
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
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
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewCourse", new { id = courseOutline.CourseID });
                }

            }
            return RedirectToAction("ViewCourse", new { id = courseOutline.CourseID });
        }
        public async Task<IActionResult> ViewCourseOutline(int outlineid, int courseid)
        {
            if (outlineid == 0)
                return RedirectToAction("ViewCourse", new { id = courseid });

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
                        TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                        return View(_courseoutline);
                    }
                }
                _courseoutline = await _service.FindCourseOutline(courseoutline.CourseOutlineID);

                return View(_courseoutline);
            }
            TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(_courseoutline);
        }
        public async Task<IActionResult> ActionCourseOutline(int outlineid, int courseid)
        {
            if (await (_service.ActionCourseOutline(outlineid, DatabaseAction.Remove)) == 0)
            {
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewCourseOutline", new { id = outlineid });
            }
            return RedirectToAction("ViewCourse", new { id = courseid });
        }

        // CourseFees
        [HttpPost]
        public async Task<IActionResult> AddCourseFee(CourseFee courseFee)
        {
            Decimal _amount = UtilityService.GetDecimalAmount(courseFee.CostAmount);
            courseFee.Amount = _amount;
            if (ModelState.IsValid)
            {
                if (await (_service.Save(courseFee)) == 0)
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

            }
            return RedirectToAction("ViewCourse", new { id = courseFee.CourseID });
        }


        public async Task<IActionResult> ViewCourseFee(int id)
        {
            if (id == 0)
                return RedirectToAction("ViewCourse", new { id = Convert.ToInt32(HttpContext.Session.GetString("CourseID")) });

            PopulateDropDownList();
            CourseFee courseFee = await _service.FindCourseFee(id);
            if (UtilityService.IsNotNull(courseFee))
                return View(courseFee);
            else
                return RedirectToAction("ViewCourse", new { id = Convert.ToInt32(HttpContext.Session.GetString("CourseID")) });

        }

        [HttpPost]
        public async Task<IActionResult> ViewCourseFee(CourseFee courseFee)
        {
            PopulateDropDownList();
            CourseFee update = await _service.FindCourseFee(courseFee.CourseFeeID);
            if (UtilityService.IsNotNull(update))
            {
                if (await (_service.Update(courseFee)) == 0)
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewCourse", new { id = courseFee.CourseID });
            }
            return RedirectToAction("ViewCourse", new { id = courseFee.CourseID });

        }

        public async Task<IActionResult> ActionCourseFee(int courseFeeID, int courseID)
        {
            if (await (_service.ActionCourseFee(courseFeeID, DatabaseAction.Remove)) == 0)
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewCourse", new { id = courseID });
        }


        /// <summary>
        /// Course Intakes
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 
        [HttpPost]
        public async Task<IActionResult> AddCourseIntake(CourseIntake courseIntake)
        {
            if (ModelState.IsValid)
            {

                if (await (_service.Save(courseIntake)) == 0)
                {
                    TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction("ViewCourse", new { id = courseIntake.CourseID });
                }

            }
            return RedirectToAction("ViewCourse", new { id = courseIntake.CourseID });
        }
        public async Task<IActionResult> ViewCourseIntake(int intakeId, int courseid)
        {
            if (intakeId == 0)
                return RedirectToAction("ViewCourse", new { id = courseid });

            HttpContext.Session.SetString("CourseIntakeID", intakeId.ToString());
            PopulateDropDownList();

            return View(await _service.FindCourseIntake(intakeId));
        }
        [HttpPost]
        public async Task<IActionResult> ViewCourseIntake(CourseIntake courseIntake)
        {
            PopulateDropDownList();
            CourseIntake _courseIntake = await _service.FindCourseIntake(courseIntake.CourseIntakeID);
            if (ModelState.IsValid)
            {

                if (UtilityService.IsNotNull(_courseIntake))
                {
                    if (await (_service.Update(_courseIntake)) == 0)
                    {
                        TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                        return View(_courseIntake);
                    }
                }
                _courseIntake = await _service.FindCourseIntake(_courseIntake.CourseIntakeID);

                return View(_courseIntake);
            }
            TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(_courseIntake);
        }
        public async Task<IActionResult> ActionCourseIntake(int courseIntakeId, int courseid)
        {
            if (await (_service.ActionCourseIntake(courseIntakeId, DatabaseAction.Remove)) == 0)
            {
                TempData["Error"] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewCourseIntake", new { id = courseIntakeId });
            }
            return RedirectToAction("ViewCourse", new { id = courseid });
        }
        [HttpPost]
        public async Task<IActionResult> MarkRegister(string[] enrolmentList, CourseIntake intake)
        {
            bool registerExists = _service.RegisterExist(intake.CourseIntakeID, intake.AttendanceDate.ToString("yyyy-MMM-dd"));
            if (registerExists)
                TempData[MessageDisplayType.Error.ToString()] = "Register already exists! Cannot recreate register for the same day";
            else
            {
                CourseIntake update = await (_service.FindCourseIntake(intake.CourseIntakeID));
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.MarkRegister(intake, enrolmentList)) == 0)
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                }
            }
            return RedirectToAction("ViewCourseIntake", new { intakeId = intake.CourseIntakeID, courseid = intake.CourseID });
        }

        public ActionResult DownloadRegister(int id)
        {

            AttendanceRegister register = _service.FindRegister(id).Result;
            if (UtilityService.IsNull(register))
            {

                TempData[MessageDisplayType.Error.ToString()] = $"Failed to download attendance register";
                return RedirectToAction("ViewCourseIntake", new { intakeId = Convert.ToInt32(HttpContext.Session.GetString("CourseIntakeID")), courseid = Convert.ToInt32(HttpContext.Session.GetString("CourseID")) });
            }
            AttendanceRegisterPrintOut printOut = new AttendanceRegisterPrintOut();
            using (MemoryStream stream = new MemoryStream())
            {
                Document document = printOut.Print(register); ;
                PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer();
                pdfRenderer.Document = document;
                pdfRenderer.RenderDocument();
                pdfRenderer.PdfDocument.Save(stream, false);

                return File(stream.ToArray(), "application/pdf", $"Register_{register.AttendanceDate}.pdf");
            }

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
                    IsChecked = false
                });
            }
            ViewBag.SessionsList = viewModel;

            var frequency = _settingService.GetFrequencyList().Select(t => new
            {
                t.FrequencyID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.FrequencyList = new SelectList(frequency, "FrequencyID", "Name");
            var outlines = courseOutlines.Select(t => new
            {
                t.CourseOutlineID,
                t.Name,
            }).OrderBy(t => t.Name);
            ViewBag.CourseOutlineList = new SelectList(outlines, "CourseOutlineID", "Name");

            int intakeID = Convert.ToInt32(HttpContext.Session.GetString("CourseIntakeID"));
            var enrolmentList = _service.GetEnrollmentList(intakeID)?.OrderBy(r => r.ClientFullName);
            var enrolViewModel = new List<CheckBoxListItem>();
            foreach (var enrol in enrolmentList)
            {
                enrolViewModel.Add(new CheckBoxListItem
                {
                    ID = enrol.ClientID,
                    Name = enrol.ClientFullName,
                    IsChecked = false
                });
            }
            ViewBag.EnrolmentList = enrolViewModel;

        }
    }
}