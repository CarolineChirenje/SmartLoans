using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartDataAccess;
using SmartDomain;
using SmartHelper;
using SmartLog;
using SmartExtensions;

namespace SmartLogic
{
    public class UserService : IUserService
    {
        private DatabaseContext _context;

        public object Encrypt { get; private set; }

        public UserService(DatabaseContext context) => _context = context;

        public UserService()
        {
        }
        public List<UserType> GetUserTypes()
        {
            try
            {
                return _context.UserTypes.Where(t => t.IsActive).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<User> FindUser(int id = 0, string username = null)
        {
            try
            {

                if (!String.IsNullOrEmpty(username))
                    id = _context.Users.FirstOrDefault(u => u.EmailAddress.ToUpper() == username.Trim().ToUpper())?.UserID ?? 0;
                return await _context.Users.Include(p => p.UserRoles)
                             .ThenInclude(r => r.Roles)
                             .ThenInclude(r => r.RolePermissions)
                             .Include(ut => ut.UserType).
                    Where(r => r.UserID == id).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public BasicDetail GetUser(int id = 0, string username = null)
        {
            try
            {
                User user = new User();
                if (id > 0)
                    user = _context.Users.Find(id);
                else if (!String.IsNullOrEmpty(username))
                    user = _context.Users.FirstOrDefault(u => u.EmailAddress.ToUpper() == username.Trim().ToUpper());
                if (user.IsNotNull())
                {
                    BasicDetail result = new BasicDetail()
                    {
                        IDNumber = user.IDNumber,
                        EmailAddress = user.EmailAddress
                    };
                    return result;

                }
                else
                    return null;

            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public List<Role> GetUserRoles(int id = 0, string username = null)
        {
            try
            {

                if (!_context.IsNotNull())
                {
                    return null;
                }
                if (!String.IsNullOrEmpty(username))
                {
                    var user = _context.Users.Where(u => u.EmailAddress.ToUpper() == username.Trim().ToUpper()).FirstOrDefault();
                    if (!user.IsNotNull())
                        return null;
                    id = user.UserID;
                }
                string[] roles = _context.UserRoles.Where(
             userRole => userRole.UserID == id).Select(r => r.RoleID.ToString()).ToArray();

                return _context
                .Roles
                .Include(p => p.RolePermissions)
                .Include(usr => usr.UserRoles)
                .Where(r => roles.Contains(r.RoleID.ToString()))
                .ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<List<User>> Users()
        {
            try
            {
                return await _context.Users.
                     Include(usr => usr.UserRoles).
                     Include(ut => ut.UserType).ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Update(User user)
        {

            try
            {

                User updateUser = await FindUser(user.UserID);
                string oldIDNumber = updateUser.IDNumber;
                string oldEmailAddress = updateUser.EmailAddress;
                updateUser.ProfileImage = user.ProfileImage;
                updateUser.FirstName = user.FirstName;
                updateUser.LastName = user.LastName;
                updateUser.IsActive = user.IsActive;
                updateUser.UserTypeID = user.UserTypeID;
                updateUser.EmailAddress = user.EmailAddress;
                updateUser.IDNumber = user.IDNumber;
                updateUser.GrantAccessToTestEnvironment = user.GrantAccessToTestEnvironment;
                if (user.CompanyID.HasValue)
                    updateUser.CompanyID = user.CompanyID;
                updateUser.LastChangedBy = UserAppData.CurrentUserName;
                updateUser.LastChangedDate = DateTime.Now;
                _context.Update(updateUser);

                int result = await _context.SaveChangesAsync();
                if (result > 0)

                {
                    if (UserAppData.CurrentUserName.Equals(updateUser.EmailAddress))
                    {
                        UserAppData.CurrentUserName = updateUser.EmailAddress;
                        UserAppData.UserFullName = updateUser.UserFullName;
                        UserAppData.UserProfileImage = updateUser.ProfileImage;
                        UserAppData.CurrentUserTypeID = updateUser.UserTypeID;
                        UserAppData.CanOverrideMaintananceMode = updateUser.CanOverrideMaintananceMode;
                        UserAppData.GrantAccessToTestEnvironment = updateUser.GrantAccessToTestEnvironment;
                        UserAppData.CompanyID = updateUser.CompanyID ?? 0;
                    }
                    // also need to update id number and email address on client account 
                    Client client = _context.Clients.FirstOrDefault(u => u.IDNumber.Equals(oldIDNumber) && u.EmailAddress.Equals(oldEmailAddress));
                    if (updateUser.IsNotNull() && client.IsNotNull())
                    {
                        client.EmailAddress = user.EmailAddress;
                        client.IDNumber = user.IDNumber;
                        client.LastChangedBy = UserAppData.CurrentUserName;
                        client.LastChangedDate = DateTime.Now;
                        _context.Update(client);
                        result = await _context.SaveChangesAsync();
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

        public bool EmailExists(string emailAddress)
        {
            try
            {

                var user = _context.Users.Where(u => u.EmailAddress.Equals(emailAddress)).FirstOrDefault();
                return user.IsNotNull();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(User user, bool generateUserName)
        {
            try
            {

                user.Password = Encryption.Encrypt(UtilityService.GeneratePassword);
                user.LastChangedBy = String.IsNullOrEmpty(UserAppData.CurrentUserName) ? "System" : UserAppData.CurrentUserName;
                user.LastChangedDate = DateTime.Now;

                user.PasswordExpiryDate = DateTime.Now;
                _context.Add(user);
                await _context.SaveChangesAsync();
                int userid = user.UserID;

                if ((TypeOfUser)user.UserTypeID == TypeOfUser.Employee)
                {
                    //assign default role
                    UserRole userRole = new UserRole();
                    userRole.RoleID = (int)DefaultRoles.Employee;
                    userRole.UserID = userid;
                    userRole.LastChangedBy = String.IsNullOrEmpty(UserAppData.CurrentUserName) ? "System" : UserAppData.CurrentUserName;
                    userRole.LastChangedDate = DateTime.Now;
                    int _result = await Save(userRole);
                }
                return userid;
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
                user.LastChangedBy = UserAppData.CurrentUserName;
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
        public string GetCredential(int id)
        {
            try
            {
                string _password = _context.Users.Find(id)?.Password;
                return Encryption.Decrypt(_password);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> SaveUserRoles(int UserID, List<string> RoleID)
        {
            try
            {
                foreach (var role in RoleID)
                {
                    int.TryParse(role, out int roleID);
                    UserRole userRole = new UserRole
                    {
                        UserID = UserID,
                        UserRoleID = roleID,
                        LastChangedBy = UserAppData.CurrentUserName,
                        LastChangedDate = DateTime.Now,
                    };

                    _context.Add(userRole);
                }

                await _context.SaveChangesAsync();
                return (await _context.SaveChangesAsync());
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
                var usr = await _context.Users.FindAsync(id);
                _context.Users.Remove(usr);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<UserRole> GetUserRole(int id, int userid)
        {
            try
            {
                return await _context.UserRoles.Where(usr => usr.RoleID == id && usr.UserID == userid).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> ActionUserRole(int id, int userid, DatabaseAction action)
        {
            try
            {

                UserRole userRole = await GetUserRole(id, userid);

                if (DatabaseAction.Remove == action)
                    _context.UserRoles.Remove(userRole);
                else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
                {

                    userRole.LastChangedBy = UserAppData.CurrentUserName;
                    userRole.LastChangedDate = DateTime.Now;
                    _context.Update(userRole);
                }
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public bool HasPermission(Permissions permission)
        {
            try
            {
                List<Role> roles = GetUserRoles(username: UserAppData.CurrentUserName);
                return roles.Any(x => x.RolePermissions.Any(p => p.PermissionID == (int)permission));
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        private static Lazy<UserService> instance = new Lazy<UserService>(() => new UserService());

        public static UserService Instance => instance.Value;

        public List<Role> GetAllRoles()
        {
            try
            {
                return _context.Roles.ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<int> UpdateRoles(int userID, string[] selectedRoles)
        {
            int result = 0;
            try
            {
                IEnumerable<int> oldRoles = from c in _context.UserRoles
                                            where c.UserID == userID
                                            select c.RoleID;

                List<int> old_Roles = oldRoles.ToList();
                List<int> add_Roles = new List<int>();
                List<int> remove_Roles = new List<int>();
                int[] updated_Details = selectedRoles == null ? null : Array.ConvertAll(selectedRoles, s => int.Parse(s));


                if (old_Roles == null && old_Roles.Count == 0)
                {
                    add_Roles = updated_Details.ToList();
                    return await AddRole(userID, add_Roles);
                }
                foreach (var role in _context.Roles)
                {
                    if (selectedRoles.Contains(role.RoleID.ToString()))
                    {
                        if (!old_Roles.Contains(role.RoleID))
                        {
                            add_Roles.Add(role.RoleID);
                        }
                    }
                    else
                    {
                        if (old_Roles.Contains(role.RoleID))
                        {
                            remove_Roles.Add(role.RoleID);
                        }
                    }
                }
                int _addResult = await AddRole(userID, add_Roles);
                int _removeResult = await RemoveRoleFromUser(userID, remove_Roles);
                result = _addResult + _removeResult;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                return 0;
            }
            return result;
        }

        public async Task<int> AddRole(int userID, List<int> roles)
        {
            try
            {

                foreach (int roleid in roles)
                {
                    UserRole userRole = new UserRole
                    {
                        UserID = userID,
                        RoleID = roleid,
                        LastChangedBy = UserAppData.CurrentUserName,
                        LastChangedDate = DateTime.Now
                    };
                    _context.Add(userRole);

                }
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                return 0;
            }
        }
        public async Task<int> RemoveRoleFromUser(int userID, List<int> roles)
        {
            try
            {
                List<UserRole> userRoles = await _context.UserRoles.Where(r => r.UserID == userID).ToListAsync();
                var rolesToBeRemoved = userRoles
                        .Where(x => roles.Any(y => y == x.RoleID));
                _context.UserRoles.RemoveRange(rolesToBeRemoved);
                return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        #region ToDoList
        public async Task<bool> IsDuplicate(UserToDo userToDo)
        {
            bool result = false;
            try
            {
                UserToDo todo = await _context.UserToDos.Where(b => b.ToDo.Equals(userToDo.ToDo) && b.UserID == userToDo.UserID).FirstOrDefaultAsync();
                result = todo.IsNotNull();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }
        public async Task<List<UserToDo>> ToDoList(int userID)
        {
            List<UserToDo> result = null;
            try
            {
                result = await _context.UserToDos.Where(u => u.UserID == userID)
               .AsNoTracking()
               .ToListAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;

        }

        public async Task<int> DeleteToDo(int id)
        {
            int result = 0;
            try
            {

                var _result = await _context.UserToDos.FindAsync(id);
                _context.UserToDos.Remove(_result);
                result = await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }

        public async Task<UserToDo> FindToDo(int id)
        {
            UserToDo result = null;
            try
            {
                result = await _context.UserToDos.Where(r => r.UserToDoID == id)
                .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return result;
        }

        public async Task<int> Save(UserToDo userToDo)
        {
            try
            {
                userToDo.DateCreated = DateTime.Now;
                userToDo.LastChangedBy = UserAppData.CurrentUserName;
                userToDo.LastChangedDate = DateTime.Now;
                _context.Add(userToDo);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
            return userToDo.UserToDoID;
        }


        public async Task<int> Update(UserToDo userToDo)
        {
            try
            {

                UserToDo update = _context.UserToDos.Where(r => r.UserToDoID == userToDo.UserToDoID).FirstOrDefault();
                update.ToDo = userToDo.ToDo;
                update.DueDate = userToDo.DueDate;
                update.LastChangedBy = UserAppData.CurrentUserName;
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
        #endregion ToDoList


    }
}
