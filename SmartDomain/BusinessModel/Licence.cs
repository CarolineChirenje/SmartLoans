using SmartHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartDomain
{
    public class Licence : ChangeAudit
    {
        [Key]
        public int LicenceID { get; set; }
        public string Reason { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd HH:mm}")]
        public DateTime StartDate { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd HH:mm}")]
        public DateTime EndDate { get; set; }
        [NotMapped]
        public string Period { get { return $"{UtilityService.ShowDateTime(StartDate)} up until {UtilityService.ShowDateTime(EndDate)}"; } }

        [NotMapped]
        public bool HasExpired { get { return EndDate>=DateTime.Now; } }

    }
}
