using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartDataAccess;
using SmartDomain;
using SmartHelper;
using SmartLog;

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
            try
            {

                        string encryptedPassword = Encryption.Encrypt(password);
            return await _context.Users.FirstOrDefaultAsync(u => u.EmailAddress == username &&
             u.Password == encryptedPassword);

            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
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
            try
            {

                        return _context.UserAuthenticationCodes.Any(p => p.PinCode.Equals(pincode));
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        string GeneratePinCode()
        {
            try
            {

                        string pincode = Encryption.Encrypt(UtilityService.GenerateRandomNumbers(UtilityService.PinCodeLength).ToString());
            
            if (PinCodeExists(pincode))
                return GeneratePinCode();

            else
                return pincode;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }



        #endregion PinCode
        public async Task<string> ResetPassword(string emailaddress, string idnumber, bool isAccountCreation)
        {
            try
            {

           
            Client client=new Client();
            User user = new User();
            if (isAccountCreation) {
                client = await _context.Clients.FirstOrDefaultAsync(u => u.EmailAddress.Equals(emailaddress) && u.IDNumber.Equals(idnumber));
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
             if( isAccountCreation)
                pin.ClientID = client.ClientID;
            else
            pin.UserID = user.UserID;
            pin.DateRequested = DateTime.Now;
            pin.PinCode = encryptedPinCode;
            pin.ExpiryDate = pin.DateRequested.AddDays(UtilityService.PinCodeValidityPeriod);
            pin.IsAccountCreation = isAccountCreation;
            _context.UserAuthenticationCodes.Add(pin);
             await _context.SaveChangesAsync();

            return encryptedPinCode;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<bool> UserAccountExists(string emailaddress, string idnumber)
        {
            try
            {
                        var user =await _context.Users.Where(u => u.EmailAddress.Equals(emailaddress) && u.IDNumber.Equals(idnumber)).FirstOrDefaultAsync();
            return UtilityService.IsNotNull(user);
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<UserAuthenticationCode> ConfirmCode(string code, bool isAccountCreation)
        {
            try
            {

                       string encryptedPinCode = Encryption.Encrypt(code);
            UserAuthenticationCode pinReset = await _context.UserAuthenticationCodes
                        .FirstOrDefaultAsync(u => u.PinCode.Equals(encryptedPinCode) && u.IsAccountCreation==isAccountCreation);
           
            return pinReset;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public async Task<int> PasswordChange(int userid, string password)
        {
            try
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
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
      
    }
}
