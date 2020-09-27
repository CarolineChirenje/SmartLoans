using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartDomain
{   
    public class Company : ChangeAudit
    {
        [Key]
        public int CompanyID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public bool IsActive { get; set; }
        public byte[] CompanyLogo { get; set; }
        public virtual List<Product> CompanyProducts { get; set; }


    }
}