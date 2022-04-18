using System;
using System.Collections.Generic;
using System.ComponentModel;
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
       

        public int LoanStatusID { get; set; }
        public virtual LoanStatus LoanStatus { get; set; }

        public int? LoanTypeID { get; set; }
        public virtual LoanType LoanType { get; set; }


        public int?LoanSectorID { get; set; }
        public virtual LoanSector LoanSector { get; set; }

        public int? LoanUseID { get; set; }
        public virtual LoanUse LoanUse { get; set; }

        public int? LoanFinanceID { get; set; }
        public virtual LoanFinance LoanFinance { get; set; }
        public bool IsActive { get; set; }
        public DateTime RegistrationDate { get; set; }

    
       
        public string CreatedBy { get; set; }
        public string FinalisedBy { get; set; }
        public DateTime DateFinalised { get; set; }
        public virtual List<LoanBeneficiary> LoanBeneficiaries { get; set; }
        public virtual List<LoanSchedule> LoanSchedules { get; set; }
        public virtual List<LoanDocument> LoanDocuments { get; set; }

        [NotMapped]
        public int ProductID { get; set; }
    }
}

