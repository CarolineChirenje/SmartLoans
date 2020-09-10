using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
    public class BroadCast : ChangeAudit
    {
        public int BroadCastID { get; set; }
        public string DisplaySite { get; set; } // separated by ,
        public string Message { get; set; }
        public bool IsActive { get; set; }
        public DateTime EffectiveFrom { get; set; }
        public DateTime EffectiveTo { get; set; }
    }
}
