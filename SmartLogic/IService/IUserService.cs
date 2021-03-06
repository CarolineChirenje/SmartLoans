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

        Task<int> ActionUserRole(int id, int userid, DatabaseAction action);
        Task<int> Save(User user, bool generateUserName = true);
        bool EmailExists(string emailAddress);
        public string GetCredential(int id);
        Task<int> Update(User user);
        Task<int> SaveUserRoles(int useId, List<string> roles);
        //Task<User> GetUser(int id);
        Task<User> FindUser(int id = 0, string username = null);
        BasicDetail GetUser(int id = 0, string username = null);
        Task<List<User>> Users();
        List<Role> GetUserRoles(int id, string username = null);
        List<Role> GetAllRoles();
        List<UserType> GetUserTypes();
        bool HasPermission(Permissions permission);
        
        Task<int> UpdateRoles(int userID, string[] selectedRoles);

        Task<bool> IsDuplicate(UserToDo userToDo);
        Task<UserToDo> FindToDo(int id);
        Task<List<UserToDo>> ToDoList(int userID);
        Task<int> DeleteToDo(int id);
        Task<int> Update(UserToDo userToDo);
        Task<int> Save(UserToDo userToDo);
    }
}
