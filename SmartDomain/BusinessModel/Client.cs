using SmartDomain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
    public class Client : ChangeAudit
    {
        [Key]
        public int ClientID { get; set; }

        public string AccountNumber { get; set; }
        [Required]
        public string FirstName { get; set; }

        public DateTime DateOfBirth { get; set; }
        [Required]
        public string LastName { get; set; }

        public string IDNumber { get; set; }

        public bool IsActive { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }

        public string MobileNumber { get; set; }

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        [ForeignKey("CountryID")]
        public int? CountryID { get; set; }
        public virtual Country Country { get; set; }

        public DateTime RegistrationDate { get; set; }
        public int GenderID { get; set; }
        public virtual Gender Gender { get; set; }

        public int? DepartmentID { get; set; }
        public virtual Department Department { get; set; }
        public string Occupation { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [DefaultValue("0.00")]
        public decimal Salary { get; set; }

        public virtual List<ClientContact> ClientContacts { get; set; }
        public virtual List<ClientDocument> ClientDocuments { get; set; }
        public virtual ICollection<Transaction> ClientPayments { get; set; }
        public virtual List<ClientNote> ClientNotes { get; set; }
        public virtual List<ClientMedicalDetail> ClientMedicalDetails { get; set; }
        public virtual List<ClientDependent> ClientDependents { get; set; }
               public virtual List<ClientProduct> ClientProducts { get; set; }
        public virtual List<ClientCourse> ClientCourses { get; set; }
        public virtual List<ClientFee> ClientFees { get; set; }
        public virtual List<ClientDeduction> ClientDeductions { get; set; }
        
        public virtual List<ClientOccupationHistory> ClientOccupationHistory { get; set; }
        
        [NotMapped]
        public int StatementID { get; set; }
        [NotMapped]
        public virtual Statement Statement { get; set; }

        [NotMapped]
        public string ClientFullName { get { return String.Concat(LastName, " ", FirstName); } }
        [NotMapped]
        public string ClientRef { get { return String.Concat(AccountNumber, "-", LastName, " ", FirstName); } }
        [NotMapped]
        [DisplayName("Document Type")]
        public int DocumentTypeID { get; set; }

        [NotMapped]
        [DisplayName("Contact Type")]
        public int ContactTypeID { get; set; }

        [NotMapped]
        public int ClientProductID { get; set; }

        [NotMapped]
        [DisplayName("Relationship Type")]
        public int RelationshipTypeID { get; set; }

        [NotMapped]
        public int CourseID { get; set; }

        [NotMapped]
        [DisplayName("Product Type")]
        public int ProductID { get; set; }

        [NotMapped]
        public int TransactionTypeID { get; set; }
        [NotMapped]
        [DisplayName("Current Class ")]
        public int SchoolClassID { get; set; }
        [NotMapped]
        [DisplayName("Co-Curricular Activity")]
        public int ActivityID { get; set; }
        [NotMapped]
        [DisplayName("Assignment")]
        public int ClassAssignmentID { get; set; }
        [NotMapped]
        [DisplayName("Bank Account")]
        public int BankAccountID { get; set; }

        [NotMapped]
        public DateTime StartDate { get; set; }
        [NotMapped]
        public DateTime EndDate { get; set; }
        [NotMapped]
        public string SalaryAmount { get; set; }




    }

}
