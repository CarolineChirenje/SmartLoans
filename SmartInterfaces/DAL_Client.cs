using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartInterfaces
{
    public class ClientList
    {
        public int ClientID { get; set; }
        public int TitleID { get; set; }
        public string AccountType { get; set; }
        public string Affiliation { get; set; }
        public string Status { get; set; }
        public string Initials { get; set; }
        public string LastName { get; set; }
        public string PrimaryApplicantName { get { return String.Concat(((Title)TitleID).ToString(), " ", Initials, " ", LastName); } }
        public string AccountNumber { get; set; }
        public int ApplicantTitleID { get; set; }
        public bool IsJointAccount { get; set; }
        public string JointApplicantInitials { get; set; }
        public string JointApplicantLastName { get; set; }
        public string ClientRef { get { return String.Concat(AccountNumber, "-", ClientFullName); } }
        public string CoApplicantSalutation { get { return IsJointAccount ? String.Concat(((Title)ApplicantTitleID).ToString(), " ", JointApplicantInitials, " ", JointApplicantLastName) : ""; } }
        public string ClientFullName { get { return IsJointAccount ? (String.Concat(PrimaryApplicantName, (IsJointAccount ? $" & {CoApplicantSalutation}" : ""))) : PrimaryApplicantName; } }

    }
    public class PersonalDetails
    {
        [Required]
        public string Initials { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string IDNumber { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        [ForeignKey("CountryID")]
        public int? CountryID { get; set; }
        [NotMapped]
        public string Country { get; set; }
    }


    public class ClientForm : PersonalDetails
    {
        public int ClientID { get; set; }
        public string AccountNumber { get; set; }
        public int TitleID { get; set; }
        public int GenderID { get; set; }
        public int ClientGroupID { get; set; }
        public int? CompanyID { get; set; }
        public int? DepartmentID { get; set; }
        public int ClientAccountTypeID { get; set; }
        public string Occupation { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [DefaultValue("0.00")]
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        public string UserName { get; set; }
        public DateTime RegistrationDate { get; set; }
        [ReadOnly(true)]
        [DataType(DataType.DateTime)]
        [DisplayName("Last Changed Date")]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd HH:mm}")]
        public DateTime LastChangedDate { get; set; }
        [ReadOnly(true)]
        [DisplayName("Last Changed By")]
        public string LastChangedBy { get; set; }
        public JointApplicantForm JointApplicant { get; set; }
        [NotMapped]
        public bool IsJointAccount { get; set; }
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
        public bool ShowClientButtons { get; set; } = false;
    }

  
    public class ClientPeek
    {
        public int ClientID { get; set; }
        public string AccountNumber { get; set; }
        [Required]
        public string Initials { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string IDNumber { get; set; }
        public string EmailAddress { get; set; }
      
    }
    public class JointApplicantForm : PersonalDetails
    {
        public int JointApplicantID { get; set; }
        public int ClientID { get; set; }
        public int ApplicantTitleID { get; set; }
        public int ApplicantGenderID { get; set; }
        public int RelationshipTypeID { get; set; }
        public int RecordStatusID { get; set; }
        [ReadOnly(true)]
        [DataType(DataType.DateTime)]
        [DisplayName("Last Changed Date")]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd HH:mm}")]
        public DateTime LastChangedDate { get; set; }
        [ReadOnly(true)]
        [DisplayName("Last Changed By")]
        public string LastChangedBy { get; set; }
    }
    public class Contact
    {
        public ClientContact ClientContact { get; set; }
        public ClientForm ClientForm { get; set; }
    }
    public class Contacts
    {
        public int ClientID { get; set; }
        public int ContactTypeID { get; set; }
        public int RelationshipTypeID { get; set; }
        public ClientForm ClientForm { get; set; }
        public List<ContactList> ContactLists { get; set; }
    }

  
    public class CategoryAmount
    {
        public int CategoryID { get; set; }
        public string Category { get; set; }
        public decimal? TotalAmount { get; set; }
    }
    
    
    public class ContactList
    {
        public int ClientID { get; set; }
        public int ClientContactID { get; set; }
        public string Relationship { get; set; }
        public string ContactType { get; set; }
        public string ContactPerson { get; set; }
        public string Information { get; set; }
    }
    public class Comments
    {
        public int ClientID { get; set; }
        public ClientForm ClientForm { get; set; }
        public List<CommentsList> CommentsList { get; set; }
    }

    public class CommentsList
    {
        public int ClientID { get; set; }
        public int ClientNoteID { get; set; }
        public string Comment { get; set; }
        public UserType UserTypeID { get; set; }
        public string DateUploaded { get; set; }
        public string DateClosed { get; set; }
        public string DueDate { get; set; }
        public string UploadedBy { get; set; }
        public bool VisibleToAdminOnly { get; set; }
        public string LastChangedDate { get; set; }
        public string LastChangedBy { get; set; }
        public string UserTypeName { get; set; }

    }

    public class Dependents
    {
        public int ClientID { get; set; }
        public int GenderID { get; set; }
        public ClientForm ClientForm { get; set; }
        public List<DependentsList> DependentsList { get; set; }
    }

    public class DependentsList
    {
        public int ClientID { get; set; }
        public int ClientDependentID { get; set; }
        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public string Occupation { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }

    }


  

    public class Docs
    {
        public int ClientID { get; set; }
        public int DocumentTypeID { get; set; }
        public ClientForm ClientForm { get; set; }
        public List<DocumentList> DocumentList { get; set; }
    }

    public class DocumentList
    {
        public int ClientID { get; set; }
        public int ClientDocumentID { get; set; }
        public string DocumentTitle { get; set; }
        public string DateUploaded { get; set; }
        public string UploadedBy { get; set; }
        public byte[] FileBytes { get; set; }
        public string FileType { get; set; }
        public string FileName { get; set; }

        public string FileFullName { get; set; }

    }

   
    public class Transactions
    {
        public int ClientID { get; set; }
        public int TransactionID { get; set; }
        public ClientForm ClientForm { get; set; }
        public List<TransactionList> TransactionList { get; set; }
    }

    public class TransactionList
    {
        public int ClientID { get; set; }
        public int TransactionID { get; set; }
        public string TransRef { get; set; }
        public string TransType { get; set; }
        public string Entity { get; set; }

        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public string PaymentStatus { get; set; }
        public string PaymentDate { get; set; }
        public string TransactionDatePaid { get; set; }
    }

    public class PendingTransactions
    {
        public int ClientID { get; set; }

        public string CutOffDate { get; set; }
        public ClientForm ClientForm { get; set; }
        public List<PendingTransactionList> ProductPayments { get; set; }
        public List<PendingTransactionList> CoursePayments { get; set; }
    }

    public class PendingTransactionList
    {
        public int ClientID { get; set; }
        public int ClientFeeID { get; set; }
        public int ProductID { get; set; }
        public int ClientProductID { get; set; }
        public int ProductFeeID { get; set; }
        public int CourseID { get; set; }
        public int ClientCourseID { get; set; }
        public int CourseFeeID { get; set; }
        public string FeeName { get; set; }
        public string Entity { get; set; }
        public decimal Amount { get; set; }
        public string PaymentTerms { get; set; }
        public string DueDate { get; set; }


    }
   

    public class InvoiceList
    {
        public int ClientID { get; set; }
        public int InvoiceID { get; set; }
        public int InvoiceDetailID { get; set; }
        public string Occupation { get; set; }
        public string InvoiceNumber { get; set; }
        public decimal Amount { get; set; }
        public decimal Salary { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string DueDate { get; set; }
        public string InvoiceDate { get; set; }
        public string Status { get; set; }
     
    }

    public class ClientLoans
    {
        public int ClientID { get; set; }
        public List<Loan> Loans { get; set; }
    }

    public class SalaryHistory
    {
        public int ClientID { get; set; }
        public ClientForm ClientForm { get; set; }
        public List<SalaryHistoryList> SalaryHistoryList { get; set; }
    }

    public class SalaryHistoryList
    {
        public string Occupation { get; set; }
        public decimal Salary { get; set; }
        public string LastChangedDate { get; set; }
        public string LastChangedBy { get; set; }
    }
}
