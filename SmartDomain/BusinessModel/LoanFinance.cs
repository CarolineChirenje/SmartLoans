using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartDomain
{
    public class LoanFinance : ChangeAudit
    {
        [Key]
        public int LoanFinanceID { get; set; }
        public int LoanID { get; set; }
        public virtual Loan Loan { get; set; }
        public DateTime MaturityDate { get; set; }
        public DateTime ValueDate { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal ApplicationFee { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Deposit { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal EffectiveDeposit { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal FeesReq { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal FinanceAmount { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal FxFixing { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Installment { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? InterestRate { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal MinimumUpfront { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Upfront { get; set; }
        public DateTime DateCreated { get; set; }

    }
}

