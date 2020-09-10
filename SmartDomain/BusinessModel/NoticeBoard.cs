using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartDomain
{
    public class NoticeBoard : ChangeAudit
    {
        [Key]
        public int NoticeID { get; set; }

        [Required]
        public string Title { get; set; }
        public string Details { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd}")]
        public DateTime EndDate { get; set; }
        [DisplayName("Priority")]
        public int PriorityRankID { get; set; }
        public virtual PriorityRank PriorityRank { get; set; }
        public bool IsActive { get; set; }
        public bool SendToGuardian { get; set; }
        public bool SendToClient { get; set; }
    }
}
