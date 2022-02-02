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
        AuthenticateResult GeneratePinCode(UserAuthenticate userAuthenticate);
        Task<UserAuthenticationCode> ConfirmCode(UserAuthenticate userAuthenticate);
        Task<int> PasswordChange( int userid, string password);
        Task<bool> UserAccountExists(string emailaddress, string idnumber);
    }
}
