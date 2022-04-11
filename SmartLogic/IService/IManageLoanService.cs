using SmartDomain;
using SmartHelper;
using SmartInterfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace SmartLogic
{
    public interface IManageLoanService
    {

        Task<int> Delete(int id);
        Task<int> Save(Loan Loan);
        Task<int> Update(Loan Loan);
        Task<int> ActionLoan(int loanid, DatabaseAction action);
        Task<Loan> FindLoan(int loanid);
        Task<int> ChangeLoanStatus(int LoanID, int StatusID);

        Task<int> FinaliseLoan(int LoanID);
        Task<List<LoanForm>> GetLoans(string loanref = null, bool newLoansOnly = false, int companyID = 0);
        Task<List<Loan>> Loans();

        Beneficiaries LoanBeneficiaries(int loanID);
        Task<Beneficiary> FindLoanBeneficiary(int id);
        Task<int> Save(LoanBeneficiary beneficiary);
        Task<int> Update(LoanBeneficiary beneficiary);
        Task<int> ActionDependent(int id, DatabaseAction action);

        //Document
        LoanDocs LoanDocuments(int loanID);
        Task<LoanDocument> FindDocument(int id);
        Task<int> Save(LoanDocument document);
        Task<int> Update(LoanDocument document);
        Task<int> ActionDocument(int id, DatabaseAction action);
        Task<bool> DocumentUploaded(int loanid, int documentTypeID);

        //Notes
        LoanComments LoanNotes(int loanID);
        Task<LoanNote> FindNote(int id);
        Task<int> Save(LoanNote note);
        Task<int> Update(LoanNote note);
        Task<int> ActionNote(int id, DatabaseAction action);


        Task<int> Save(LoanFinance loanFinance);
        Task<int> RejectLoan(LoanNote note);


    }
}


