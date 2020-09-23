using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SmartLogic
{
    public interface IUserService
    {
        Task<int> Delete(int id);

        Task<int> ActionUserRole(int id ,int userid,DatabaseAction action);
        Task<int> Save(User user, bool generateUserName=true);
        bool UserExists(string emailAddress);
        public string GetCredential(int id);
        Task<int> Update(User user);
        Task<int> SaveUserRoles(int useId, List<string> roles);
        //Task<User> GetUser(int id);
        Task<User> FindUser(int id = 0, string username = null);
        Task<List<User>> Users();
        List<Role> GetUserRoles(int id, string username = null);
        List<Role> GetAllRoles();
        List<UserType> GetUserTypes();
        bool HasPermission(Permissions permission);
        Task<int> UpdateRoles(int userID, string[] selectedRoles);
    }
}
