using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
   public class AssertCategory : ChangeAudit
    { 
     [Key]
      public int AssertCategoryID { get; set; }
        public string Name { get; set; }
        public int AssertID { get; set; }
        public virtual Assert Assert { get; set; }
        public bool IsActive { get; set; }
  
}

}
