using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartDomain
{
    public class KonapoFundCTIHistory : ChangeAudit
    {
        [Key]
        public int KonapoFundCTIHistoryID { get; set; }
        public int KonapoFundCTIID { get; set; }
        public int FundSourceID { get; set; }
        public bool IsActive { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? ProjectedCost { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? KonapoAmount { get; set; }


    }
}
