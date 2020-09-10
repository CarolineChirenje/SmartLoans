using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
   public class DocumentType : ChangeAudit
    {
        [Key]
        public int DocumentTypeID { get; set; }

        public string Name { get; set; }

        public int DocumentFormatID { get; set; }
        public virtual DocumentFormat DocumentFormat { get; set; }
        public bool IsActive { get; set; }

       
    }
}
