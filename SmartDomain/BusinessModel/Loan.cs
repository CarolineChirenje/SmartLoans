using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartDomain
{
 public   class Loan : ChangeAudit
    {
        [Key]
        public int LoanID { get; set; }
        public string LoanRef { get; set; }
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        
       
        public bool IsActive { get; set; }
        public DateTime RegistrationDate { get; set; }
        public virtual List<LoanBeneficiary> LoanBeneficiaries { get; set; }
        public virtual List<LoanSchedule> LoanSchedules { get; set; }
        public virtual List<LoanDocument> LoanDocuments { get; set; }
    }
}

