using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartDataAccess;
using SmartDomain;
using SmartHelper;
using SmartLog;
using CustomSetting = SmartDomain.CustomSetting;

namespace SmartLogic
{
    public class SettingService : ISettingService
    {
        private readonly DatabaseContext _context;
        private readonly ICustomSettingsService _settingService = new CustomSettingsService();
        public SettingService(DatabaseContext context)
        {
            _context = context;
        }

        public List<ContactType> GetContactTypes()
        {
            try
            {

                return _context.ContactTypes.Where(x => x.IsActive).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<RelationshipType> GetRelationshipTypes()
        {
            try
            {

                return _context.RelationshipTypes.Where(x => x.IsActive).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<BankAccountType> GetBankAccountTypes()
        {
            try
            {

                return _context.BankAccountTypes.Where(x => x.IsActive).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<Currency> GetCurrencies()
        {
            try
            {

                return _context.Currencies.Where(x => x.IsActive).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<DocumentFormat> GetDocumentFormats()
        {
            try
            {

                return _context.DocumentFormats.Where(x => x.IsActive).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<Frequency> GetFrequencyList()
        {
            try
            {

                return _context.Frequencies.Where(x => x.IsActive).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<StatementList> GetStatementList()
        {
            try
            {

                return _context.StatementLists.ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public Product FindProduct(int id)
        {
            try
            {

                return _context.Products.Find(id);

            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public Company FindDefaultCompany()
        {
            try
            {


                return _context.Companies.Where(c => c.IsDefault).FirstOrDefault();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public DocumentType FindDocumentTypes(int DocumentTypeID)
        {
            try
            {

                return _context.DocumentTypes.
                             Include(df => df.DocumentFormat).
               Where(r => r.DocumentTypeID == DocumentTypeID).FirstOrDefault();

            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<TransactionType> GetActiveTransactionTypeList()
        {
            try
            {

                return _context.TransactionType.Where(T => T.IsActive && T.TransactionTypeID != (int)TransactionTypeList.Reversal).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<CustomSettingType> GetCustomSettingsTypes()
        {
            try
            {

                return _context.CustomSettingTypes.Where(x => x.IsActive).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<CustomVariableType> GetCustomVariableTypes()
        {
            try
            {


                return _context.SystemVariableTypes.Where(x => x.IsActive).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<PriorityRank> GetPriorityRanks()
        {
            try
            {

                return _context.PriorityRanks.Where(x => x.IsActive).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<Product> GetActiveProductList()

        {
            try
            {

                return _context.Products.Where(p => p.IsActive)
      .AsNoTracking()
     .ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public List<Course> GetActiveCourseList()

        {
            try
            {

                return _context.Courses.Where(p => p.IsActive)
      .AsNoTracking()
     .ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public List<Gender> GenderList()
        {
            try
            {

                return _context.Genders.Where(x => x.IsActive).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<Course> GetCourseList()
        {
            try
            {


                return _context.Courses.Where(x => x.IsActive).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<Country> GetCountryList()
        {
            try
            {

                return _context.Countries.Where(x => x.IsActive).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<DocumentType> GetDocumentTypes()
        {
            try
            {

                return _context.DocumentTypes.Where(x => x.IsActive).ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<WeekDay> GetWeekDays()
        {
            try
            {

                return _context.WeekDays
               .AsNoTracking()
  .ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public List<User> GetInstructors() => _context.Users
        .Include(ur => ur.UserRoles).Where(x => x.IsActive).ToList();

        public Custom DocumentFormatMatch(string documentFormat, int DocumentTypeID)
        {
            try
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
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public List<CourseOutline> GetCourseOutlines(int courseID)
        {
            try
            {

                return _context.CourseOutlines
   .Where(c => c.CourseID == courseID).ToList();

            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public List<CourseOutline> GetUserAttendedSessions(int clientid, int courseid)
        {
            try
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
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<Assert> GetAssertsLinkedToProduct(int productID)
        {
            try
            {

                IEnumerable<int> asserts = from a in _context.ProductAsserts
                                           where a.ProductID == productID
                                           select a.AssertID;

                return _context.Asserts.Where(a => asserts.Contains(a.AssertID) && a.IsActive).ToList();

            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public List<AssertCategory> GetAssertCategory(int assertID)
        {
            try
            {

                var categories = _context.AssertCategories.Where(a => a.AssertID == assertID && a.IsActive).AsNoTracking().ToList();
                return categories;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public List<Assert> GetAssertsList()
        {
            try
            {
                return _context.Asserts.ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<AssertCategory> GetAssertCategoryList()
        {
            try
            {

                var categories = _context.AssertCategories.AsNoTracking().ToList();
                return categories;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public List<Titles> GetTitles()
        {
            try
            {


                var titles = _context.Titles.Where(t => t.IsActive).AsNoTracking().ToList();
                return titles;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<ClientAccountType> GetClientAccountTypes()
        {
            try
            {

                var accountTypes = _context.ClientAccountTypes.Where(cat => cat.IsActive).AsNoTracking().ToList();
                return accountTypes;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<CourseIntake> GetCourseIntakes(bool activeOnly = false)
        {
            try
            {

                var courseIntakes = _context.CourseIntakes.AsNoTracking().ToList();
                if (activeOnly)
                    courseIntakes = courseIntakes.Where(ci => ci.IsActive).ToList();
                return courseIntakes;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
    }
}
