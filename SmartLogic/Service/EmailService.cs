using SmartDomain;
using SmartHelper;
using SmartLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartLogic
{
    public static class EmailService
    {
        public static Email SendPassCode(UserAuthenticate userAuthenticate)
        {
            Email email = null;
            try
            {
                email = new Email();
                email.To = userAuthenticate.EmailAddress;
                email.AttachmentFromMemory = null;
                string _emailBody = @$"Hello {userAuthenticate.FullName},<br/><br/>" +
                              "Your one time passcode for <a href = " + UtilityService.SiteURL + ">" + UtilityService.ApplicationName + "</a> is : <br/>" +
                              "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b>" + Encryption.Decrypt(userAuthenticate.PinCode) + "</b><br/>" +
                               "Please be aware that this code is valid until "
                                + userAuthenticate.ExpiryDate + ".<br/><br/>" +
                               @"Regards,<br/><br/><b>" + UtilityService.ApplicationName + " Customer Service</b><br/><br/><br/>"
                               + "Please do not reply to this email.<br/><br/>" +
                                @"For any questions or information, please contact: email " + UtilityService.CustomerServiceEmail + ", or call " + UtilityService.ApplicationName + "customer service  at  " + UtilityService.CustomerServiceNumber + ".<br/><br/>";
                email.Body = UtilityService.HtmlDecode(_emailBody);
                email.Subject = UtilityService.SiteEnvironment == SiteEnvironment.Production ? $"Passcode for {UtilityService.ApplicationName}" : $"{UtilityService.SiteEnvironment} - Passcode for {UtilityService.ApplicationName}";

            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
            }
            return email;
        }
        public static Email SendPasswordReset(UserAuthenticate userAuthenticate)
        {
            Email email = null;
            try
            {
                string pincode = userAuthenticate.PinCode;
                email = new Email();
                email.To = userAuthenticate.EmailAddress;
                email.AttachmentFromMemory = null;
                string _emailBody = @"We have sent you this email in response to your request to reset your password on " + UtilityService.ApplicationName + ".<br/><br/>" +
                              "To reset your password for <a href = " + UtilityService.SiteURL + ">" + UtilityService.ApplicationName + "</a>, please follow the link below:<a href = " + UtilityService.SiteURLPasswordReset + ">Password Reset Link </a>." +
                              "CONFIRMATION CODE <b>" + Encryption.Decrypt(pincode) + "</b><br/><br/>" +
                               "We recommend that you keep your password secure and not share it with anyone.If you feel your password has been compromised, you can change it by  logging in to  " +
                               "<a href = " + UtilityService.SiteURL + ">" + UtilityService.ApplicationName + " </a>  ,going to your profile and clicking the  <b>'Change Email Address or Password'</b> link.<br/><br/>" +
                               @"If you need help, or you have any other questions, feel free to email " + UtilityService.CustomerServiceEmail + ", or call " + UtilityService.ApplicationName + "customer service  at  " + UtilityService.CustomerServiceNumber + ".<br/><br/> Regards,<br/><br/><br/><b>" + UtilityService.ApplicationName + " Customer Service</b>.";
                email.Body = UtilityService.HtmlDecode(_emailBody);
                email.Subject = $"Password Reset -{UtilityService.ApplicationName}";

            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
            }
            return email;
        }
        public static Email SendAccountCreationCode(UserAuthenticate userAuthenticate)
        {
            Email email = null;
            try
            {
                string pincode = userAuthenticate.PinCode;
                email = new Email();
                email.To = userAuthenticate.EmailAddress;
                email.AttachmentFromMemory = null;
                string _emailBody = @"We have sent you this email in response to your request to create an account on " + UtilityService.ApplicationName + ".<br/><br/>" +
                              "To continue  with this process on <a href = " + UtilityService.SiteURL + ">" + UtilityService.ApplicationName + "</a> , please follow the link below : <a href = " + UtilityService.SiteURLAccountCreation + ">Account Creation  Link </a> ." +
                                "CONFIRMATION CODE <b>" + Encryption.Decrypt(pincode) + "</b><br/><br/>" +
                               "We recommend that you keep your account details secure and not share it with anyone.If you feel your credentials have  been compromised, " +
                                @"or you have any other questions, feel free to email " + UtilityService.CustomerServiceEmail + ", or call " + UtilityService.ApplicationName + "customer service  at  " + UtilityService.CustomerServiceNumber + ".<br/><br/> Regards,<br/><br/><br/>" + UtilityService.ApplicationName + " Customer Service";
                email.Body = UtilityService.HtmlDecode(_emailBody);
                email.Subject = $"Account Creation - {UtilityService.ApplicationName}";

            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
            }
            return email;
        }
        public static Email SendAccountCreationConfirmation(string emailAddress,string password)
        {
            Email email = null;
            try
            { email = new Email();
                email.To = emailAddress;
                email.AttachmentFromMemory = null;
                string _emailBody = @"Your user account has been created successfully  account on " + UtilityService.ApplicationName + ".<br/><br/>" +
                                   "We recommend that you keep your account details secure and not share it with anyone.If you feel your credentials have  been compromised, " +
                                @"or you have any other questions, feel free to email " + UtilityService.CustomerServiceEmail + ", or call " + UtilityService.ApplicationName + "customer service  at  " + UtilityService.CustomerServiceNumber + ". Your login password is <b>" + password + "</b>.<br/><br/> Regards,<br/><br/><br/>" + UtilityService.ApplicationName + " Customer Service";
                email.Body = UtilityService.HtmlDecode(_emailBody);
                email.Subject = $"New Account Created - {UtilityService.ApplicationName}";

            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Logic_Base, ex);
            }
            return email;
        }

    }
}
