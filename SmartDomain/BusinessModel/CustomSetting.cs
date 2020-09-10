using SmartHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SmartDomain
{
    public class CustomSetting : ChangeAudit
    {
        [Key]
        public int CustomSettingID { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public int CustomVariableTypeID { get; set; }
        public virtual CustomVariableType CustomVariableType { get; set; }

        public int CustomSettingTypeID { get; set; }
        public virtual CustomSettingType CustomSettingType { get; set; }
        public bool IsActive { get; set; }


    }

    
}
