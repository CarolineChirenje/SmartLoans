using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
   public class FundCategory : ChangeAudit
    { 
     [Key]
      public int FundCategoryID { get; set; }
        public string Name { get; set; }
        public int FundID { get; set; }
        public virtual Fund Fund { get; set; }
        public bool IsActive { get; set; }
        public virtual List<FundCategoryItem> FundCategoryItems { get; set; }
    }

}
