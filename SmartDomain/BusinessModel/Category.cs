using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
   public class Category : ChangeAudit
    { 
     [Key]
    public int CategoryID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsActive { get; set; }
    public virtual List<SubCategory> SubCategories { get; set; }

    }

}
