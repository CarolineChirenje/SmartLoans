using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartDomain
{
    public class AuditAction
    {

        [Key]
        public int AuditActionID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
