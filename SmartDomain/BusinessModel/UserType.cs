using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;
namespace SmartDomain
{
    public class UserType : ChangeAudit
    {

        [Key]
        public int UserTypeID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

    }
}

