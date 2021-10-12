using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Column(TypeName = "decimal(18,2)")]
        public decimal DeductionPercentage { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal IncreamentPercentage { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal TransactionalFee { get; set; }
        public bool IsActive { get; set; }
        public int CompanyID { get; set; }
        public virtual Company Company { get; set; }
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
        public virtual List<Client> Clients { get; set; }
        public virtual List<ProductAssert> ProductAsserts { get; set; }
        public virtual List<ProductAssertCategory> ProductAssertCategories { get; set; }
        public virtual List<ProductFee> ProductFees { get; set; }
        [NotMapped]
        public int ClientCount { get; set; }

        [NotMapped]
        public int FrequencyID { get; set; }


        [NotMapped]
        public string increasePercentage { get; set; }

        [NotMapped]
        public string deductPercentage { get; set; }

        [NotMapped]
        public string transactionalLevy { get; set; }





    }
}
