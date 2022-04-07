using SmartLogic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartDomain;
using SmartExtensions;

namespace SmartLoan
{

    [ViewComponent(Name = "MenuList")]
    public class MenuListViewComponent : ViewComponent
    {
        private readonly IMenuService _service;
        public MenuListViewComponent(IMenuService service) => _service = service;

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var menuGroups = AppData.MenuGroups;
            if (menuGroups.ListIsEmpty())
            {
                menuGroups = await _service.DisplayMenuGroups();
                AppData.MenuGroups = menuGroups;
            }
            return View("MainMenu", menuGroups);
        }
    }
    [ViewComponent(Name = "ClientMenuList")]
    public class ClientMenuListViewComponent : ViewComponent
    {
        private readonly IMenuService _service;
        public ClientMenuListViewComponent(IMenuService service) => _service = service;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var clientMenu = AppData.ClientMenu;
            if (clientMenu.ListIsEmpty())
            {
                clientMenu = await _service.DisplayLayouts(SmartHelper.LayoutComponent.Client);
                AppData.ClientMenu = clientMenu;
            }
            return View("ClientMenu", clientMenu);
        }
    }

    [ViewComponent(Name = "KhonapoMenuList")]
    public class KhonapoMenuListViewComponent : ViewComponent
    {
        private readonly IMenuService _service;
        public KhonapoMenuListViewComponent(IMenuService service) => _service = service;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var konapoMenu = AppData.KhonapoMenu;
            if (konapoMenu.ListIsEmpty())
            {
                konapoMenu = await _service.DisplayLayouts(SmartHelper.LayoutComponent.Khonapo_Fund);
                AppData.KhonapoMenu = konapoMenu;
            }
            return View("KhonapoMenu", konapoMenu);
        }
    }

    [ViewComponent(Name = "DeveloperMenuList")]
    public class DeveloperMenuListViewComponent : ViewComponent
    {
        private readonly IMenuService _service;
        public DeveloperMenuListViewComponent(IMenuService service) => _service = service;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var developerMenu = AppData.DeveloperMenu;
            if (developerMenu.ListIsEmpty())
            {
                developerMenu = await _service.DisplayLayouts(SmartHelper.LayoutComponent.Developer_Menu);
                AppData.DeveloperMenu = developerMenu;
            }
                return View("DeveloperMenu",developerMenu);
        }
    }

    [ViewComponent(Name = "SettingsMenuList")]
    public class SettingsMenuListViewComponent : ViewComponent
    {
        private readonly IMenuService _service;
        public SettingsMenuListViewComponent(IMenuService service) => _service = service;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var settingmenu = AppData.SettingsMenu;
            if (settingmenu.ListIsEmpty())
            {
                settingmenu = await _service.DisplayLayouts(SmartHelper.LayoutComponent.Settings);
                AppData.SettingsMenu = settingmenu;
            }
            return View("SettingsMenu", settingmenu);
        }
    }
    [ViewComponent(Name = "ReportingMenuList")]
    public class ReportingListViewComponent : ViewComponent
    {
        private readonly IMenuService _service;
        public ReportingListViewComponent(IMenuService service) => _service = service;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var reportMenu = AppData.ReportMenu;
            if (reportMenu.ListIsEmpty())
            {
                reportMenu = await _service.DisplayLayouts(SmartHelper.LayoutComponent.Reporting);
                AppData.ReportMenu = reportMenu;
            }
            return View("ReportingMenu", reportMenu);
        }
    }
    
      [ViewComponent(Name = "EmployeeMenuList")]
    public class EmployeeMenuListViewComponent : ViewComponent
    {
        private readonly IMenuService _service;
        public EmployeeMenuListViewComponent(IMenuService service) => _service = service;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var employeeMenu = AppData.EmployeeMenu;
            if (employeeMenu.ListIsEmpty())
            {
                employeeMenu = await _service.DisplayLayouts(SmartHelper.LayoutComponent.Employees);
                AppData.EmployeeMenu = employeeMenu;
            }
            return View("EmployeeMenu", employeeMenu);
        }
    }

    [ViewComponent(Name = "EmployerMenuList")]
    public class EmployerMenuListViewComponent : ViewComponent
    {
        private readonly IMenuService _service;
        public EmployerMenuListViewComponent(IMenuService service) => _service = service;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var employerMenu = AppData.EmployerMenu;
            if (employerMenu.ListIsEmpty())
            {
                employerMenu = await _service.DisplayLayouts(SmartHelper.LayoutComponent.Employers);
                AppData.EmployerMenu = employerMenu;
            }
            return View("EmployerMenu", employerMenu);
        }
    }
    [ViewComponent(Name = "NoMenuList")]
    public class NoMenuListViewComponent : ViewComponent
    {
        //private readonly IMenuService _service;
        //public NoMenuListViewComponent(IMenuService service) => _service = service;
        public IViewComponentResult Invoke()
        {
            return View("BlankMenu");
        }
    }

}
