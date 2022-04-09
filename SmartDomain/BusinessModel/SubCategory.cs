using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
   public class SubCategory : ChangeAudit
    { 
     [Key]
      public int SubCategoryID { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public bool IsActive { get; set; }
        public virtual List<CategoryItem> CategoryItems { get; set; }
    }

}
