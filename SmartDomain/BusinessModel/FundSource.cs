using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartDomain
{
    public class FundSource : ChangeAudit
    {
        [Key]
        public int FundSourceID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
