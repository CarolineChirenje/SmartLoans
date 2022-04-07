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
      
        public int RelationshipTypeID { get; set; }
        public virtual RelationshipType RelationshipType { get; set; }
        //[Column("SubEntityID")]
        //public int SubEntityId { get; set; }


    }
}

