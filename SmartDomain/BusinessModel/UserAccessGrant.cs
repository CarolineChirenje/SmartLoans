using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
    public class UserAccessGrant : ChangeAudit
    {
        [Key]
        public int UserAccessGrantID { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public DateTime AllowUntil { get; set; }
    }

}
