using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartDomain
{
    public class Fee : ChangeAudit
    {
        [Key]
        public int FeeID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }

}
