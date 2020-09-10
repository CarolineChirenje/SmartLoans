using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
    public class Product : ChangeAudit
    {
        [Key]
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string ProductCode { get; set; }
        public int ProductFrequencyID { get; set; }
        public virtual ProductFrequency ProductFrequency { get; set; }
        public bool IsActive { get; set; }
        public int CompanyID { get; set; }
        public virtual Company Company { get; set; }
        public virtual List<Client> Clients { get; set; }
    }
}
