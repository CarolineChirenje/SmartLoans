using SmartHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartDomain
{ 
   public class CustomSelectList
    {
    [Key]
    public int ID { get; set; }
    public string Name { get; set; }
}

    public class InvoiceDetails
    {
        [Key]
        public List<ClientDeductionDetails> DeductionDetails { get; set; }
        public InvoiceState State { get; set; }
        public string InvoiceTitle { get; set; }
    }
}
