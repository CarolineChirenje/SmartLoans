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
    public class UserAccessRestriction : ChangeAudit
    {

        [Key]
        public int UserAccessRestrictionID { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public DateTime RestrictFrom { get; set; }
        public DateTime RestrictUntil { get; set; }

    }

}
