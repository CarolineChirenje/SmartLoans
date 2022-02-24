using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SmartDataAccess;
using SmartDomain;
using SmartExtensions;
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
                return await _context.Users
                .Include(u => u.UserAccessGrants)
                 .Include(u => u.UserRoles)
                 .ThenInclude(p=>p.Roles)
                 .ThenInclude(p => p.RolePermissions)
                .FirstOrDefaultAsync(u => u.EmailAddress.Equals(username)
                 && u.Password.Equals(encryptedPassword));

            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }


        public async Task<User> GetUser(int userid)
        {
            try
            {

                return await _context.Users
               .Include(u => u.UserAccessGrants)
               .FirstOrDefaultAsync(u => u.UserID == userid);

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

        public AuthenticateResult GeneratePinCode(UserAuthenticate userAuthenticate)
        {
            try
            {
                Client client = new Client();
                User user = new User();
                if (userAuthenticate.IsAccountCreation)
                {
                    client = _context.Clients.FirstOrDefault(u => u.EmailAddress.Equals(userAuthenticate.EmailAddress) && u.IDNumber.Equals(userAuthenticate.IDNumber));
                    if (client.IsNull())
                        return null;
                }
                else
                {
                    user = _context.Users.FirstOrDefault(u => u.EmailAddress.Equals(userAuthenticate.EmailAddress));
                    if (user.IsNull())
                        return null;
                }
                string encryptedPinCode = NewPinCode;
                UserAuthenticationCode pin = new UserAuthenticationCode();
                if (userAuthenticate.IsAccountCreation)
                    pin.ClientID = client.ClientID;
                else
                    pin.UserID = user.UserID;
                pin.DateRequested = DateTime.Now;
                pin.PinCode = encryptedPinCode;
                if (userAuthenticate.CodeType == CodeType.Multi_Factor_Authenticator)
                    pin.ExpiryDate = pin.DateRequested.AddMinutes(UtilityService.PassCodeValidityPeriod);
                else
                    pin.ExpiryDate = pin.DateRequested.AddDays(UtilityService.PinCodeValidityPeriod);
                pin.IsValid = true;
                pin.IsAccountCreation = userAuthenticate.IsAccountCreation;
                pin.PinCodeTypeID = userAuthenticate.IsAccountCreation ? (int)CodeType.Account_Creation : (int)userAuthenticate.CodeType;
                _context.UserAuthenticationCodes.Add(pin);
                _context.SaveChanges();

                if (pin.PinCodeTypeID == (int)CodeType.Multi_Factor_Authenticator && userAuthenticate.IsReverify)
                {
                    try
                    {
                        int UserAuthenticationCodeID = pin.UserAuthenticationCodeID;
                        //Invalidate all other pins for today
                        var pincodes = _context.UserAuthenticationCodes.Where(
                             p => p.UserAuthenticationCodeID != UserAuthenticationCodeID
                             && p.IsValid
                             && p.UserID == userAuthenticate.UserID
                             && p.ExpiryDate.Date == DateTime.Now.Date
                             ).Select(x => x.UserAuthenticationCodeID).ToList();

                        
                        if (!pincodes.ListIsEmpty())
                        {
                            var some = _context.UserAuthenticationCodes.Where(x => pincodes.Contains(x.UserAuthenticationCodeID)).ToList();
                            some.ForEach(a => a.IsValid = false);
                            _context.SaveChanges();
                        }
                    }
                    catch (Exception ex)
                    {

                        CustomLog.Log(LogSource.Logic_Base, ex);
                    }


                }
                AuthenticateResult result = new AuthenticateResult()
                {
                    ExpiryDate = pin.ExpiryDate,
                    PinCode = pin.PinCode
                };
                return result;
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
            {                var user = await _context.Users.Where(u => u.EmailAddress.Equals(emailaddress) && u.IDNumber.Equals(idnumber)).FirstOrDefaultAsync();
                return user.IsNotNull();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }

        public async Task<UserAuthenticationCode> ConfirmCode(UserAuthenticate userAuthenticate)
        {
            try
            {
                string encryptedPinCode = Encryption.Encrypt(userAuthenticate.PinCode);
                UserAuthenticationCode pinReset = await _context.UserAuthenticationCodes
                            .Include(u => u.User)
                            .FirstOrDefaultAsync(u => u.PinCode.Equals(encryptedPinCode)
                            && u.IsAccountCreation == userAuthenticate.IsAccountCreation
                            && u.PinCodeTypeID == (int)userAuthenticate.CodeType
                            && u.IsValid);
                if (pinReset.IsNotNull() &&
                pinReset.PinCodeTypeID == (int)CodeType.Multi_Factor_Authenticator &&
                userAuthenticate.DoNotAskForTheDay)
                {
                    DateTime midnightToday = DateTime.Now.Date.AddDays(1).AddSeconds(-1);
                    UserAccessGrant accessGrant = new UserAccessGrant()
                    {
                        UserID = pinReset.UserID.HasValue ? pinReset.UserID.Value : userAuthenticate.UserID,
                        AllowUntil = midnightToday
                    };
                    Save(accessGrant);
                }
                return pinReset;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
                throw;
            }
        }
        public void Save(UserAccessGrant accessGrant)
        {
            try
            {
                accessGrant.LastChangedBy = UserAppData.CurrentUserName;
                accessGrant.LastChangedDate = DateTime.Now;
                _context.Add(accessGrant);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
            }
        }
        public async Task<int> PasswordChange(int userid, string password)
        {
            try
            {
                string encryptedPassword = Encryption.Encrypt(password);
                User user = await _context.Users
                            .FirstOrDefaultAsync(u => u.UserID == userid);

                if (user.IsNull())
                    return 0;
                user.Password = encryptedPassword;
                user.LastChangedBy = UserAppData.CurrentUserName;
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
