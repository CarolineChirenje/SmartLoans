using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
    public class RoleMenu : ChangeAudit
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoleMenuID { get; set; }
        public int MenuID { get; set; }
        public virtual Menu Menu { get; set; }
        public int RoleID { get; set; }
        public virtual Role Roles { get; set; }
       
}
}
