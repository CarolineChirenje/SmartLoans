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
        public bool IsLegibleForPenalties { get; set; }
        public bool IsActive { get; set; }

        public int ProductComputationID { get; set; }
        public virtual ProductComputation ProductComputation { get; set; }
        public int CompanyID { get; set; }
        public virtual Company Company { get; set; }
        public int CountryID { get; set; }
        public virtual Country Country { get; set; }
        public int? CurrencyID { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual List<Loan> Loans { get; set; }
        public virtual List<ProductFee> ProductFees { get; set; }
        
        



    }
}
