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
    public class MenusController : BaseController<MenusController>
    {
        private readonly IMenuService _service;
        public MenusController(IMenuService service) => _service = service;
        // Parent Menu
        public async Task<IActionResult> MainMenu()
        {
            Permissions permission = Permissions.View_Menu;
            if (!UtilityService.HasPermission(permission))
                return RedirectToAction("UnAuthorizedAccess", "Home", new { name = permission.ToString().Replace("_", " ") });

            return View(await _service.MenuGroups());
        }

        public IActionResult MenuGroup()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> MenuGroup(MenuGroup MenuGroup)
        {
            if (ModelState.IsValid)
            {
                if (await (_service.Save(MenuGroup)) == 0)
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR"); ;
                return RedirectToAction(nameof(MainMenu));
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction(nameof(MainMenu));
        }
    
        [HttpGet]
        public async Task<IActionResult> ViewMenuGroup(int id)
        {
            return View(await _service.FindMenuGroup(id));
        }

        [HttpPost]
        public async Task<IActionResult> ViewMenuGroup(MenuGroup MenuGroup)
        {
            if (ModelState.IsValid)
            {
                if (await (_service.Update(MenuGroup)) == 0)
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                else
                    return View(MenuGroup);
            }
            else
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return  View(MenuGroup);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.DeleteMenuGroup(id)) > 0)
                return RedirectToAction(nameof(MainMenu));
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewMenuGroup", new { id });
            }

        }
        public async Task<IActionResult> MenuGroupStatus(int id, bool status)
        {
            if (await (_service.ActionMenuGroup(id, status ? DatabaseAction.Deactivate : DatabaseAction.Reactivate)) == 0)
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewMenuGroup", new { id });
        }
        public async Task<IActionResult> ChildMenus(int id)
        {
            MenuGroup MenuGroup = await (_service.FindMenuGroup(id));
            if (UtilityService.IsNotNull(MenuGroup))
            {
                ViewBag.MenuGroupName = MenuGroup.DisplayName;
                ViewBag.MenuGroupID = id;
                List<Menu> menu = await (_service.GetMenusFromParent(id));
                return View(menu);

            }
            return RedirectToAction("ViewMenuGroup", new { id });
        }
        /// Menu
        /// 

        [HttpGet]
        public async Task<IActionResult> ViewMenu(int id)
        {
            return View(await _service.FindMenu(id));
        }

        [HttpPost]
        public async Task<IActionResult> ViewMenu(Menu menu)
        {
         
            if (ModelState.IsValid)
            {
                Menu update = await (_service.FindMenu(menu.MenuID));
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(menu)) == 0)
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                   
                }
                return RedirectToAction("ViewMenu", new { id = menu.MenuID });
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewMenu", new { id = menu.MenuID });
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
        private IList<MenuGroup> GetMenuGroups()
        {
            IList<MenuGroup> menuGroups = _service.GetMenuGroups();
            return menuGroups;
        }

    }

}
