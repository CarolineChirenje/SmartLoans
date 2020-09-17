using System;
using System.Collections.Generic;
using System.Text;
using SmartDomain;
namespace SmartLogic
{

    public interface ISettingService
    {
       
        List<ContactType> GetContactTypes();
        List<RelationshipType> GetRelationshipTypes();

        List<CustomSelectList> GetYears();
        List<CustomSettingType> GetCustomSettingsTypes();
        List<CustomVariableType> GetCustomVariableTypes();
        List<PriorityRank> GetPriorityRanks();
        List<Gender> GenderList();
        List<Product> GetActiveProductList();
        List<Course> GetActiveCourseList();
        Product FindProduct(int productid);

        List<WeekDay> GetWeekDays();
        List<Course> GetCourseList();
        List<DocumentType> GetDocumentTypes();
        DocumentType FindDocumentTypes(int DocumentTypeID);
        Custom DocumentFormatMatch(string documentFormat, int DocumentTypeID);

        List<User> GetInstructors();
        List<BankAccountType> GetBankAccountTypes();
        List<Currency> GetCurrencies();
        List<DocumentFormat> GetDocumentFormats();


    }


}
