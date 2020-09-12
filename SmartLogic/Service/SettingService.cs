﻿using System;
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
        private readonly ICustomSettingsService _settingService= new CustomSettingsService();
        public SettingService(DatabaseContext context) => _context = context;
        public List<ContactType> GetContactTypes() => _context.ContactTypes.Where(x => x.IsActive).ToList();
        public List<RelationshipType> GetRelationshipTypes() => _context.RelationshipTypes.Where(x => x.IsActive).ToList();
        public List<BankAccountType> GetBankAccountTypes() => _context.BankAccountTypes.Where(x => x.IsActive).ToList();
        public List<Currency> GetCurrencies() => _context.Currencies.Where(x => x.IsActive).ToList();
        public List<DocumentFormat> GetDocumentFormats() => _context.DocumentFormats.Where(x => x.IsActive).ToList();

        public Product FindProduct(int id)
        {
            return _context.Products.Find(id);

        }
        public DocumentType FindDocumentTypes(int DocumentTypeID)
        {
          return  _context.DocumentTypes.
                                  Include(df =>df.DocumentFormat).
                    Where(r => r.DocumentTypeID == DocumentTypeID).FirstOrDefault();

        }
        public List<CustomSelectList> GetYears()
        {
            List<CustomSelectList>  years = new List<CustomSelectList>();
            int MinYear =Convert.ToInt32(_settingService.GetSettingValue(AppSetting.Minimum_Year));
            int MaxYear =  DateTime.Now.AddYears(1).Year;
            for (var i = MinYear; i <= MaxYear; i++)
            {
                years.Add( new CustomSelectList()
                { ID=i,
                Name=i.ToString()
               });
            }

            return years;
          
        }
        public List<CustomSettingType> GetCustomSettingsTypes() => _context.CustomSettingTypes.Where(x => x.IsActive).ToList();

        public List<CustomVariableType> GetCustomVariableTypes() => _context.SystemVariableTypes.Where(x => x.IsActive).ToList();

        public List<PriorityRank> GetPriorityRanks() => _context.PriorityRanks.Where(x => x.IsActive).ToList();


        public List<Product> GetActiveProductList()
        
        {
            return  _context.Products.Where(p=>p.IsActive)
             .AsNoTracking()
            .ToList();
        }

       
        public List<Gender> GenderList() => _context.Genders.Where(x => x.IsActive).ToList();

        public List<Course> GetCourseList() => _context.Courses.Where(x => x.IsActive).ToList();

        public List<DocumentType> GetDocumentTypes() => _context.DocumentTypes.Where(x => x.IsActive).ToList();

        public List<WeekDay> GetWeekDays()
        {
            return _context.WeekDays
                       .AsNoTracking()
          .ToList();
        }
        public List<User> GetInstructors() => _context.Users
        .Include(ur=>ur.UserRoles).Where(x => x.IsActive).ToList();

        public  Custom DocumentFormatMatch(string documentFormat, int DocumentTypeID)
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

    }
}
    