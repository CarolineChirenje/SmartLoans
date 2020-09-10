using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace SmartDomain
{
    public class CustomVariableType : ChangeAudit
    {
        [Key]
        public int CustomVariableTypeID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        }
}
