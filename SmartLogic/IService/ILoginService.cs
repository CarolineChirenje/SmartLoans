using SmartDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogic
{
 public   interface ILoginService
    {
        Task<User> Login(string username, string password);
     

    }
}
