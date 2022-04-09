using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartDomain
{
    public class CalculationType : ChangeAudit
    {
        [Key]
        public int CalculationTypeID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }

}
