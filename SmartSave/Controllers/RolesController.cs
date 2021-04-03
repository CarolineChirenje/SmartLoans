using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartLogic;

using Microsoft.AspNetCore.Mvc;
using SmartHelper;
using SmartDomain;
using SmartSave.Models;
using Microsoft.AspNetCore.Http;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        
        public IActionResult Add()
        {
            PopulateDropDownLists();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(Role role)
        {
            if (ModelState.IsValid)
            {
                if (await (_service.Save(role)) == 0)
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR"); ;
                return RedirectToAction(nameof(Roles));
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction(nameof(Roles));
        }
        // GET:
        public async Task<IActionResult> ViewRole(int id = 0, string rolename = null)
        {
            if (id == 0 && rolename == null)
                return RedirectToAction(nameof(Roles));

            Role role = await _service.FindRole(id, rolename);
            HttpContext.Session.SetString("RoleID", role.RoleID.ToString());

            PopulateDropDownLists();
            return View(role);
        }

        [HttpPost]
        public async Task<IActionResult> ViewRole(Role role)
        {
            PopulateDropDownLists();
            if (ModelState.IsValid)
            {
                Role update = await (_service.GetRole(role.RoleID));
                if (UtilityService.IsNotNull(update))
                {
                    if (await (_service.Update(role)) == 0)
                    {
                        TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                        return View(role);
                    }
                    //     return RedirectToAction(nameof(Roles));
                }
                return View(role);
            }
            TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return View(role);
        }

        // GET: User/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            if (await (_service.Delete(id)) > 0)
                return RedirectToAction(nameof(Roles));
            else
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                return RedirectToAction("ViewRole", new { id });
            }

        }
        public async Task<IActionResult> ChangeRoleStatus(int id, bool status)
        {
            if (await (_service.ActionRole(id, status ? DatabaseAction.Deactivate : DatabaseAction.Reactivate)) == 0)
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");

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

        public async Task<IActionResult> RemovePermission(int id, int roleID)
        {
            if (await (_service.ActionPermission(id, roleID, DatabaseAction.Remove)) == 0)

                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewRole", new {id= roleID });

        }
        public async Task<IActionResult> ViewPermission(int id)
        {
            int roleID = Convert.ToInt32(HttpContext.Session.GetString("RoleID"));
            if (id == 0)
                return RedirectToAction("ViewRole", new {id= roleID });

            Permission permission = await _service.FindPermission(id);
            if (UtilityService.IsNull(permission))
                return RedirectToAction("ViewRole", new {id= roleID });
            return View(permission);
        }
        [HttpPost]
        public async Task<IActionResult> AddUserToRole(UserRole user)
        {
            Role update = await (_service.GetRole(user.RoleID));
            if (UtilityService.IsNull(update))
                return RedirectToAction(nameof(Roles));
            if (await _service.Save(user) == 0)
            {
                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            }

            return RedirectToAction("ViewRole", new {id= user.RoleID });
        }


        public async Task<IActionResult> RemoveUserFromRole(int UserID, int roleID)
        {
            if (await (_service.DeleteUserFromRole(UserID,roleID)) == 0)

                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewRole", new {id= roleID });

        }

        [HttpPost]
        public async Task<IActionResult> AddPermission(string[] selectedPermissions, Role role)
        {
            Role update = await (_service.GetRole(role.RoleID));
            if (UtilityService.IsNotNull(update))
            {
                if (await (_service.UpdatePermissions(role.RoleID, selectedPermissions)) == 0)
                {
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return View(role);
                }

            }
            return RedirectToAction("ViewRole", new {id= role.RoleID });

        }

        [HttpPost]
        public async Task<IActionResult> AddMenu(string[] selectedMenus, Role role)
        {
            Role update = await (_service.GetRole(role.RoleID));
            if (UtilityService.IsNotNull(update))
            {
                if (await (_service.UpdateMenus(role.RoleID, selectedMenus)) == 0)
                {
                    TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
                    return View(role);
                }

            }
            return RedirectToAction("ViewRole", new {id= role.RoleID });

        }

        public async Task<IActionResult> RemoveMenuFromRole(int roleID, int menuid)
        {
            if (await (_service.DeleteMenuFromRole(roleID,menuid)) == 0)

                TempData[MessageDisplayType.Error.ToString()] = UtilityService.GetMessageToDisplay("GENERICERROR");
            return RedirectToAction("ViewRole", new {id= roleID });

        }
        private void PopulateDropDownLists()
        {

            int roleID = Convert.ToInt32(HttpContext.Session.GetString("RoleID"));
            var allPermissions = _service.GetAllPermissions().OrderBy(r => r.Name);
            var rolePermissions = new HashSet<int>(_service.GetPermissionsForRole(roleID)?.Select(p => p.PermissionID));
            var viewModel = new List<CheckBoxListItem>();
            foreach (var permission in allPermissions)
            {
                viewModel.Add(new CheckBoxListItem
                {
                    ID = permission.PermissionID,
                    Name = permission.Name,
                    IsChecked = rolePermissions.Contains(permission.PermissionID)
                });
            }
            ViewBag.PermissionsList = viewModel;



            var allMenus = _service.GetAllMenus().OrderBy(r => r.DisplayName);
            var roleMenus = new HashSet<int>(_service.GetRoleMenus(roleID)?.Select(m => m.MenuID));
            var menuModel = new List<CheckBoxListItem>();
            foreach (var menu in allMenus)
            {
                menuModel.Add(new CheckBoxListItem
                {
                    ID = menu.MenuID,
                    Name = menu.DisplayName,
                    IsChecked = roleMenus.Contains(menu.MenuID)
                });
            }
            ViewBag.MenuList = menuModel;


            var activeUsers = _service.GetActiveUsersNotInRole(roleID).Select(t => new
            {
                t.UserID,
                Name = t.UserFullName,
            }).OrderBy(t => t.Name);
            ViewBag.Users = new SelectList(activeUsers, "UserID", "Name");

            var activeRoles = _service.GetRoles().Select(t => new
            {
                t.RoleID,
                Name = t.Name,
            }).OrderBy(t => t.Name);
            ViewBag.RoleList = new SelectList(activeRoles, "RoleID", "Name");
        }

    }
}