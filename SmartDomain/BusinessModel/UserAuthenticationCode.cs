using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartDomain
{
 public   class UserAuthenticationCode
    {
        [Key]
        public int UserPinID { get; set; }
        public int? UserID { get; set; }
        public virtual User User { get; set; }
        public int? ClientID { get; set; }
        public virtual Client Client { get; set; }
        public string PinCode { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool  IsAccountCreation { get; set; }
    }
}
