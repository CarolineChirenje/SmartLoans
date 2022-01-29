﻿using SmartLogic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSave
{
    
    [ViewComponent(Name = "MenuList")]
    public class MenuListViewComponent : ViewComponent
    {
        private readonly IMenuService _service;
        public MenuListViewComponent(IMenuService service) => _service = service;

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("MainMenu",await _service.DisplayMenuGroups());
        }
    }
    [ViewComponent(Name = "ClientMenuList")]
    public class ClientMenuListViewComponent : ViewComponent
    {
        private readonly IMenuService _service;
        public ClientMenuListViewComponent(IMenuService service) => _service = service;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("ClientMenu", await _service.DisplayLayouts(SmartHelper.LayoutComponent.Client));
        }
    }

    [ViewComponent(Name = "KhonapoMenuList")]
    public class KhonapoMenuListViewComponent : ViewComponent
    {
        private readonly IMenuService _service;
        public KhonapoMenuListViewComponent(IMenuService service) => _service = service;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("KhonapoMenu", await _service.DisplayLayouts(SmartHelper.LayoutComponent.Khonapo_Fund));
        }
    }

    [ViewComponent(Name = "DeveloperMenuList")]
    public class DeveloperMenuListViewComponent : ViewComponent
    {
        private readonly IMenuService _service;
        public DeveloperMenuListViewComponent(IMenuService service) => _service = service;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("DeveloperMenu", await _service.DisplayLayouts(SmartHelper.LayoutComponent.Developer_Menu));
        }
    }

    [ViewComponent(Name = "SettingsMenuList")]
    public class SettingsMenuListViewComponent : ViewComponent
    {
        private readonly IMenuService _service;
        public SettingsMenuListViewComponent(IMenuService service) => _service = service;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("SettingsMenu", await _service.DisplayLayouts(SmartHelper.LayoutComponent.Settings));
        }
    }
    [ViewComponent(Name = "ReportingMenuList")]
    public class ReportingListViewComponent : ViewComponent
    {
        private readonly IMenuService _service;
        public ReportingListViewComponent(IMenuService service) => _service = service;
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View("ReportingMenu", await _service.DisplayLayouts(SmartHelper.LayoutComponent.Reporting));
        }
    }

    public class NoMenuListViewComponent : ViewComponent
    {
        //private readonly IMenuService _service;
        //public NoMenuListViewComponent(IMenuService service) => _service = service;
        public  IViewComponentResult Invoke()
        {
            return View("BlankMenu");
        }
    }

}
