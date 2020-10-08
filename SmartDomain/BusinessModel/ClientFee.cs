using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartDomain
{
    public class ClientFee : ChangeAudit
    {
        [Key]

        public int ClientFeeID { get; set; }
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
        public int ClientProductID { get; set; }
        public int ProductFeeID { get; set; }
        public virtual ProductFee ProductFee { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? DatePaid { get; set; }
        [NotMapped]
        public bool IsPaid { get { return DatePaid.HasValue; } }




    }
}
