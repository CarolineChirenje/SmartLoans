using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
    public class LoanFiscal : ChangeAudit
    {
        [Key]
        public int LoanFiscalID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
      
    }


}
