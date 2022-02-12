

using Microsoft.EntityFrameworkCore;
using SmartDataAccess;
using SmartDomain;
using SmartHelper;
using SmartLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SmartLogic
{
    public class EmailTemplateService : IEmailTemplateService
    {
        private readonly DatabaseContext _context;

        public EmailTemplateService(DatabaseContext context) => _context = context;

        public async Task<EmailTemplate> FindEmailTemplate(int id = 0) => await GetEmailTemplate(id);
        public async Task<EmailTemplate> GetEmailTemplate(int EmailTypeID)
        {
            try
            {

                        return await _context.EmailTemplates
               .Where(r => r.EmailTypeID == EmailTypeID)
               .Include(m => m.EmailType)
               .AsNoTracking().FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
     

        public async Task<List<EmailTemplate>> EmailTemplates()
        {
            try
            {

                        return await _context.EmailTemplates
                         .Include(m => m.EmailType)
                        .AsNoTracking()
            .ToListAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }



        public async Task<int> Update(EmailTemplate update)
        {
            try
            {

                        update.LastChangedBy = UserAppData.CurrentUserName;
            update.LastChangedDate = DateTime.Now;
            _context.Update(update);
            return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> Save(EmailTemplate EmailTemplate)
        {
            try
            {

                       EmailTemplate.LastChangedBy = UserAppData.CurrentUserName;
            EmailTemplate.LastChangedDate = DateTime.Now;
            _context.Add(EmailTemplate);
            return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
     

        public async Task<int> ActionEmailTemplate(int EmailTemplateID, DatabaseAction action)
        {
            try
            {

                        EmailTemplate EmailTemplate = await GetEmailTemplate(EmailTemplateID);

            if (DatabaseAction.Remove == action)
                _context.EmailTemplates.Remove(EmailTemplate);
          
            return (await _context.SaveChangesAsync());
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }



        public List<EmailType> EmailTypes()
        {
            try
            {

                        return _context.EmailTypes
           .AsNoTracking()
             .ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public List<Company> Companies()
        {
            try
            {

                        return _context.Companies.Where(c=>c.IsActive)
           .AsNoTracking()
             .ToList();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
    }
}

