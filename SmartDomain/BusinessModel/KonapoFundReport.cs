using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartDomain
{
    public class KonapoFundReport : ChangeAudit
    {
        [Key]
        public int KonapoFundReportID { get; set; }
        public int KonapoFundID { get; set; }
        public virtual KonapoFund KonapoFund { get; set; }
        public string JsonData { get; set; }
        public string FileName { get; set; }
        public string QRCodeURL { get; set; }
        public byte[] Report { get; set; }
    }
}
