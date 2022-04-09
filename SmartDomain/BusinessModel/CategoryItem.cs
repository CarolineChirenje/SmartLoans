using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
    public class CategoryItem : ChangeAudit
    {
        [Key]
        public int CategoryItemID { get; set; }
        public string  Name { get; set; }
        public int SubCategoryID { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public bool IsActive { get; set; }

    }

}
