using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using SmartHelper;
using SmartLog;

namespace SmartSave.Controllers
{
    // Custom Base controller.
    public abstract class BaseController<T> : Controller where T : BaseController<T>
    {
        private ILogger<T> _logger;
        protected ILogger<T> Logger => _logger ?? (_logger = HttpContext?.RequestServices.GetService<ILogger<T>>());
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                var maintananceMode = GetData.MaintananceMode();
                var licenceMode = GetData.LicenceMode();
                if (UtilityService.IsNotNull(maintananceMode) && !UtilityService.CanOverrideMaintananceMode)
                {
                    filterContext.Result = new RedirectToRouteResult(
                        new RouteValueDictionary {
                                { "Controller", "Maintanance" },
                                { "Action", "MaintananceMode" }
                                    });
                }
                else if (UtilityService.IsNotNull(licenceMode) && !UtilityService.CanOverrideMaintananceMode)
                {
                    filterContext.Result = new RedirectToRouteResult(
                            new RouteValueDictionary {
                                { "Controller", "Licence" },
                                { "Action", "LicenceMode" }
                             });
                }
                else
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

                var actionDescriptor = ((Microsoft.AspNetCore.Mvc.Controllers.ControllerActionDescriptor)filterContext.ActionDescriptor);
                string controllerName = actionDescriptor.ControllerName;
                string ActionName = actionDescriptor.ActionName;
                var attributes = actionDescriptor.EndpointMetadata.OfType<OverrideMenuComponentFilter>();
                if (attributes.Any())
                    UtilityService.MenuComponent = Menu_Component.MenuList;
                else
                    UtilityService.MenuComponent = GetMenuComponent(controllerName);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Base_Controller, ex);
            }
        }
        private Menu_Component GetMenuComponent(string executingController)
        {
            Menu_Component component = Menu_Component.MenuList;
            switch (executingController)
            {
                case "Client":
                    component = Menu_Component.ClientMenuList;
                    break;
                case "KonapoFund":
                case "Fund":
                case "FundItem":
                    component = Menu_Component.KhonapoMenuList;
                    break;
                default:
                    component = Menu_Component.MenuList;
                    break;
            }
            return component;

        }
    }
}
