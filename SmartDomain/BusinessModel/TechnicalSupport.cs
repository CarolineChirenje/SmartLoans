using SmartHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartDomain
{
[   Table("TechnicalSupport")]
    public class TechnicalSupport
    {
        [Key]
        public int TechnicalSupportID { get; set; }
        public int SupportListID { get; set; }
        public virtual SupportList SupportList { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
