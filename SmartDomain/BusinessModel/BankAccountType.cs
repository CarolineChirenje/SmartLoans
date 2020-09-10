using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace SmartDomain
{
  public  class BankAccountType : ChangeAudit
    {
        [Key]
        public int BankAccountTypeID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
       }
}
