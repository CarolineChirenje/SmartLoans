

using Microsoft.EntityFrameworkCore;
using SmartDataAccess;
using SmartDomain;
using SmartHelper;
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
        public async Task<EmailTemplate> GetEmailTemplate(int EmailTemplateID)
        {
            return await _context.EmailTemplates
               .Where(r => r.EmailTemplateID == EmailTemplateID)
               .Include(m => m.EmailType)
               .AsNoTracking().FirstOrDefaultAsync();
        }
     

        public async Task<List<EmailTemplate>> EmailTemplates()
        {
            return await _context.EmailTemplates
                         .Include(m => m.EmailType)
                        .AsNoTracking()
            .ToListAsync();
        }



        public async Task<int> Update(EmailTemplate update)
        {
            update.LastChangedBy = UtilityService.CurrentUserName;
            update.LastChangedDate = DateTime.Now;
            _context.Update(update);
            return await _context.SaveChangesAsync();
        }
        public async Task<int> Save(EmailTemplate EmailTemplate)
        {
            EmailTemplate.LastChangedBy = UtilityService.CurrentUserName;
            EmailTemplate.LastChangedDate = DateTime.Now;
            _context.Add(EmailTemplate);
            return (await _context.SaveChangesAsync());
        }
     

        public async Task<int> ActionEmailTemplate(int EmailTemplateID, DatabaseAction action)
        {
            EmailTemplate EmailTemplate = await GetEmailTemplate(EmailTemplateID);

            if (DatabaseAction.Remove == action)
                _context.EmailTemplates.Remove(EmailTemplate);
          
            return (await _context.SaveChangesAsync());
        }



        public List<EmailType> EmailTypes()
        {
            return _context.EmailTypes
           .AsNoTracking()
             .ToList();
        }

        public List<Company> Companies()
        {
            return _context.Companies.Where(c=>c.IsActive)
           .AsNoTracking()
             .ToList();
        }
    }
}

