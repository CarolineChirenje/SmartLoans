using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using CustomSetting = SmartDomain.CustomSetting;

namespace SmartLogic
{
    public class MailService : IMailService
    {
        ICustomSettingsService customSettings = new CustomSettingsService();
        public int SMTPPORT => Convert.ToInt32(customSettings.GetSettingValue(AppSetting.Mail_SMTP_Port));
  
        public  string SMTP => customSettings.GetSettingValue(AppSetting.Mail_SMTP_Port).ToString();
        public  bool ENABLESSL => Convert.ToBoolean(customSettings.GetSettingValue(AppSetting.Mail_Enable_SSL));
        public  bool USEDEFAULTCREDENTIALS => Convert.ToBoolean(customSettings.GetSettingValue(AppSetting.Mail_Enable_SSL));
        public  string CREDENTIALUSERNAME => customSettings.GetSettingValue(AppSetting.Mail_Credential_User_Name).ToString();
        public  string CREDENTIALPASSWORD => Encryption.Decrypt(customSettings.GetSettingValue(AppSetting.Mail_Credential_Password).ToString());
        public bool SendMail(Email email)
        {
            bool success = true;
            ////create the MailMessage object
            //MailMessage mMailMessage = new MailMessage();

            ////set the sender address of the mail message
            //mMailMessage.From = new MailAddress(CREDENTIALUSERNAME);
            ////set the recipient address of the mail message
            //mMailMessage.To.Add(new MailAddress(email.To));

            ////set the blind carbon copy address
            //if (!string.IsNullOrEmpty(email.BCC))
            //{
            //    mMailMessage.Bcc.Add(new MailAddress(email.BCC));
            //}

            ////set the carbon copy address
            //if (!string.IsNullOrEmpty(email.CC))
            //{
            //    mMailMessage.CC.Add(new MailAddress(email.CC));
            //}

            ////set the subject of the mail message
            //mMailMessage.Subject = string.IsNullOrEmpty(email.Subject) ? "Gym Web Application Notification" : email.Subject;

            ////set the body of the mail message
            //mMailMessage.Body = email.Body;
            ////set the format of the mail message body
            //mMailMessage.IsBodyHtml = true;
            ////set the priority
            //mMailMessage.Priority = MailPriority.Normal;

            ////add any attachments from the filesystem
            //if (UtilityService.IsNotNull(email.AttachmentFullPath))
            //{
            //    foreach (var attachmentPath in email.AttachmentFullPath)
            //    {
            //        Attachment mailAttachment = new Attachment(attachmentPath);
            //        mMailMessage.Attachments.Add(mailAttachment);
            //    }
            //}
            //try
            //{
            //    SmtpClient mSmtpClient = new SmtpClient();
            //    mSmtpClient.Host = SMTP;
            //    mSmtpClient.EnableSsl = ENABLESSL;
            //    NetworkCredential NetworkCred = new NetworkCredential(CREDENTIALUSERNAME, CREDENTIALPASSWORD);
            //    mSmtpClient.UseDefaultCredentials = USEDEFAULTCREDENTIALS;
            //    mSmtpClient.Credentials = NetworkCred;
            //    mSmtpClient.Port = SMTPPORT;
            //    //send the mail message
            //    mSmtpClient.Send(mMailMessage);
            //}
            //catch (Exception ex)
            //{

            //    // throw;
            //    success = false;
            //}

            return success;
        }

        /// <summary>
        /// Determines whether an email address is valid.
        /// </summary>
        /// <param name="emailAddress">The email address to validate.</param>
        /// <returns>
        /// 	<c>true</c> if the email address is valid; otherwise, <c>false</c>.
        /// </returns>
        public  bool IsValidEmailAddress(string emailAddress)
        {
            // An empty or null string is not valid
            if (String.IsNullOrEmpty(emailAddress))
            {
                return (false);
            }

            // Regular expression to match valid email address
            string emailRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

            // Match the email address using a regular expression
            Regex re = new Regex(emailRegex);
            if (re.IsMatch(emailAddress))
                return (true);
            else
                return (false);
        }

    }
}
