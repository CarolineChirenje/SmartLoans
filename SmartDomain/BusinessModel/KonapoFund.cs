using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartDomain
{
    public class KonapoFund : ChangeAudit
    {
        [Key]
        public int KonapoFundID { get; set; }
        public string KonapoRef { get; set; }
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
        public int FundID { get; set; }
        public virtual Fund Fund { get; set; }
        public bool IsActive { get; set; }

        public DateTime RegistrationDate { get { return DateTime.Now; } }
        public virtual List<KonapoFundDetail> KonapoFundDetails { get; set; }

        [NotMapped]
        public string FundDetails{ get { return $"{KonapoRef}-{Fund?.Name}"; } }
    }
}
