using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartDomain
{
    public class ClientDeduction : ChangeAudit
    {
        [Key]

        public int ClientDeductionID { get; set; }
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
        public int ClientProductID { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DeductedAmount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal DeductionPercentage { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal AdditionalDeductionPercentage { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalDeductionPercentage { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? DatePaid { get; set; }
        [NotMapped]
        public  bool IsPaid { get { return DatePaid.HasValue; } }

}
}
