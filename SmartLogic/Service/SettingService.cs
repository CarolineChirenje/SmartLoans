using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartDataAccess;
using SmartDomain;
using SmartHelper;
using CustomSetting = SmartDomain.CustomSetting;

namespace SmartLogic
{
    public class SettingService : ISettingService
    {
        private readonly DatabaseContext _context;
        private readonly ICustomSettingsService _settingService = new CustomSettingsService();
        public SettingService(DatabaseContext context) => _context = context;
        public List<ContactType> GetContactTypes() => _context.ContactTypes.Where(x => x.IsActive).ToList();
        public List<RelationshipType> GetRelationshipTypes() => _context.RelationshipTypes.Where(x => x.IsActive).ToList();
        public List<BankAccountType> GetBankAccountTypes() => _context.BankAccountTypes.Where(x => x.IsActive).ToList();
        public List<Currency> GetCurrencies() => _context.Currencies.Where(x => x.IsActive).ToList();
        public List<DocumentFormat> GetDocumentFormats() => _context.DocumentFormats.Where(x => x.IsActive).ToList();
        public List<Frequency> GetFrequencyList() => _context.Frequencies.Where(x => x.IsActive).ToList();
        public List<StatementList> GetStatementList() => _context.StatementLists.ToList();
        public Product FindProduct(int id)
        {
            return _context.Products.Find(id);

        }
        public Company FindDefaultCompany()
        {

            return _context.Companies.Where(c => c.IsDefault).FirstOrDefault();
        }
        public DocumentType FindDocumentTypes(int DocumentTypeID)
        {
            return _context.DocumentTypes.
                                    Include(df => df.DocumentFormat).
                      Where(r => r.DocumentTypeID == DocumentTypeID).FirstOrDefault();

        }

        public List<TransactionType> GetActiveTransactionTypeList() => _context.TransactionType.Where(T => T.IsActive && T.TransactionTypeID != (int)TransactionTypeList.Reversal).ToList();
        public List<CustomSettingType> GetCustomSettingsTypes() => _context.CustomSettingTypes.Where(x => x.IsActive).ToList();

        public List<CustomVariableType> GetCustomVariableTypes() => _context.SystemVariableTypes.Where(x => x.IsActive).ToList();

        public List<PriorityRank> GetPriorityRanks() => _context.PriorityRanks.Where(x => x.IsActive).ToList();


        public List<Product> GetActiveProductList()

        {
            return _context.Products.Where(p => p.IsActive)
             .AsNoTracking()
            .ToList();
        }
        public List<Course> GetActiveCourseList()

        {
            return _context.Courses.Where(p => p.IsActive)
             .AsNoTracking()
            .ToList();
        }


        public List<Gender> GenderList() => _context.Genders.Where(x => x.IsActive).ToList();

        public List<Course> GetCourseList() => _context.Courses.Where(x => x.IsActive).ToList();

        public List<Country> GetCountryList() => _context.Countries.Where(x => x.IsActive).ToList();

        public List<DocumentType> GetDocumentTypes() => _context.DocumentTypes.Where(x => x.IsActive).ToList();

        public List<WeekDay> GetWeekDays()
        {
            return _context.WeekDays
                       .AsNoTracking()
          .ToList();
        }
        public List<User> GetInstructors() => _context.Users
        .Include(ur => ur.UserRoles).Where(x => x.IsActive).ToList();

        public Custom DocumentFormatMatch(string documentFormat, int DocumentTypeID)
        {
            DocumentType documentType = FindDocumentTypes(DocumentTypeID);
            int documentFormatID = documentType.DocumentFormatID;
            bool isMatch = false;
            var enumDisplayStatus = (DocumentFormatList)documentFormatID;
            string documentFormatValue = enumDisplayStatus.ToString();
            if (documentFormat.ToLower().Contains(documentFormatValue.ToLower()))
                isMatch = true;


            Custom custom = new Custom { Bool_Value = isMatch, String_Value = documentFormatValue };

            return custom;
        }
        public List<CourseOutline> GetCourseOutlines(int courseID)
        {
            return _context.CourseOutlines
           .Where(c => c.CourseID == courseID).ToList();

        }
        public List<CourseOutline> GetUserAttendedSessions(int clientid, int courseid)
        {

            var clientCourse = _context.ClientCourses.Where(c => c.ClientID == clientid && c.CourseID == courseid).FirstOrDefault();
            int _ClientCourseID = 0;
            if (UtilityService.IsNotNull(clientCourse))
                _ClientCourseID = clientCourse.ClientCourseID;

            IEnumerable<int> courseOutlines = from c in _context.ClientTranscripts
                                              where c.ClientCourseID == _ClientCourseID
                                              select c.CourseOutlineID;
            return _context.CourseOutlines
           .Where(c => courseOutlines.Contains(c.CourseOutlineID)).ToList();

        }

        public List<Assert> GetAssertsLinkedToProduct(int productID)
        {
            IEnumerable<int> asserts = from a in _context.ProductAsserts
                                       where a.ProductID == productID
                                       select a.AssertID;

            return _context.Asserts.Where(a => asserts.Contains(a.AssertID) && a.IsActive).ToList();

        }


        public List<AssertCategory> GetAssertCategory(int assertID)
        {
            var categories = _context.AssertCategories.Where(a => a.AssertID == assertID && a.IsActive).AsNoTracking().ToList();
            return categories;
        }


        public List<Assert> GetAssertsList() => _context.Asserts.ToList();

        public List<AssertCategory> GetAssertCategoryList()
        {
            var categories = _context.AssertCategories.AsNoTracking().ToList();
            return categories;
        }
        public List<Titles> GetTitles()
        {
            var titles = _context.Titles.Where(t => t.IsActive).AsNoTracking().ToList();
            return titles;
        }

        public List<ClientAccountType> GetClientAccountTypes()
        {
            var accountTypes = _context.ClientAccountTypes.Where(cat=>cat.IsActive).AsNoTracking().ToList();
            return accountTypes;
        }
    }
}
