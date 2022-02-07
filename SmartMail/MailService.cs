using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using SmartDomain;
using SmartHelper;
using SmartLog;
using SmartLogic;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SmartMail
{ //http://www.binaryintellect.net/articles/e30d07c6-6f57-43e7-a2ce-6d2d67ebf403.aspx
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
        public bool SendEmail(Email email) => SendMail(email).Result;

        public async Task<bool> SendMail(Email email)
        {
            bool success = true;
            //create the MailMessage object
            var mMailMessage = new MimeMessage();
            try
            {  //set the sender address of the mail message
                mMailMessage.From.Add(new MailboxAddress(MAILDISPLAYNAME, CREDENTIALUSERNAME));
                if (UtilityService.SiteEnvironment == SiteEnvironment.Production)
                {
                    //set the recipient address of the mail message
                    foreach (var address in email.To.Split(','))
                        mMailMessage.To.Add(MailboxAddress.Parse(address));
                    //set the carbon copy address
                    if (!string.IsNullOrEmpty(email.CC))
                    {
                        foreach (var address in email.CC.Split(','))
                            mMailMessage.Cc.Add(MailboxAddress.Parse(address));
                    }
                    //set the blind carbon copy address
                    if (!string.IsNullOrEmpty(email.BCC))
                    {
                        foreach (var address in email.BCC.Split(','))
                            mMailMessage.Bcc.Add(MailboxAddress.Parse(address));
                    }
                }
                else
                {
                    string mailAddress = UtilityService.TestEmailAddress;
                    mMailMessage.To.Add(MailboxAddress.Parse(mailAddress));
                }
                //set the subject of the mail message
                mMailMessage.Subject = string.IsNullOrEmpty(email.Subject) ? DEFAULTEMAILSUBJECT : email.Subject;
                //set the format of the mail message body and the mail message
                var builder = new BodyBuilder();
                builder.HtmlBody = UtilityService.HtmlDecode(email.Body);
                // builder.TextBody = textContent;

                //set the priority
                mMailMessage.Priority = MessagePriority.Urgent;
                //add any attachments from the filesystem
                if (UtilityService.IsNotNull(email.FileSystemAttachmentList))
                {
                    foreach (var filepath in email.FileSystemAttachmentList)
                    {
                        // add attachments from file path
                        if (UtilityService.IsNotNull(filepath))
                        {
                            builder.Attachments.Add(filepath.Name);
                            //  mMailMessage.Attachments.Add(new Attachment(filepath.Name));
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
                            builder.Attachments.Add($"{attachment.Name}.{attachment.FileExtension}", attachment.MemoryStream, new ContentType("application", "pdf"));
                            //mMailMessage.Body.(new System.Net.Mail.Attachment(attachment.MemoryStream, $"{attachment.Name}.{attachment.FileExtension}", "text/plain"));
                        }
                    }
                }
                mMailMessage.Body = builder.ToMessageBody();

                // send email
                                await SendEmailAsync(mMailMessage);
                return success;
            }
            catch (Exception ex)
            {
                CustomLog.Log(LogSource.Mail, ex);
                success = false;
                return success;
            }

        }


            private async Task SendEmailAsync(MimeMessage mMailMessage)
            {
                try
                {

                    using (var client = new SmtpClient())
                    {
                        client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                        if (GetData.Environment().ToLower().Equals("development"))
                        {
                     // https://github.com/jstedfast/MailKit/blob/master/FAQ.md#SslHandshakeException
                        await client.ConnectAsync(SMTP, SMTPPORT, SecureSocketOptions.StartTlsWhenAvailable);
                        }
                        else
                        {
                            await client.ConnectAsync(SMTP);
                        }

                        await client.AuthenticateAsync(CREDENTIALUSERNAME, CREDENTIALPASSWORD);
                        await client.SendAsync(mMailMessage);
                        await client.DisconnectAsync(true);
                    }
                }
                catch (Exception ex)
                {
                CustomLog.Log(LogSource.Mail, ex);
                throw new InvalidOperationException(ex.Message);
                }
            }

        }
    }
