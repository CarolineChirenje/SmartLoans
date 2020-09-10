using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartDomain
{
 public   class Notes : ChangeAudit
    {
        [Required]
        public string Comment { get; set; }
        public int UserTypeID { get; set; }
        public virtual UserType UserType { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd HH:mm}")]
        public DateTime DateUploaded { get; set; }
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd HH:mm}")]
        public DateTime? DateClosed { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd HH:mm}")]
        [Required]
        public DateTime DueDate { get; set; }
        public string UploadedBy { get; set; }
    }
}
