﻿using SmartDomain;
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
        public string UserName { get; set; }
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

        public virtual JointApplicant JointApplicant { get; set; }
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
        public List<AttendanceRegisterDetail> AttendanceRegister { get; set; }
        public virtual List<ClientOccupationHistory> ClientOccupationHistory { get; set; }
        [NotMapped]
        public bool IsJointAccount { get { return ClientAccountTypeID == (int)Client_AccountType.Joint; } }
        [NotMapped]
        public int StatementID { get; set; }
        [NotMapped]
        public virtual Statement Statement { get; set; }

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
        public int CourseIntakeID { get; set; }

        [NotMapped]
        [DisplayName("Product Type")]
        public int ProductID { get; set; }

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
        public string ClientRef { get { return String.Concat(AccountNumber, "-", LastName, " ", FirstName); } }

        [NotMapped]
        public string CoApplicantSalutation { get { return JointApplicant != null ? String.Concat(((Title)JointApplicant.ApplicantTitleID).ToString(), " ", JointApplicant.Initials, " ", JointApplicant.LastName) : ""; } }
        [NotMapped]
        public string ClientFullName { get { return IsJointAccount ? (String.Concat(PrimaryApplicantName, (JointApplicant != null ? $" & {CoApplicantSalutation}" : ""))) : PrimaryApplicantName; } }
        [NotMapped]
        public int JointAccountEnumValue { get { return (int)Client_AccountType.Joint; } }
        
    }

}
