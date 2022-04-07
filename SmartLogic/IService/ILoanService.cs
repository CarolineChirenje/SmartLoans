using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace SmartLogic
{

    public interface ILoanService
    {
     
        Task<int> DeleteLoanSector(int id);
        Task<int> Save(LoanSector sector);
        Task<int> Update(LoanSector sector);
        Task<bool> IsDuplicate(LoanSector sector);
        Task<LoanSector> FindSector(int id);
        Task<List<LoanSector>> LoanSectors();


        Task<int> DeleteLoanType(int id);
        Task<int> Save(LoanType type);
        Task<int> Update(LoanType type);
        Task<bool> IsDuplicate(LoanType type);
        Task<LoanType> FindLoanType(int id);
        Task<List<LoanType>> LoanTypes();



        Task<int> DeleteLoanUse(int id);
        Task<int> Save(LoanUse loanUse);
        Task<int> Update(LoanUse loanUse);
        Task<bool> IsDuplicate(LoanUse loanUse);
        Task<LoanUse> FindLoanUse(int id);
        Task<List<LoanUse>> LoanUses();


        Task<int> DeleteLoanStatus(int id);
        Task<int> Save(LoanStatus loanStatus);
        Task<int> Update(LoanStatus loanStatus);
        Task<bool> IsDuplicate(LoanStatus loanStatus);
        Task<LoanStatus> FindLoanStatus(int id);
        Task<List<LoanStatus>> LoanStatuses();


        Task<int> DeleteLoanFiscal(int id);
        Task<int> Save(LoanFiscal loanFiscal);
        Task<int> Update(LoanFiscal loanFiscal);
        Task<bool> IsDuplicate(LoanFiscal loanFiscal);
        Task<LoanFiscal> FindLoanFiscal(int id);
        Task<List<LoanFiscal>> LoanFiscals();


    }


}
