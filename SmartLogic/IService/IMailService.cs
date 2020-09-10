using SmartDomain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLogic
{
    public interface IMailService
    {
        bool SendMail(Email email);
    }
}
