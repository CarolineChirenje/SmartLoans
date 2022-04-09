using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
    public class PenaltyType : ChangeAudit
    {
        [Key]
        public int PenaltyTypeID { get; set; }
        public string Name { get; set; }
           }
}
