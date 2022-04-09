using SmartDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartInterfaces
{
    public class Beneficiaries
    {

        public LoanForm LoanForm { get; set; }
        public BeneficiaryList BeneficaryForm { get; set; }
        public List<BeneficiaryList> BeneficiaryList { get; set; }
    }
    public class Beneficiary
    {

        public LoanForm LoanForm { get; set; }
        public BeneficiaryList BeneficiaryDetail { get; set; }
    }
    public class LoanForm
    {
        public int LoanID { get; set; }
        public int ClientID { get; set; }
        public string LoanType { get; set; }
        public string Applicant { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string LoanRef { get; set; }
        public string LoanStatus { get; set; }
        public int GenderID { get; set; }

        public bool IsActive { get; set; }

    }
    public class BeneficiaryList:ChangeAudit
    {
        public int BeneficiaryID { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string IDNumber { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        public int RelationshipTypeID { get; set; }
        public int GenderID { get; set; }

        public string Gender { get; set; }
        public int CategoryItemID { get; set; }
        public int SubCategoryID { get; set; }
        public int CategoryID { get; set; }

    }
    public class LoanList
    {
        public LoanForm LoanForm { get; set; }
    }
    public class LoanDocs
    {
        public int LoanID { get; set; }
        public int DocumentTypeID { get; set; }
        public LoanForm LoanForm { get; set; }
        public List<LoanDocumentList> DocumentList { get; set; }
    }
    public class LoanDocumentList
    {
        public int LoanID { get; set; }
        public int LoanDocumentID { get; set; }
        public string DocumentTitle { get; set; }
        public string DateUploaded { get; set; }
        public string UploadedBy { get; set; }
        public byte[] FileBytes { get; set; }
        public string FileType { get; set; }
        public string FileName { get; set; }

        public string FileFullName { get; set; }

    }
    public class LoanComments
    {
        public int LoanID { get; set; }
        public LoanForm LoanForm { get; set; }
        public List<LoanCommentsList> CommentsList { get; set; }
    }

    public class LoanCommentsList
    {
        public int LoanID { get; set; }
        public int LoanNoteID { get; set; }
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

}
