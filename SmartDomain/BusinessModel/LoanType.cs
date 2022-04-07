using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
    public class LoanType : ChangeAudit
    {
        [Key]
        public int LoanTypeID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
      
    }


}
