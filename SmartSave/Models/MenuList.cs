using SmartLogic;
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
            return View("MainMenu",await _service.MenuGroups());
        }
    }
}
