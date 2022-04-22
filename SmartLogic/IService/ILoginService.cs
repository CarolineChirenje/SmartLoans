using SmartDomain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SmartLogic
{
    public interface ILoginService
    {
        Task<User> Login(string username, string password);

        Task<User> GetUser(int userid);
        AuthenticateResult GeneratePinCode(UserAuthenticate userAuthenticate);
        Task<UserAuthenticationCode> ConfirmCode(UserAuthenticate userAuthenticate);
        Task<int> PasswordChange(int userid, string password);
        Task<bool> UserAccountExists(string emailaddress, string idnumber);
        bool HasAccount(string emailaddress);
        bool HasAccessToSite(string emailaddress);
    }
}
