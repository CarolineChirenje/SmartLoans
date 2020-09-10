using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartDomain
{
  public  class Documents : ChangeAudit
    {
        public int DocumentTypeID { get; set; }
        public virtual DocumentType DocumentType { get; set; }
        public string Comment { get; set; }
        public DateTime DateUploaded { get; set; }
        public string UploadedBy { get; set; }
        public byte[] FileBytes { get; set; }
        public string FileType { get; set; }
        public string FileName { get; set; }
        [NotMapped]
        public string FileFullName { get { return String.Concat(FileName, ".", FileType); } }
    }
}
