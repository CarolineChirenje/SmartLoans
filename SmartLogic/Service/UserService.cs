using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SmartDataAccess;
using SmartDomain;
using SmartHelper;

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
        public List<UserType> GetUserTypes() => _context.UserTypes.Where(t => t.IsActive).ToList();
        public async Task<User> FindUser(int id = 0, string username = null)
        {
            if (!String.IsNullOrEmpty(username))
                id = _context.Users.FirstOrDefault(u => u.UserName.ToUpper() == username.Trim().ToUpper())?.UserID ?? 0;
            return await _context.Users.Include(p => p.UserRoles)
                         .ThenInclude(r => r.Roles)
                         .ThenInclude(r => r.RolePermissions)
                         .Include(ut => ut.UserType).
                Where(r => r.UserID == id).FirstOrDefaultAsync();
        }
        public List<Role> GetUserRoles(int id = 0, string username = null)
        {
            if (!UtilityService.IsNotNull(_context))
            {
                return null;
            }
            if (!String.IsNullOrEmpty(username))
            {
                var user = _context.Users.Where(u => u.UserName.ToUpper() == username.Trim().ToUpper()).FirstOrDefault();
                if (!UtilityService.IsNotNull(user))
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

        public async Task<List<User>> Users()
        {
            return await _context.Users.
                Include(usr => usr.UserRoles).
                Include(ut => ut.UserType).ToListAsync();
        }
        public async Task<int> Update(User user)
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
            updateUser.LastChangedBy = UtilityService.CurrentUserName;
            updateUser.LastChangedDate = DateTime.Now;
            _context.Update(updateUser);

            int result = await _context.SaveChangesAsync();
            if (result > 0)
            {  // also need to update id number and email address on client account 
                Client client = _context.Clients.FirstOrDefault(u => u.IDNumber.Equals(oldIDNumber) && u.EmailAddress.Equals(oldEmailAddress));
                if (UtilityService.IsNotNull(user) && UtilityService.IsNotNull(client))
                {
                    client.EmailAddress = user.EmailAddress;
                    client.IDNumber = user.IDNumber;
                    client.LastChangedBy = UtilityService.CurrentUserName;
                    client.LastChangedDate = DateTime.Now;
                    _context.Update(client);
                    result = await _context.SaveChangesAsync();
                }
            }
            return result;
        }

        public bool UserExists(string emailAddress)
        {
            var user = _context.Users.Where(u => u.EmailAddress.Equals(emailAddress)).FirstOrDefault();
            return UtilityService.IsNotNull(user);


        }
        public async Task<int> Save(User user, bool generateUserName)
        {

            user.Password = Encryption.Encrypt(UtilityService.GeneratePassword);
            user.LastChangedBy = String.IsNullOrEmpty(UtilityService.CurrentUserName) ? "System" : UtilityService.CurrentUserName;
            user.LastChangedDate = DateTime.Now;
            // user.UserTypeID = (int)TypeOfUser.Administrator;
            if (generateUserName)
                user.UserName = UtilityService.GenerateUserName(user.FirstName, user.LastName);
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
                userRole.LastChangedBy = String.IsNullOrEmpty(UtilityService.CurrentUserName) ? "System" : UtilityService.CurrentUserName;
                userRole.LastChangedDate = DateTime.Now;
                int _result = await Save(userRole);
            }
            return userid;
        }
        public async Task<int> Save(UserRole user)
        {
            user.LastChangedBy = UtilityService.CurrentUserName;
            user.LastChangedDate = DateTime.Now;
            _context.Add(user);
            return (await _context.SaveChangesAsync());
        }
        public string GetCredential(int id)
        {

            string _password = _context.Users.Find(id)?.Password;
            return Encryption.Decrypt(_password);
        }

        public async Task<int> SaveUserRoles(int UserID, List<string> RoleID)
        {
            foreach (var role in RoleID)
            {
                int.TryParse(role, out int roleID);
                UserRole userRole = new UserRole
                {
                    UserID = UserID,
                    UserRoleID = roleID,
                    LastChangedBy = UtilityService.CurrentUserName,
                    LastChangedDate = DateTime.Now,
                };

                _context.Add(userRole);
            }

            await _context.SaveChangesAsync();
            return (await _context.SaveChangesAsync());
        }
        public async Task<int> Delete(int id)
        {
            var usr = await _context.Users.FindAsync(id);
            _context.Users.Remove(usr);
            return (await _context.SaveChangesAsync());
        }
        public async Task<UserRole> GetUserRole(int id, int userid)
        {
            return await _context.UserRoles.Where(usr => usr.RoleID == id && usr.UserID == userid).FirstOrDefaultAsync();
        }
        public async Task<int> ActionUserRole(int id, int userid, DatabaseAction action)
        {
            UserRole userRole = await GetUserRole(id, userid);

            if (DatabaseAction.Remove == action)
                _context.UserRoles.Remove(userRole);
            else if (DatabaseAction.Deactivate == action || DatabaseAction.Reactivate == action)
            {

                userRole.LastChangedBy = UtilityService.CurrentUserName;
                userRole.LastChangedDate = DateTime.Now;
                _context.Update(userRole);
            }

            return (await _context.SaveChangesAsync());
        }

        public bool HasPermission(Permissions permission)
        {
            List<Role> roles = GetUserRoles(username: UtilityService.CurrentUserName);

            return roles.Any(x => x.RolePermissions.Any(p => p.PermissionID == (int)permission));


        }
        private static Lazy<UserService> instance = new Lazy<UserService>(() => new UserService());

        public static UserService Instance => instance.Value;

        public List<Role> GetAllRoles() => _context.Roles.ToList();

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
                        LastChangedBy = UtilityService.CurrentUserName,
                        LastChangedDate = DateTime.Now
                    };
                    _context.Add(userRole);

                }
                return await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public async Task<int> RemoveRoleFromUser(int userID, List<int> roles)
        {
            List<UserRole> userRoles = await _context.UserRoles.Where(r => r.UserID == userID).ToListAsync();
            var rolesToBeRemoved = userRoles
                    .Where(x => roles.Any(y => y == x.RoleID));
            _context.UserRoles.RemoveRange(rolesToBeRemoved);
            return (await _context.SaveChangesAsync());
        }



    }
}
