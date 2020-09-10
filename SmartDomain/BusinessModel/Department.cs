using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartDomain
{
    public class Department : ChangeAudit
    {  [Key]
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public virtual List<Client> Clients { get; set; }
        
    }
}
