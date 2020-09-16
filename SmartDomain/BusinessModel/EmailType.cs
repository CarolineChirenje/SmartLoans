using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartDomain
{
  public  class EmailType:ChangeAudit
    {
        [Key]
        public int EmailTypeID { get; set; }
        public string Name { get; set; }
       
    }
}
