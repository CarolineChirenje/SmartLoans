using System;
using System.Collections.Generic;
using System.Text;
using SmartDomain;
using SmartInterfaces;

namespace SmartLogic
{

    public interface ISettingService
    {

        List<ContactType> GetContactTypes();
        List<RelationshipType> GetRelationshipTypes();
        List<CustomVariableType> GetCustomVariableTypes();
        List<PriorityRank> GetPriorityRanks();
        List<Gender> GenderList();
        List<Product> GetActiveProductList();
        List<TransactionType> GetActiveTransactionTypeList();
      
        Product FindProduct(int productid);
        Company FindDefaultCompany();
        List<Company> GetCompanies(bool activeOnly = false);
        List<StatementList> GetStatementList();
        List<WeekDay> GetWeekDays();
        List<DocumentType> GetDocumentTypes();
        DocumentType FindDocumentTypes(int DocumentTypeID);
        Custom DocumentFormatMatch(string documentFormat, int DocumentTypeID);
        List<BankAccountType> GetBankAccountTypes();
        List<Currency> GetCurrencies();

        List<ProductComputation> GetProductComputations();
        List<DocumentFormat> GetDocumentFormats();
        List<Country> GetCountryList();
        List<Fee> GetFeeList();
        List<CalculationType> GetCalculationTypeList();

        List<Titles> GetTitles();
        List<ClientAccountType> GetClientAccountTypes();
        List<ClientGroup> GetAffiliations();

        List<LoanUse> GetLoanUses();
        List<LoanType> GetLoanTypes();
        List<LoanStatus> GetLoanStatus();
        List<LoanSector> GetLoanSectors();


        List<Category> GetCategories();
        List<SubCategory> GetSubCategories();
        List<CategoryItem> GetCategoryItems();
       

    }


}
