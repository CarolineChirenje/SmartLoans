using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLogic;

using Microsoft.AspNetCore.Mvc;
using SmartDomain;
using SmartHelper;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartSave.Controllers
{
    public class LayoutsController : BaseController<LayoutsController>
    {
        private readonly IMenuService _service;
        public LayoutsController(IMenuService service) => _service = service;
        // Parent Menu
        public async Task<IActionResult> Layouts()
        {
            Permissions permission = Permissions.View_Layouts;
            if (!UtilityService.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

            return View(await _service.Layouts());
        }

        public IActionResult MenuGroup()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LayoutGroup(Layout layout)
        {
            if (ModelState.IsValid)
            {
                if (await (_service.Save(layout)) == 0)
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR"); ;
                return RedirectToAction(nameof(Layouts));
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction(nameof(Layouts));
        }
    
        [HttpGet]
        public async Task<IActionResult> ViewLayoutGroup(int id)
        {
            return View(await _service.FindLayoutGroup(id));
        }

       
        public async Task<IActionResult> ChildMenus(int id)
        {
            Layout layout = await (_service.FindLayoutGroup(id));
            if (UtilityService.IsNotNull(layout))
            {
                ViewBag.LayoutGroupName = layout.DisplayName;
                ViewBag.MenuGroupID = id;
                List<LayoutMenu> menu = await (_service.LayoutMenus(id));
                return View(menu);

            }
            return RedirectToAction("ViewLayoutGroup", new { id });
        }
        /// Menu
        /// 

        [HttpGet]
        public async Task<IActionResult> ViewMenu(int id)
        {
            return View(await _service.FindLayoutMenu(id));
        }

        [HttpPost]
        public async Task<IActionResult> ViewMenu(LayoutMenu menu)
        {
         
            if (ModelState.IsValid)
            {
                LayoutMenu update = await (_service.FindLayoutMenu(menu.LayoutMenuID));
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(menu)) == 0)
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                   
                }
                return RedirectToAction("ViewMenu", new { id = menu.LayoutMenuID });
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewMenu", new { id = menu.LayoutMenuID });
        }
        [HttpGet]
        public IActionResult AddMenu(int id)
        {
            ViewBag.MenuGroups = GetMenuGroups();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddMenu(Menu menu)
        {
            if (ModelState.IsValid)
            {
                if (await (_service.Save(menu)) == 0)
                {
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return View(menu);
                }
                return RedirectToAction("ChildMenus", new { menu.MenuGroupID });
            }
            ViewBag.MenuGroups = GetMenuGroups();
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(menu);
        }

        public async Task<IActionResult> RemoveMenu(int id, int MenuGroupID)
        {
            if (await (_service.ActionMenu(id, DatabaseAction.Remove)) == 0)
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ChildMenus", new { MenuGroupID }); ;
        }
        public async Task<IActionResult> ChangeMenuStatus(int id, int MenuGroupID, bool status)
        {
            if (await (_service.ActionMenu(id, status ? DatabaseAction.Deactivate : DatabaseAction.Reactivate)) == 0)
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewMenu", new { id });
        }
        private IList<Layout> GetMenuGroups()
        {
            IList<Layout> menuGroups = _service.GetLayoutGroups();
            return menuGroups;
        }

    }

}
