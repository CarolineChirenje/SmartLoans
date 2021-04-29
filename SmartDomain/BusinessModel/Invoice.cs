using SmartHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SmartDomain
{
    public class Invoice : ChangeAudit
    {
        [Key]
        public int InvoiceID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public int InvoiceStatusID { get; set; }
        public virtual InvoiceStatus InvoiceStatus { get; set; }
        public int? ProductID { get; set; }
        public virtual Product Product { get; set; }
        public virtual List<InvoiceDetails> InvoiceDetails { get; set; }

        [NotMapped]
        public string Status { get { return ((InvoiceState)InvoiceStatusID).ToString(); } }


        [NotMapped]
        public string InvoiceHeading { get { return $"Invoice No {InvoiceID} Due - {UtilityService.ShowDate(DueDate)}  Status - {Status}"; } }

        [NotMapped]
        public Decimal TotalDeductedAmount{ get { return InvoiceDetails == null ? 0M : InvoiceDetails.Select(a => a.DeductedAmount).Sum(); } }
    }
}
