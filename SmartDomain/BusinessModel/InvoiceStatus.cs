using System.ComponentModel.DataAnnotations;

namespace SmartDomain
{
    public class InvoiceStatus : ChangeAudit
    {
        [Key]
        public int InvoiceStatusID { get; set; }
        public string Name { get; set; }
         }
}

