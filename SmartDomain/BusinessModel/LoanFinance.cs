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
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        public int Duration { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime MaturityDate { get; set; }

        [Column(TypeName = "decimal(18, 0)")]
        public decimal Principal { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal ApplicationFee { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Deposit { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal EffectiveDeposit { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal FeesReq { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal MaturityValue { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal FxFixing { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Installment { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal? Interest { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal MinimumUpfront { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Upfront { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal CollectionFee { get; set; }
        public DateTime DateCreated { get; set; }

        [NotMapped]
        public int LoanID { get; set; }
     

    }
}

