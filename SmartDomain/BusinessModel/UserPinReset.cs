using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartDomain
{
 public   class UserPinReset
    {
        [Key]
        public int UserPinID { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
        public string PinCode { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
