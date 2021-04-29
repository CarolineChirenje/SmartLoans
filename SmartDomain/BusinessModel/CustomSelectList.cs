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

    public class InvoiceDetail
    {
        [Key]
        public List<InvoiceDetails> InvoiceDetails { get; set; }
        public InvoiceState State { get; set; }
        public string InvoiceTitle { get; set; }
        public int InvoiceID { get; set; }
    }
}
