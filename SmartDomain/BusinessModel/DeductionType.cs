using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
    public class DeductionType : ChangeAudit
    {
        [Key]
        public int DeductionTypeID { get; set; }
        public string Name { get; set; }
           }
}
