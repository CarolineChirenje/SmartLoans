using SmartLogic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartDomain;
using SmartDataAccess;
using SmartHelper;
using SmartLog;

namespace SmartLogic
{
    public class RoleService : IRoleService
    {
        private readonly DatabaseContext _context;
        public RoleService(DatabaseContext context)
        {
            _context = context;

        }
        public int PermissionsCount(Role role)
        {
            try
            {

                return role.RolePermissions.Count();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public string RoleName(Role role)
        {
            try
            {
                return role.Name;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<Role> FindRole(int roleID = 0, string name = null)
        {
            try
            {
                if (!String.IsNullOrEmpty(name))
                    roleID = _context
                    .Roles
                    .FirstOrDefault(u => u.Name.ToUpper() == name.Trim().ToUpper())?.RoleID ?? 0;
                return await GetRole(roleID);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<Role> GetRole(int roleID = 0)
        {
            try
            {
                Task<Role> role = _context
         .Roles
         .Where(r => r.RoleID == roleID)
         .Include(rp => rp.RolePermissions)
         .ThenInclude(perm => perm.Permission)
         .Include(u => u.UserRoles)
          .ThenInclude(usr => usr.User)
          .Include(m => m.RoleMenus)
          .ThenInclude(m => m.Menu)
          .ThenInclude(m => m.MenuGroup)
         //  .AsNoTracking()
         .FirstOrDefaultAsync();

                return await role;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<Role> GetRole(string name)
        {
            try
            {
                return await _context
     .Roles
     .Where(r => r.Name.ToUpper() == name.Trim().ToUpper())
     .Include(rp => rp.RolePermissions)
     .ThenInclude(perm => perm.Permission)
     .Include(u => u.UserRoles)
     .AsNoTracking()
     .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public async Task<List<Role>> Roles()
        {
            try
            {
               return await _context
    .Roles
    .Include(roles => roles.RolePermissions)
    .ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<List<RolePermission>> GetRolePermissions(int roleID)
        {
            try
            {
                string[] roles = _context.Roles.Where(
           r => r.RoleID == roleID && r.IsActive).Select(r => r.RoleID.ToString()).ToArray();
                return await _context.RolePermissions
                .Include(perm => perm.Permission)
                .Include(p => p.Roles)
                .Where(r => roles.Contains(r.RoleID.ToString()))
                .AsNoTracking()
                .ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<Permission> GetAllPermissions()
        {
            try
            {
                return _context.Permissions
    .ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<Menu> GetAllMenus()
        {
            try
            {
                return _context.Menus
     .ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<Permission> FindPermission(int id)
        {
            try
            {
                return await _context.Permissions.Where(p => p.PermissionID == id).
    Include(p => p.RolePermissions).ThenInclude(p => p.Roles).FirstOrDefaultAsync();

            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public List<Permission> GetPermissionsForRole(int roleID)
        {
            try
            {
                IEnumerable<int> rolePermissions = RolePermissions(roleID);
                return _context.Permissions.Where(r => rolePermissions.Contains(r.PermissionID))
                .ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<Role> GetRoles()
        {
            try
            {
                return _context.Roles
                .AsNoTracking()
                .ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        IEnumerable<int> RolePermissions(int roleID)
        {
            try
            {
                return from c in _context.RolePermissions
                       where c.RoleID == roleID
                       select c.PermissionID;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public async Task<int> Update(Role role)
        {
            try
            {

                Role update = _context.Roles.Find(role.RoleID);
                update.Name = role.Name;
                update.Description = role.Description;
                update.IsActive = role.IsActive;
                update.LastChangedBy = UtilityService.CurrentUserName;
                update.LastChangedDate = DateTime.Now;
                _context.Update(update);
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(Role role)
        {
            try
            {

                int result = 0;
                role.LastChangedBy = UtilityService.CurrentUserName;
                role.LastChangedDate = DateTime.Now;
                _context.Add(role);
                result = await _context.SaveChangesAsync();
                if (result > 0 && role.DuplicateRoleID > 0)
                {
                    List<int> role_Permission = RolePermissions(role.DuplicateRoleID).ToList();
                    result = await AddPermissions(role.RoleID, role_Permission);
                    if (result > 0)
                    {
                        List<int> role_menus = RoleMenus(role.DuplicateRoleID).ToList();
                        result = await AddMenus(role.RoleID, role_menus);
                    }


                }
                return result;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Delete(int id)
        {
            try
            {

                var role = await _context.Roles.FindAsync(id);
                _context.Roles.Remove(role);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<RolePermission> GetRolePermission(int permissionID, int roleID)
        {
            try
            {

                return await _context
    .RolePermissions
    .Where(rp => rp.RoleID == roleID && rp.PermissionID == permissionID)
    .FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> ActionPermission(int permissionID, int roleID, DatabaseAction action)
        {
            try
            {

                RolePermission permission = await GetRolePermission(permissionID, roleID);

                if (DatabaseAction.Remove == action)
                    _context.RolePermissions.Remove(permission);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    permission.LastChangedBy = UtilityService.CurrentUserName;
                    permission.LastChangedDate = DateTime.Now;
                    _context.Update(permission);
                }

                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> ActionRole(int roleID, DatabaseAction action)
        {
            try
            {

                Role roles = await GetRole(roleID);

                if (DatabaseAction.Remove == action)
                    _context.Roles.Remove(roles);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {
                    roles.IsActive = DatabaseAction.Deactivate == action ? false : true;
                    roles.LastChangedBy = UtilityService.CurrentUserName;
                    roles.LastChangedDate = DateTime.Now;
                    _context.Update(roles);
                }

                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> UpdatePermissions(int roleID, string[] selectedPermissions)
        {
            int result = 0;
            try
            {
                List<int> old_Permissions = RolePermissions(roleID).ToList();
                List<int> add_Permissions = new List<int>();
                List<int> remove_Permissions = new List<int>();
                int[] updated_Details = selectedPermissions == null ? null : Array.ConvertAll(selectedPermissions, s => int.Parse(s));


                if (old_Permissions == null && old_Permissions.Count == 0)
                {
                    add_Permissions = updated_Details.ToList();
                    return await AddPermissions(roleID, add_Permissions);
                }
                foreach (var permission in _context.Permissions)
                {
                    if (selectedPermissions.Contains(permission.PermissionID.ToString()))
                    {
                        if (!old_Permissions.Contains(permission.PermissionID))
                        {
                            add_Permissions.Add(permission.PermissionID);
                        }
                    }
                    else
                    {
                        if (old_Permissions.Contains(permission.PermissionID))
                        {
                            remove_Permissions.Add(permission.PermissionID);
                        }
                    }
                }
                int _addResult = await AddPermissions(roleID, add_Permissions);
                int _removeResult = await RemovePermissionsFromRole(roleID, remove_Permissions);
                result = _addResult + _removeResult;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                return 0;
            }
            return result;
        }
        public async Task<int> AddPermissions(int roleID, List<int> permissions)
        {
            try
            {

                foreach (int permissionid in permissions)
                {
                    RolePermission rolePermissions = new RolePermission
                    {
                        PermissionID = permissionid,
                        RoleID = roleID,
                        LastChangedBy = UtilityService.CurrentUserName,
                        LastChangedDate = DateTime.Now
                    };
                    _context.Add(rolePermissions);

                }
                return await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public async Task<int> RemovePermissionsFromRole(int roleID, List<int> permissions)
        {
            try
            {
                List<RolePermission> rolePermissions = await _context.RolePermissions.Where(r => r.RoleID == roleID).ToListAsync();
                var rolePermissionsToBeRemoved = rolePermissions
                        .Where(x => permissions.Any(y => y == x.PermissionID));
                _context.RolePermissions.RemoveRange(rolePermissionsToBeRemoved);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<User> GetActiveUsersNotInRole(int roleID)
        {
            try
            {
                IEnumerable<int> userList = from c in _context.UserRoles
                                            where c.RoleID == roleID
                                            select c.UserID;
                List<User> usersToBeAdded = _context.Users.Where(u => !userList.Contains(u.UserID) && u.IsActive).ToList();
                return usersToBeAdded;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> Save(UserRole user)
        {
            try
            {
                user.LastChangedBy = UtilityService.CurrentUserName;
                user.LastChangedDate = DateTime.Now;
                _context.Add(user);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> DeleteUserFromRole(int userid, int roleid)
        {
            try
            {

                var _userRole = await _context.UserRoles.Where(r => r.RoleID == roleid && r.UserID == userid).FirstOrDefaultAsync();
                _context.UserRoles.Remove(_userRole);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> UpdateMenus(int roleID, string[] selectedMenus)
        {
            int result = 0;
            try
            {
                List<int> old_Menus = RoleMenus(roleID).ToList();
                List<int> add_Menus = new List<int>();
                List<int> remove_Menus = new List<int>();
                int[] updated_Details = selectedMenus == null ? null : Array.ConvertAll(selectedMenus, s => int.Parse(s));


                if (old_Menus == null && old_Menus.Count == 0)
                {
                    add_Menus = updated_Details.ToList();
                    return await AddMenus(roleID, add_Menus);
                }
                foreach (var menu in _context.Menus)
                {
                    if (selectedMenus.Contains(menu.MenuID.ToString()))
                    {
                        if (!old_Menus.Contains(menu.MenuID))
                        {
                            add_Menus.Add(menu.MenuID);
                        }
                    }
                    else
                    {
                        if (old_Menus.Contains(menu.MenuID))
                        {
                            remove_Menus.Add(menu.MenuID);
                        }
                    }
                }
                int _addResult = await AddMenus(roleID, add_Menus);
                int _removeResult = await RemoveMenusFromRole(roleID, remove_Menus);
                result = _addResult + _removeResult;
            }
            catch (Exception ex)
            {
                return 0;
            }
            return result;
        }

        public async Task<int> AddMenus(int roleID, List<int> menus)
        {
            try
            {

                foreach (int menuid in menus)
                {
                    RoleMenu roleMenu = new RoleMenu
                    {
                        MenuID = menuid,
                        RoleID = roleID,
                        LastChangedBy = UtilityService.CurrentUserName,
                        LastChangedDate = DateTime.Now
                    };
                    _context.Add(roleMenu);

                }
                return await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public async Task<int> RemoveMenusFromRole(int roleID, List<int> menus)
        {
            try
            {
                List<RoleMenu> roleMenus = await _context.RoleMenus.Where(r => r.RoleID == roleID).ToListAsync();
                var roleMenusToBeRemoved = roleMenus
                        .Where(x => menus.Any(y => y == x.MenuID));
                _context.RoleMenus.RemoveRange(roleMenusToBeRemoved);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        IEnumerable<int> RoleMenus(int roleID)
        {
            try
            {
                return from c in _context.RoleMenus
                       where c.RoleID == roleID
                       select c.MenuID;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<RoleMenu> GetRoleMenus(int roleID)
        {
            try
            {
                return _context.RoleMenus.Where(m => m.RoleID == roleID).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> DeleteMenuFromRole(int roleID, int menuid)
        {
            try
            {

                var _menuRole = await _context.RoleMenus.Where(r => r.RoleID == roleID && r.MenuID == menuid).FirstOrDefaultAsync();
                _context.RoleMenus.Remove(_menuRole);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

    }
}
