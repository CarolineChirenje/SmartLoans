using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
    public class FiscalYear : ChangeAudit
    {
        [Key]
        public int FiscalYearID { get; set; }
        public string Name { get; set; }
        public bool IsCurrent { get; set; }
      
    }


}
