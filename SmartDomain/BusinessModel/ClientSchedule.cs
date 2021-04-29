using SmartDomain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
    public class InvoiceEntries
    {
        [Key]
        public int ClientID { get; set; }
        public int ClientProductID { get; set; }
        public int ProductID { get; set; }
        public virtual string ProductName { get; set; }
        public string Occupation { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [DefaultValue("0.00")]
        public decimal Salary { get; set; }
        public string ClientFullName { get; set; }
        public DateTime InvoiceDate { get; set; }
        public bool IsSelected { get; set; }
    }
    public class InvoicePackage
    {
        public List<InvoiceEntries> Entries { get; set; }
        public Invoice InvoiceDetail { get; set; }
    }



}
