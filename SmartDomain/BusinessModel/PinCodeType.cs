using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Linq;
namespace SmartDomain
{
    public class PinCodeType : ChangeAudit
    {

        [Key]
        public int PinCodeTypeID { get; set; }
        public string Name { get; set; }
    
    }
}

