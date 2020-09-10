using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace SmartDomain
{
    public class CustomSettingType : ChangeAudit
    {
        [Key]
        public int CustomSettingTypeID { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }
     
    }
}
