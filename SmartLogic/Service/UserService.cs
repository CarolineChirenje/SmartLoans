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
        private  DatabaseContext _context;

        public object Encrypt { get; private set; }

        public UserService(DatabaseContext context) => _context = context;

        public UserService()
        {
        }

        public async Task<User> FindUser(int id = 0, string username = null)
        {
            if (!String.IsNullOrEmpty(username))
                id = _context.Users.FirstOrDefault(u => u.UserName.ToUpper() == username.Trim().ToUpper())?.UserID ?? 0;
            return await _context.Users.Include(p => p.UserRoles)
                         .ThenInclude(r => r.Roles)
                         .ThenInclude(r=>r.RolePermissions)
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
             userRole => userRole.UserID == id && !userRole.IsDeleted).Select(r => r.RoleID.ToString()).ToArray();

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
            updateUser.FirstName = user.FirstName;
            updateUser.LastName = user.LastName;
            updateUser.IsActive = user.IsActive;
            updateUser.EmailAddress = user.EmailAddress;
            updateUser.LastChangedBy = UtilityService.CurrentUserName;
            updateUser.LastChangedDate = DateTime.Now;
            _context.Update(updateUser);
            await _context.SaveChangesAsync();
            return await _context.SaveChangesAsync();
        }
        public async Task<int> Save(User user)
        {

            user.Password = Encryption.Encrypt(UtilityService.GeneratePassword);
            user.LastChangedBy = UtilityService.CurrentUserName;
            user.LastChangedDate = DateTime.Now;
            user.UserTypeID = (int)TypeOfUser.Administrator;
            user.UserName = UtilityService.GenerateUserName(user.FirstName, user.LastName);
            _context.Add(user);
            return (await _context.SaveChangesAsync());
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
                    IsActive = true,
                    IsDeleted = false,
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
                userRole.IsActive = DatabaseAction.Deactivate == action ? false : true;
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

    }
}
