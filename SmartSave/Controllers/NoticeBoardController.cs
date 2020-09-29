using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmartDomain;
using SmartHelper;

namespace SmartSave.Controllers
{
    public class NoticeBoardController : Controller
    {
        private readonly INoticeBoardService _service;
        private readonly ISettingService _settingService;
        public NoticeBoardController(INoticeBoardService service,ISettingService settingService)
        {
            _service = service;
            _settingService = settingService;
        }

        public async Task<IActionResult> NoticeBoard() => View(await _service.Notices());
        public async Task<IActionResult> ActiveNotices()
        {
           List<NoticeBoard> ActiveNotices = await _service.ActiveNotices();
            ViewBag.Notices = ActiveNotices;

            return View(ActiveNotices);
        }

        public IActionResult AddNotice()
        {
            GetDropDownLists();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddNotice(NoticeBoard NoticeBoard)
        {
            GetDropDownLists();
            if (ModelState.IsValid)
            {
                if (await (_service.Save(NoticeBoard)) == 0)
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction(nameof(NoticeBoard));
            }
          
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(NoticeBoard);
        }
        // GET:
        public async Task<IActionResult> ViewNotice(int id = 0)
        {
            GetDropDownLists();
            if (id == 0)
                return RedirectToAction(nameof(NoticeBoard));
            
            return View(await _service.FindNotice(id));
        }

        [HttpPost]
        public async Task<IActionResult> ViewNotice(NoticeBoard NoticeBoard)
        {
            GetDropDownLists();
            if (ModelState.IsValid)
            {
                NoticeBoard update = await (_service.FindNotice(NoticeBoard.NoticeID));
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(NoticeBoard)) == 0)
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return RedirectToAction(nameof(NoticeBoard));
                }
                return RedirectToAction(nameof(NoticeBoard));
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction(nameof(NoticeBoard));
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.Delete(id)) > 0)
                return RedirectToAction(nameof(NoticeBoard));
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewNotice", new { id });
            }
        }
        public async Task<IActionResult> ChangeNoticeBoardstatus(int id, bool status)
        {
            if (await (_service.ActionNoticeBoard(id, status ? DatabaseAction.Deactivate : DatabaseAction.Reactivate)) == 0)
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewNotice", new { id });
        }
        private void GetDropDownLists()
        {
            var priorityRanks = _settingService.GetPriorityRanks().Select(t => new
            {
                t.PriorityRankID,
                t.Name,
            }).OrderBy(t => t.Name);

            ViewBag.PriorityList = new SelectList(priorityRanks, "PriorityRankID", "Name");
           
            return ;
        }

    }
}