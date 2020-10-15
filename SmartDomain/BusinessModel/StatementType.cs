using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartDomain
{
  public  class StatementList : ChangeAudit
    {
        [Key]
        public int StatementID { get; set; }
        public string Name { get; set; }
       
    }
}
