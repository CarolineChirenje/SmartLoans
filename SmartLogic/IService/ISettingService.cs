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
        List<FundSource> GetActiveFundSource();
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
        List<DocumentFormat> GetDocumentFormats();
        List<Country> GetCountryList();
        List<Frequency> GetFrequencyList();

        List<Titles> GetTitles();
        List<ClientAccountType> GetClientAccountTypes();
        List<ClientGroup> GetAffiliations();

    }


}
