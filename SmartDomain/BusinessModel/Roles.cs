using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartDomain
{
    public class Role : ChangeAudit
    {
        [Key]
        public int RoleID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public virtual List<RolePermission> RolePermissions { get; set; }
        public virtual List<UserRole> UserRoles { get; set; }
        public virtual List<RoleMenu> RoleMenus { get; set; }

        [NotMapped]
        public int PermissionID { get; set; }
        [NotMapped]
        public int UserID { get; set; }
        [NotMapped]
        public int MenuID { get; set; }

        [NotMapped]
        public int DuplicateRoleID { get; set; }



    }
}
