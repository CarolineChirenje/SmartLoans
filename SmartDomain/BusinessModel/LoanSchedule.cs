using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartDomain
{
 public   class LoanSchedule : ChangeAudit
    {
        [Key]
        public int LoanScheduleID { get; set; }
        public int LoanID { get; set; }
        public virtual Loan Loan { get; set; }
        public int LedgerNo { get; set; }
        public bool IsPaid { get; set; }
      
    }
}

