using SmartDomain;
using SmartHelper;
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
    public class Client : PersonalDetails
    {
        [Key]
        public int ClientID { get; set; }
        public string AccountNumber { get; set; }
        public bool IsActive { get; set; }
              public DateTime RegistrationDate { get; set; }
        public int GenderID { get; set; }
        public virtual Gender Gender { get; set; }
        [ForeignKey("TitleID")]
        public int TitleID { get; set; }
        public virtual Titles Title { get; set; }
        public int? DepartmentID { get; set; }
        public virtual Department Department { get; set; }
        public string Occupation { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [DefaultValue("0.00")]
        public decimal Salary { get; set; }
        public int ClientAccountTypeID { get; set; }
        public virtual ClientAccountType ClientAccountType { get; set; }
        public int? CompanyID { get; set; }
        public virtual Company Company { get; set; }

        public int ClientGroupID { get; set; }
        public virtual ClientGroup ClientGroup { get; set; }

        public virtual JointApplicant JointApplicant { get; set; }
        public virtual List<ClientContact> ClientContacts { get; set; }
        public virtual List<ClientDocument> ClientDocuments { get; set; }
        public virtual ICollection<Transaction> ClientPayments { get; set; }
        public virtual List<ClientNote> ClientNotes { get; set; }
      
        public virtual List<ClientDependent> ClientDependents { get; set; }
        
        public virtual List<InvoiceDetails> InvoiceDetails { get; set; }
        public virtual List<Loan> Loans { get; set; }
        public virtual List<ClientOccupationHistory> ClientOccupationHistory { get; set; }

        public List<KonapoFund> KonapoFunds { get; set; }
        [NotMapped]
        public bool IsJointAccount { get { return ClientAccountTypeID == (int)Client_AccountType.Joint; } }
        [NotMapped]
        public int StatementID { get; set; }
        //TODO: Sort Out
       // [NotMapped]
      //  public virtual Statement Statement { get; set; }

        [NotMapped]
        [DisplayName("Document Type")]
        public int DocumentTypeID { get; set; }

        [NotMapped]
        [DisplayName("Contact Type")]
        public int ContactTypeID { get; set; }

        [NotMapped]
        public int ClientProductID { get; set; }

        [NotMapped]
        public int RelationshipTypeID { get; set; }

       

        [NotMapped]
        public int ProductID { get; set; }

        [NotMapped]
        public string DeductionAmount { get; set; }

        [NotMapped]
        public string IncreamentAmount { get; set; }

        [NotMapped]
        public int TransactionTypeID { get; set; }

        [NotMapped]
        public int BankAccountID { get; set; }
        [NotMapped]
        public DateTime StartDate { get; set; }
        [NotMapped]
        public DateTime EndDate { get; set; }
        [NotMapped]
        public string SalaryAmount { get; set; }
        [NotMapped]
        public string PrimaryApplicantName { get { return String.Concat(((Title)TitleID).ToString(), " ", Initials, " ", LastName); } }
        [NotMapped]
        public string ClientRef { get { return String.Concat(AccountNumber, "-", ClientFullName); } }

        [NotMapped]
        public string CoApplicantSalutation { get { return JointApplicant != null ? String.Concat(((Title)JointApplicant.ApplicantTitleID).ToString(), " ", JointApplicant.Initials, " ", JointApplicant.LastName) : ""; } }
        [NotMapped]
        public string ClientFullName { get { return IsJointAccount ? (String.Concat(PrimaryApplicantName, (JointApplicant != null ? $" & {CoApplicantSalutation}" : ""))) : PrimaryApplicantName; } }
        [NotMapped]
        public int JointAccountEnumValue { get { return (int)Client_AccountType.Joint; } }

    }

}
