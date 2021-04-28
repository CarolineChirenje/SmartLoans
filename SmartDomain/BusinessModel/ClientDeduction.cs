﻿using SmartHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SmartDomain
{
    public class ClientDeduction : ChangeAudit
    {
        [Key]
        public int ClientDeductionID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public int InvoiceStatusID { get; set; }
        public virtual InvoiceStatus InvoiceStatus { get; set; }
        public int? ProductID { get; set; }
        public virtual Product Product { get; set; }
        public virtual List<ClientDeductionDetails> ClientDeductionDetails { get; set; }

        [NotMapped]
        public string Status { get { return ((InvoiceState)InvoiceStatusID).ToString(); } }

        [NotMapped]
        public Decimal TotalDeductedAmount{ get { return ClientDeductionDetails == null ? 0M : ClientDeductionDetails.Select(a => a.DeductedAmount).Sum(); } }
    }
}
