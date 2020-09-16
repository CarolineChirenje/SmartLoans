using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace SmartLogic
{
    public interface IEmailTemplateService
    {

       
        Task<int> Save(EmailTemplate EmailTemplate);
        Task<int> Update(EmailTemplate EmailTemplate);
        Task<int> ActionEmailTemplate(int EmailTemplateId, DatabaseAction action);
        Task<EmailTemplate> GetEmailTemplate(int EmailTemplateId);

        Task<EmailTemplate> FindEmailTemplate(int EmailTemplateId = 0);
        Task<List<EmailTemplate>> EmailTemplates();
        List<EmailType> EmailTypes();
       

    }
}


