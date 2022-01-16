using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartDomain
{
    public class KonapoFundCTI : ChangeAudit
    {
        [Key]
        public int KonapoFundCTIID { get; set; }
        public int KonapoFundCTID { get; set; }
        [ForeignKey("KonapoFundCTID")]
        public virtual KonapoFundCT KonapoFundCT { get; set; }
        public int FundCategoryItemID { get; set; }
        public virtual FundCategoryItem FundCategoryItem { get; set; }
        public int FundSourceID { get; set; }
        public virtual FundSource FundSource { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? ProjectedCost { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? KonapoAmount { get; set; }
        [NotMapped]
        public string ProjectedCostAmount { get; set; }
        [NotMapped]
        public string AmountProvided { get; set; }

    }
}
