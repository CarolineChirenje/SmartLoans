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
        List<Course> GetActiveCourseList();
        Product FindProduct(int productid);
        Company FindDefaultCompany();
        List<Company> GetCompanies(bool activeOnly=false);
        List<StatementList> GetStatementList();
        List<WeekDay> GetWeekDays();
        List<Course> GetCourseList();
        List<DocumentType> GetDocumentTypes();
        DocumentType FindDocumentTypes(int DocumentTypeID);
        Custom DocumentFormatMatch(string documentFormat, int DocumentTypeID);

        List<User> GetInstructors();
        List<BankAccountType> GetBankAccountTypes();
        List<Currency> GetCurrencies();
        List<DocumentFormat> GetDocumentFormats();
        List<Country> GetCountryList();
        List<Frequency> GetFrequencyList();

        List<CourseTopic> GetCourseOutlines(int courseID);
        List<CourseBreakDown> GetCourseBreakDown(int courseID);
        List<CourseSession> GetUserAttendedSessions(int clientid, int courseid);
        decimal GetTransactionFee(int productID);
        List<Assert> GetAssertsLinkedToProduct(int productID);
        List<AssertCategory> GetAssertCategory(int assertID);
        List<Assert> GetAssertsList();
        List<AssertCategory> GetAssertCategoryList();

        List<Titles> GetTitles();
        List<ClientAccountType> GetClientAccountTypes();
        List<CourseIntake> GetCourseIntakes(bool activeOnly=false);
        List<ClientGroup> GetAffiliations();
        
    }


}
