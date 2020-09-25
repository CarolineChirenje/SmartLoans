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
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd HH:mm}")]
        public DateTime StartDate { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd HH:mm}")]
        public DateTime EndDate { get; set; }
        [DisplayName("Priority")]
        public int PriorityRankID { get; set; }
        public virtual PriorityRank PriorityRank { get; set; }
        public bool IsActive { get; set; }
              
    }
}
