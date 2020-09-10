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
            return role.RolePermissions.Count();
        }

        public string RoleName(Role role)
        {
            return role.Name;
        }
        public async Task<Role> FindRole(int roleID = 0, string name = null)
        {
            if (!String.IsNullOrEmpty(name))
                roleID = _context
                .Roles
                .FirstOrDefault(u => u.Name.ToUpper() == name.Trim().ToUpper())?.RoleID ?? 0;
            return await GetRole(roleID);
        }
        public async Task<Role> GetRole(int roleID = 0)
        {
        
        Task<Role> role =     _context
            .Roles
            .Where(r => r.RoleID == roleID)
            .Include(rp => rp.RolePermissions)
            .ThenInclude(perm => perm.Permission)
            .Include(u => u.UserRoles)
             .ThenInclude(usr=>usr.User)
            //  .AsNoTracking()
            .FirstOrDefaultAsync();
           
            return await  role;
        }
        public async Task<Role> GetRole(string name)
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


        public async Task<List<Role>> Roles()
        {
            return await _context
            .Roles
            .Include(roles => roles.RolePermissions)
            .ToListAsync();
        }

        public async Task<List<RolePermission>> GetRolePermissions(int roleID)
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
        public List<Role> GetRoles()
        {
            return _context.Roles
            .AsNoTracking()
            .ToList();
        }


        public async Task<int> Update(Role role)
        {
            Role update = await FindRole(role.RoleID);
            update.Description = role.Description;
            update.IsActive = role.IsActive;
            update.LastChangedBy = UtilityService.CurrentUserName;
            update.LastChangedDate = DateTime.Now;
            _context.Update(role);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> Save(Role role)
        {
            role.LastChangedBy = UtilityService.CurrentUserName;
            role.LastChangedDate = DateTime.Now;
            _context.Add(role);
            return (await _context.SaveChangesAsync());
        }
        public async Task<int> Delete(int id)
        {
            var role = await _context.Roles.FindAsync(id);
            _context.Roles.Remove(role);
            return (await _context.SaveChangesAsync());
        }
        public async Task<RolePermission> GetRolePermission(int permissionID, int roleID)
        {
            return await _context
            .RolePermissions
            .Where(rp => rp.RoleID == roleID && rp.PermissionID == permissionID)
            .FirstOrDefaultAsync();
        }
        public async Task<int> ActionPermission(int permissionID, int roleID, DatabaseAction action)
        {
            RolePermission permission = await GetRolePermission(permissionID, roleID);

            if (DatabaseAction.Remove == action)
                _context.RolePermissions.Remove(permission);
            else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
            {
                permission.IsActive = DatabaseAction.Deactivate == action ? false : true;
                permission.LastChangedBy = UtilityService.CurrentUserName;
                permission.LastChangedDate = DateTime.Now;
                _context.Update(permission);
            }

            return (await _context.SaveChangesAsync());
        }

        public async Task<int> ActionRole(int roleID, DatabaseAction action)
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

    }
}
