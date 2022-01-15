using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartDomain
{
    public class KonapoFundDetail : ChangeAudit
    {
        [Key]
        public int KonapoFundDetailID { get; set; }
        public int KFundID { get; set; }
        //[ForeignKey("KonapoFundID")]
        //public virtual KonapoFund KonapoFund { get; set; }
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
