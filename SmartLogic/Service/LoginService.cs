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
            return _context.UserPinResets.Any(p => p.PinCode.Equals(pincode));
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
        public async Task<string> ResetPassword(string emailaddress)
        {
           
            User user= await _context.Users.FirstOrDefaultAsync(u => u.EmailAddress.Equals(emailaddress));
            if (UtilityService.IsNull(user))
                return "";
            string encryptedPinCode = NewPinCode;
            UserPinReset pin = new UserPinReset();
            pin.UserID = user.UserID;
            pin.DateRequested = DateTime.Now;
            pin.PinCode = encryptedPinCode;
            pin.ExpiryDate = pin.DateRequested.AddDays(UtilityService.PinCodeValidityPeriod);
            _context.UserPinResets.Add(pin);
             await _context.SaveChangesAsync();

            return encryptedPinCode;
        }

        public async Task<UserPinReset> ConfirmCode(string code)
        {
            string encryptedPinCode = Encryption.Encrypt(code);
            UserPinReset pinReset = await _context.UserPinResets
                        .FirstOrDefaultAsync(u => u.PinCode.Equals(encryptedPinCode));
           
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
            user.LastChangedDate = DateTime.Now;


            _context.Update(user);

            return await _context.SaveChangesAsync();
        }
      
    }
}
