using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartDomain
{
  public  class EmailTemplate :ChangeAudit
    {

    [Key]
        public int EmailTemplateID { get; set; }

        public int EmailTypeID { get; set; }
        public virtual EmailType EmailType { get; set; }

      
        public string Subject { get; set; }

        public string Body { get; set; }

        public int PriorityRankID { get; set; }
        public virtual PriorityRank PriorityRank { get; set; }

      
    }
}
