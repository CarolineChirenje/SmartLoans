using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartDomain
{
    public class ProductFeeHistory : ChangeAudit

    {
        [Key]
        public int ProductFeeHistoryID { get; set; }
              public string Description { get; set; }
        public int ProductFeeID { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        public int FeeID { get; set; }
        public virtual Fee Fee { get; set; }
        public int CalculationTypeID { get; set; }
        public virtual CalculationType CalculationType { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        public bool IsActive { get; set; }

    }
}