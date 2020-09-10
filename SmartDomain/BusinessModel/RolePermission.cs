using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
    public class RolePermission : ChangeAudit
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RolePermissionID { get; set; }
        public int PermissionID { get; set; }
        public virtual Permission Permission { get; set; }
        public int RoleID { get; set; }
        public virtual Role Roles { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
}
}
