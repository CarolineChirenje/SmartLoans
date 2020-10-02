﻿using System;
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
        List<TransactionType> GetActiveTransactionTypeList();
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
        List<Country> GetCountryList();
        List<Frequency> GetFrequencyList();

        List<CourseOutline> GetCourseOutlines(int courseID);
        List<CourseOutline> GetUserAttendedSessions(int clientid, int courseid);

        List<Assert> GetAssertsLinkedToProduct(int productID);
        List<AssertCategory> GetAssertCategory(int assertID);

    }


}
