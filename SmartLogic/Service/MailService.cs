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
        public string APPLICATIONNAME => customSettings.GetSettingValue(AppSetting.Application_Name).ToString();
        public string DEFAULTEMAILSUBJECT => customSettings.GetSettingValue(AppSetting.Mail_Default_Subject).ToString();
        public string MAILDISPLAYNAME => customSettings.GetSettingValue(AppSetting.Mail_Display_Name).ToString();
        public string SMTP => customSettings.GetSettingValue(AppSetting.Mail_SMTP_Host).ToString();
        public bool ENABLESSL => Convert.ToBoolean(customSettings.GetSettingValue(AppSetting.Mail_Enable_SSL));
        public bool USEDEFAULTCREDENTIALS => Convert.ToBoolean(customSettings.GetSettingValue(AppSetting.Mail_Use_Default_Credentials));
        public string CREDENTIALUSERNAME => customSettings.GetSettingValue(AppSetting.Mail_Credential_User_Name).ToString();
        public string CREDENTIALPASSWORD => Encryption.Decrypt(customSettings.GetSettingValue(AppSetting.Mail_Credential_Password).ToString());
        public bool SendMail(Email email, bool sendAsync)
        {
            bool success = true;
            //create the MailMessage object
            System.Net.Mail.MailMessage mMailMessage = new System.Net.Mail.MailMessage();

            //set the sender address of the mail message
            mMailMessage.From = new MailAddress(CREDENTIALUSERNAME, MAILDISPLAYNAME);
            //set the recipient address of the mail message
            foreach (var address in email.To.Split(','))
                mMailMessage.To.Add(new MailAddress(address));
            //set the carbon copy address
            if (!string.IsNullOrEmpty(email.CC))
            {
                foreach (var address in email.CC.Split(','))
                    mMailMessage.CC.Add(new MailAddress(address));
            }

            //set the blind carbon copy address
            if (!string.IsNullOrEmpty(email.BCC))
            {
                foreach (var address in email.BCC.Split(','))
                    mMailMessage.Bcc.Add(new MailAddress(address));
            }

            //set the subject of the mail message
            mMailMessage.Subject = string.IsNullOrEmpty(email.Subject) ? DEFAULTEMAILSUBJECT : email.Subject;

            //set the body of the mail message
            mMailMessage.Body = email.Body;
            //set the format of the mail message body
            mMailMessage.IsBodyHtml = true;


            //set the priority
            mMailMessage.Priority = MailPriority.Normal;
            //add any attachments from the filesystem

            if (UtilityService.IsNotNull(email.FileSystemAttachmentList))
            {
                foreach (var filepath in email.FileSystemAttachmentList)
                {
                    // add attachments from file path
                    if (UtilityService.IsNotNull(filepath))
                    {
                        mMailMessage.Attachments.Add(new System.Net.Mail.Attachment(filepath.Name));

                    }
                }
            }


            if (UtilityService.IsNotNull(email.AttachmentFromMemory))
            {
                foreach (var attachment in email.AttachmentFromMemory)
                {
                    // add attachments from memory stream
                    if (UtilityService.IsNotNull(attachment.MemoryStream))
                    {
                        //save the data to a memory stream
                        //create the attachment from a stream. Be sure to name the data with a file and 
                        //media type that is respective of the data
                        mMailMessage.Attachments.Add(new System.Net.Mail.Attachment(attachment.MemoryStream, $"{attachment.Name}.{attachment.FileExtension}", "text/plain"));

                    }
                }
            }


            try
            {
                SmtpClient mSmtpClient = new SmtpClient();
                mSmtpClient.UseDefaultCredentials = USEDEFAULTCREDENTIALS;
                mSmtpClient.Host = SMTP;
                mSmtpClient.EnableSsl = ENABLESSL;
                NetworkCredential NetworkCred = new NetworkCredential(CREDENTIALUSERNAME, CREDENTIALPASSWORD);
                mSmtpClient.Credentials = NetworkCred;
                mSmtpClient.Port = SMTPPORT;

                //send the mail message
                if (sendAsync)
                {
                    mSmtpClient.Timeout = 200;
                    mSmtpClient.SendAsync(mMailMessage, APPLICATIONNAME);
                }
                else
                    mSmtpClient.Send(mMailMessage);
            }
            catch (Exception ex)
            {

                // ErrorLog.Log(ex, ErrorSource.Email);
                success = false;
            }

            return success;
        }
        /// <summary>
        /// Determines whether an email address is valid.
        /// </summary>
        /// <param name="emailAddress">The email address to validate.</param>
        /// <returns>
        /// 	<c>true</c> if the email address is valid; otherwise, <c>false</c>.
        /// </returns>
        public bool IsValidEmailAddress(string emailAddress)
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
