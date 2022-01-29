using Microsoft.AspNetCore.Mvc.Filters;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartSave
{
    public class OverrideMenuComponentFilter : ActionFilterAttribute
    {
            public override void OnActionExecuting(ActionExecutingContext filterContext) => UtilityService.MenuComponent = Menu_Component.MenuList;
    }

    public class OverrideUserNotFoundFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext) => UtilityService.CanOverrideUserNotFound =true;
    }
}
