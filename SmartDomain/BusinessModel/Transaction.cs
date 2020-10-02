using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartDomain
{

    public class Transaction : ChangeAudit
    {
        [Key]
        public int TransactionID { get; set; }
        public string TransRef { get; set; }

        public string Narration { get; set; }
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        public int AssertID { get; set; }
        public int AssertCategoryID { get; set; }
        public int BankAccountID { get; set; }
        public virtual BankAccount BankAccount { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int TransactionTypeID { get; set; }
        public virtual TransactionType TransactionType { get; set; }
        public int PaymentStatusID { get; set; }
        public virtual PaymentStatus PaymentStatus { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal AmountExclVAT { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal VAT { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPaid { get { return Amount; } }
        public DateTime PaymentDate { get; set; }
        public DateTime TransactionDate { get; set; }
        public int? ParentPaymentID { get; set; }

        public string Reason { get; set; }





    }
}

