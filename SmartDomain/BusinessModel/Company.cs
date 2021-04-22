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
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        [ForeignKey("CountryID")]
        public int? CountryID { get; set; }
        public virtual Country Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }
        public string Website { get; set; }
        public bool IsDefault { get; set; }
        public bool IsActive { get; set; }
        public byte[] CompanyLogo { get; set; }
        public virtual List<Product> CompanyProducts { get; set; }
        public virtual List<Client> Clients { get; set; }

    }
}