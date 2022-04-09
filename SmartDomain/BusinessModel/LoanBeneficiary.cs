using SmartHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartDomain
{
    public class LoanBeneficiary : ChangeAudit
    {
        [Key]
        public int LoanBeneficiaryID { get; set; }
        public int LoanID { get; set; }
        public virtual Loan Loan { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Surname { get; set; }
        [Required]
        [Column("IDNumber")]
        [StringLength(50)]
        public string IDNumber { get; set; }
        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }
        public int GenderID { get; set; }
        public virtual Gender Gender { get; set; }
        public int RelationshipTypeID { get; set; }
        public virtual RelationshipType RelationshipType { get; set; }
        public int CategoryItemID { get; set; }
        public virtual CategoryItem CategoryItem { get; set; }

        [NotMapped]
        public int Age { get { return UtilityService.CalculateAge(DateOfBirth); } }
        [NotMapped]
        public string FullName { get { return String.Concat(Name, ",", Surname); } }

    }
}

