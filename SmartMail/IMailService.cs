using SmartDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartMail
{
    public interface IMailService
    {
        bool SendMail(Email email, bool sendAsync = false);
    }
}
