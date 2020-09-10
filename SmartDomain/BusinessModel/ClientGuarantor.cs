using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartDomain
{
    public class ClientGuarantor : ChangeAudit
    {
        [Key]
        public int ClientGuarantorID { get; set; }
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string IDNumber { get; set; }

        public bool IsMainGuarantor { get; set; }

        public string EmailAddress { get; set; }

        public string MobileNumber { get; set; }
        [Required]
        public string PhysicalAddress { get; set; }

        [NotMapped]
        public string GuarantorFullName { get { return String.Concat(LastName, " ", FirstName); } }
        [NotMapped]
        public string GuarantorContacts { get { return String.Concat(MobileNumber, "-", EmailAddress); } }
    }
}
