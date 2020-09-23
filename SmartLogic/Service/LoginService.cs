using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartDataAccess;
using SmartDomain;
using SmartHelper;

namespace SmartLogic
{
    public class LoginService : ILoginService
    {
        private readonly DatabaseContext _context;

        public LoginService()
        {

        }

        public LoginService(DatabaseContext context) => _context = context;

        

        public async Task<User> Login(string username, string password)
        {
            string encryptedPassword = Encryption.Encrypt(password);
            return await _context.Users.FirstOrDefaultAsync(u => u.EmailAddress == username &&
             u.Password == encryptedPassword);

        }

        #region PinCode
        public string NewPinCode
        {
            get
            {
                return GeneratePinCode();
            }
        }



        private bool PinCodeExists(string pincode)
        {
            return _context.UserAuthenticationCodes.Any(p => p.PinCode.Equals(pincode));
        }

        string GeneratePinCode()
        {
            
            string pincode = Encryption.Encrypt(UtilityService.GenerateRandomNumbers(UtilityService.PinCodeLength).ToString());
            
            if (PinCodeExists(pincode))
                return GeneratePinCode();

            else
                return pincode;
        }



        #endregion PinCode
        public async Task<string> ResetPassword(string emailaddress, bool isAccountCreation)
        {
            Client client=new Client();
            User user = new User();
            if (isAccountCreation) {
                client = await _context.Clients.FirstOrDefaultAsync(u => u.EmailAddress.Equals(emailaddress));
                if (UtilityService.IsNull(client))
                    return "";
            }
            else
            {
          user  = await _context.Users.FirstOrDefaultAsync(u => u.EmailAddress.Equals(emailaddress));
                if (UtilityService.IsNull(user))
                    return "";
            }
            string encryptedPinCode = NewPinCode;
            UserAuthenticationCode pin = new UserAuthenticationCode();
            pin.UserID = isAccountCreation? client.ClientID  : user.UserID;
            pin.DateRequested = DateTime.Now;
            pin.PinCode = encryptedPinCode;
            pin.ExpiryDate = pin.DateRequested.AddDays(UtilityService.PinCodeValidityPeriod);
            pin.IsAccountCreation = isAccountCreation;
            _context.UserAuthenticationCodes.Add(pin);
             await _context.SaveChangesAsync();

            return encryptedPinCode;
        }
        public async Task<bool> UserAccountExists(string emailaddress, string idnumber)
        {

            var user = _context.Users.Where(u => u.EmailAddress.Equals(emailaddress) && u.IDNumber.Equals(idnumber)).FirstOrDefault();
            return UtilityService.IsNotNull(user);
            }

        public async Task<UserAuthenticationCode> ConfirmCode(string code, bool isAccountCreation)
        {
            string encryptedPinCode = Encryption.Encrypt(code);
            UserAuthenticationCode pinReset = await _context.UserAuthenticationCodes
                        .FirstOrDefaultAsync(u => u.PinCode.Equals(encryptedPinCode) && u.IsAccountCreation==isAccountCreation);
           
            return pinReset;
        }
        public async Task<int> PasswordChange(int userid, string password)
        {
            string encryptedPassword = Encryption.Encrypt(password);
            User user = await _context.Users
                        .FirstOrDefaultAsync(u => u.UserID==userid);

            if (UtilityService.IsNull(user))
                return 0;
            user.Password = encryptedPassword;
            user.LastChangedBy = UtilityService.CurrentUserName;
            user.PasswordExpiryDate = DateTime.Now.AddDays(UtilityService.PasswordValidityPeriod);
            user.LastChangedDate = DateTime.Now;


            _context.Update(user);

            return await _context.SaveChangesAsync();
        }
      
    }
}
