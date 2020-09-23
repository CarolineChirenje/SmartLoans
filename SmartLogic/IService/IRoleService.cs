using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogic
{
    public interface IRoleService
    {
        int PermissionsCount(Role role);
        string RoleName(Role role);
        Task<int> Delete(int id);
        Task<int> Save(Role role);
               Task<int> Update(Role role);
        Task<int> ActionRole(int roleID, DatabaseAction action);
        Task<Role> GetRole(int roleID);

        Task<int> UpdatePermissions(int roleID, string[] selectedPermissions);
               Task<int> ActionPermission(int permissionID, int roleID, DatabaseAction action);
              Task<List<RolePermission>> GetRolePermissions(int roleID);

        Task<int> UpdateMenus(int roleID, string[] selectedMenus);
        List<Menu> GetAllMenus();
        Task<int> DeleteMenuFromRole(int roleID, int menuid);
       List<RoleMenu> GetRoleMenus(int roleID);

        Task<Role> GetRole(string name);
        Task<Role> FindRole(int roleID = 0, string username = null);
        Task<List<Role>> Roles();
        List<Role> GetRoles();
        List<Permission> GetPermissionsForRole(int roleID);
        List<Permission> GetAllPermissions();
        Task<Permission> FindPermission(int id);
        List<User> GetActiveUsersNotInRole(int roleID);
        Task<int> Save(UserRole user);
        Task<int> DeleteUserFromRole(int userid, int roleid);


    }
}
