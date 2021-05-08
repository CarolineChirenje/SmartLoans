using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartDomain
{
   public class Layout : ChangeAudit
    {
        [Key]
        public int LayoutID { get; set; }
        public string DisplayName { get; set; }
        public virtual List<LayoutMenu> Menus { get; set; }

    }
}
