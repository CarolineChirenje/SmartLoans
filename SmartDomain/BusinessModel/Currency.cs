using System.ComponentModel.DataAnnotations;

namespace SmartDomain
{

    public class Currency : ChangeAudit
    {
        [Key]
        public int CurrencyID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

    }
}