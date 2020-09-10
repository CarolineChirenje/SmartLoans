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
        Task<int> ActionRole( int roleID, DatabaseAction action);
        Task<int> ActionPermission(int permissionID, int roleID, DatabaseAction action);
        Task<Role> GetRole(int roleID);
        Task<List<RolePermission>> GetRolePermissions(int roleID);
        Task<Role> GetRole(string name);
        Task<Role> FindRole(int roleID = 0, string username = null);
        Task<List<Role>> Roles();
        List<Role> GetRoles();
      

    }
}
