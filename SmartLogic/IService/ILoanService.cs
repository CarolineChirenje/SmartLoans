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


        Task<int> DeleteFiscal(int id);
        Task<int> Save(FiscalYear loanFiscal);
        Task<int> Update(FiscalYear loanFiscal);
        Task<bool> IsDuplicate(FiscalYear fiscalYear);
        Task<FiscalYear> FindFiscalYear(int id);
        Task<List<FiscalYear>> FiscalYears();

        Task<Category> FindCategory(int categoryID);
        Task<int> Save(Category category);
        Task<bool> IsDuplicate(Category category);
        Task<int> Update(Category category);
        Task<int> ActionCategory(int CategoryID, DatabaseAction action);
        Task<List<Category>> Categories();

        List<SubCategory> GetSubCategories(int categoryID);
        Task<SubCategory> FindSubCategory(int id);
        Task<int> Save(SubCategory subCategory);
        Task<int> Update(SubCategory subCategory);
        Task<int> ActionSubCategory(int id, DatabaseAction action);
        Task<bool> IsDuplicate(SubCategory subCategory);

        Task<CategoryItem> FindCategoryItem(int id);
        Task<CategoryItem> GetCategoryItem(int id);
        Task<int> Save(CategoryItem categoryItem);
        Task<int> Update(CategoryItem categoryItem);
        Task<int> ActionCategoryItem(int id, DatabaseAction action);
        Task<bool> IsDuplicate(CategoryItem categoryItem);


        Task<int> DeleteFee(int id);
        Task<int> Save(Fee fees);
        Task<int> Update(Fee fees);
        Task<bool> IsDuplicate(Fee fees);
        Task<Fee> FindFee(int id);
        Task<List<Fee>> Fees();


        Task<bool> IsDuplicate(ProductComputation computation);
        Task<int> DeleteProductComputation(int id);
        Task<int> Save(ProductComputation computation);
        Task<int> Update(ProductComputation computation);
              Task<ProductComputation> FindProductComputation(int id);
        Task<List<ProductComputation>> ProductComputations();
    }


}
