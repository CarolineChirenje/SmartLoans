using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
    public class TransactionType : ChangeAudit
    {
        [Key]
        public int TransactionTypeID { get; set; }
        public int TransactionStatusID { get; set; }
        public virtual TransactionStatus TransactionStatus { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }

        [NotMapped]
        public string TransType { get { return Code?.ToUpper() + " - "+ Name?.ToUpper(); } }
    }

}