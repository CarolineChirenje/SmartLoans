using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLogic;

using Microsoft.AspNetCore.Mvc;
using SmartHelper;
using SmartDomain;

namespace SmartSave.Controllers
{
    public class RolesController : Controller
    {
        private readonly IRoleService _service;
        public RolesController(IRoleService service) => _service = service;
        // GET: User
        public async Task<IActionResult> Roles()
        {
            return View(await _service.Roles());
        }
        //public async Task<IActionResult> Roles(int RoleID)
        //{
        //    Roles role = await (_service.GetRole(RoleID));
        //    if (UtilityService.IsNotNull(role))
        //    {
        //        ViewBag.UserName = role.Name;
        //        return View(role);
        //    }

        //    return RedirectToAction(nameof(Roles));
        //}

        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Role role)
        {
            if (ModelState.IsValid)
            {
                if (await (_service.Save(role)) == 0)
                    ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");;
                return RedirectToAction(nameof(Roles));
            }
            ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction(nameof(Roles));
        }
        // GET:
        public async Task<IActionResult> ViewRole(int id = 0, string rolename = null)
        {
            if (id == 0 && rolename == null)
                return RedirectToAction(nameof(Roles));
            return View(await _service.FindRole(id, rolename));
        }

        [HttpPost]
        public async Task<IActionResult> ViewRole(Role role)
        {
            if (ModelState.IsValid)
            {
                Role update = await (_service.GetRole(role.RoleID));
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(role)) == 0)
                    {
                         ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                        return View(role);
                   }
                   //     return RedirectToAction(nameof(Roles));
                }
                return View(role);
            }
            ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(role);
        }

        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.Delete(id)) > 0)
                return RedirectToAction(nameof(Roles));
            else
            {
                ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewRole", new { id });
            }

        }
        public async Task<IActionResult> ChangeRoleStatus(int id,  bool status)
        {
            if (await (_service.ActionRole(id, status ? DatabaseAction.Deactivate : DatabaseAction.Reactivate)) == 0)
                ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("ViewRole", new { id });
        }
        /// Permissions
        /// 
        public async Task<IActionResult> RolePermissions(int id)
        {
            List<RolePermission> rolePermission = await (_service.GetRolePermissions(id));

            if (UtilityService.IsNotNull(rolePermission))
            {
                ViewBag.RoleName = rolePermission.FirstOrDefault()?.Roles?.Name ?? "Uknown";
                ViewBag.RoleID = id;
                return View(rolePermission);
            }

            return RedirectToAction("ViewRole", new { id });
        }

        public async Task<IActionResult> RemovePermission(int id,  int roleID)
        {
            if (await (_service.ActionPermission(id, roleID, DatabaseAction.Remove))==0)
                    ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("RolePermissions", new { roleID }); ;
            

        }
        public async Task<IActionResult> ChangePermissionStatus(int id, int roleID, bool status)
        {
            if (await (_service.ActionPermission(id, roleID, status ? DatabaseAction.Deactivate : DatabaseAction.Reactivate)) == 0)
                ViewData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");

            return RedirectToAction("RolePermissions", new {id= roleID });
        }


    }
}