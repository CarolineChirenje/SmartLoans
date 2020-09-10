
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net;

namespace SmartDomain
{
    public class MenuGroup : ChangeAudit
    {
        [Key]
        public int MenuGroupID { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string CSSClass { get; set; }
        public int OrderNo { get; set; }
        public bool IsActive { get; set; }
        public bool IsActiveMenu { get; set; }
        public virtual List<Menu> Menus { get; set; }

    }

}