﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using SmartHelper;

namespace SmartSave.Controllers
{
    // Custom Base controller.
    public abstract class BaseController<T> : Controller where T:BaseController<T>
    {
       private  ILogger<T> _logger;


        protected ILogger<T> Logger => _logger ?? (_logger = HttpContext?.RequestServices.GetService<ILogger<T>>());

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            
            if (UtilityService.IsNull(UtilityService.CurrentUserName))
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary {
                                { "Controller", "Login" },
                                { "Action", "UserNotFound" }
                                });
            }
        }
    }
}
