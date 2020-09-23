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

        Task<string> ResetPassword(string emailaddress, bool isAccountCreation=false);
        Task<UserAuthenticationCode> ConfirmCode(string  code, bool isAccountCreation = false);
        Task<int> PasswordChange( int userid, string password);
        Task<bool> UserAccountExists(string emailaddress, string idnumber);
    }
}
