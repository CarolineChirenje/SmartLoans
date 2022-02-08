using SmartDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartMail
{
    public interface IMailService
    {
         Task<bool> SendMail(Email email);

        bool SendEmail(Email email);
    }
}
