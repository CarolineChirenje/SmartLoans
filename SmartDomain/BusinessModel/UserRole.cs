using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{

    public class UserRole : ChangeAudit
    {
        [Key]
        public int UserRoleID { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }

        public int RoleID { get; set; }
        public virtual Role Roles { get; set; }
    
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
     
    }
}
