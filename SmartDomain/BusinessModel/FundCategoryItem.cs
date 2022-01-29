using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
    public class FundCategoryItem : ChangeAudit
    {
        [Key]
        public int FundCategoryItemID { get; set; }
        public int FundItemID { get; set; }
        public virtual FundItem FundItem { get; set; }
        public int FundCategoryID { get; set; }
        public virtual FundCategory FundCategory { get; set; }
        public bool IsActive { get; set; }

    }

}
