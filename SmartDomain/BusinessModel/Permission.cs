using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
    public class Permission : ChangeAudit
    {
        [Key]
        public int PermissionID { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
            public virtual List<RolePermission> RolePermissions { get; set; }
    
    }
  

}
