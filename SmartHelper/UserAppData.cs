using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHelper
{
    public static class UserAppData
    {
        public static string CurrentUserName { get; set; }
        public static string UserFullName { get; set; }
        public static string UserRole { get; set; }
        public static int UserRoleID { get; set; }
        public static byte[] UserProfileImage { get; set; }
        public static int CurrentUserTypeID { get; set; }
        public static bool CanOverrideMaintananceMode { get; set; }
        public static bool CanOverrideUserNotFound { get; set; }
        public static TypeOfUser UserType { get; set; }

        public static Menu_Component MenuComponent { get; set; }
        public static List<int> Permissions { get; set; }
        public static List<int> Roles { get; set; }
        public static bool HasPermission(Permissions permission) => Permissions.Any(p => p == (int)permission);
        public static string DatabaseConnection { get; set; }
        public static string Environment { get; set; }
        public static string ApplicationName { get; set; }
                public static bool IsNotAdmin { get; set; }
        public static SiteEnvironment SiteEnvironment { get; set; }
        
    }
}
