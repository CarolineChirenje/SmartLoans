using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartDomain
{
    public class KonapoFundCT : ChangeAudit
    {
        [Key]
        public int KonapoFundCTID { get; set; }
        public int KonapoFundID { get; set; }
        [ForeignKey("KonapoFundID")]
        public virtual KonapoFund KonapoFund { get; set; }
        public int FundCategoryID { get; set; }
        public virtual FundCategory FundCategory { get; set; }
        public bool IsActive { get; set; }
        public virtual List<KonapoFundCTI> KonapoFundCTIs { get; set; }

        [NotMapped]
        public int CategoryItems { get { return KonapoFundCTIs==null?0 : KonapoFundCTIs.Count; } }


    }
}
