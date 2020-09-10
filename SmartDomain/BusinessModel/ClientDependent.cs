using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartDomain
{
   public class ClientDependent : ChangeAudit
    {

        [Key]
        public int ClientDependentID { get; set; }

        public int ClientID { get; set; }
        public virtual Client Client { get; set; }

        [Required]
        public string FirstName { get; set; }

        public DateTime DateOfBirth { get; set; }
        [Required]
        public string LastName { get; set; }

        public string IDNumber { get; set; }

        public string Occupation { get; set; }

        public bool IsActive { get; set; }

        
        public DateTime RegistrationDate { get; set; }
       
    }
}
