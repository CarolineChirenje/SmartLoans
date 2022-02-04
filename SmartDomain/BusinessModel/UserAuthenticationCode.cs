using SmartHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartDomain
{
    public class UserAuthenticationCode
    {
        [Key]
        public int UserAuthenticationCodeID { get; set; }
        public int? UserID { get; set; }
        public virtual User User { get; set; }
        public int? ClientID { get; set; }
        public virtual Client Client { get; set; }
        public string PinCode { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsAccountCreation { get; set; }
        [ForeignKey("PinCodeTypeID")]
        public int PinCodeTypeID { get; set; }
        public virtual PinCodeType PinCodeType { get; set; }
        public bool IsValid { get; set; }

    }

    public class UserAuthenticate
    {
        public int UserID { get; set; }
        public string EmailAddress { get; set; }
        public string IDNumber { get; set; }
        public bool IsAccountCreation { get; set; } = false;
        public string FullName { get; set; }
        public string PinCode { get; set; }
        public CodeType CodeType { get; set; }
        public bool DoNotAskForTheDay { get; set; } = false;
        public string ExpiryDate { get; set; }
        public bool IsReverify { get; set; }
        public bool Success { get; set; } = true;
    }

    public class AuthenticateResult
    {
        public string PinCode { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
