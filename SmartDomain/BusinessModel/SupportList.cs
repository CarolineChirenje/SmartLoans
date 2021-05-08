using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartDomain
{
  public  class SupportList : ChangeAudit
    {
        [Key]
        public int SupportListID { get; set; }
        public string Name { get; set; }
     }
}
