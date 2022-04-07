using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
    public class ProductHistory : ChangeAudit
    {
        [Key]
        public int ProductHistoryID { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        public int ProductComputationID { get; set; }
        public bool IsLegibleForPenalties { get; set; }
        public int? CurrencyID { get; set; }
    }
}
