using SmartHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int GenderID { get; set; }


        public bool IsActive { get; set; }

        public DateTime RegistrationDate { get; set; }

        [NotMapped]
        public string FullName { get { return String.Concat(LastName, " ", FirstName); } }
        [NotMapped]
        public int  Age { get { return UtilityService.CalculateAge(DateOfBirth); } }

    }
}
