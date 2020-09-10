using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartDomain
{
  public  class MailMessage
    {  /// <summary>
       /// This helper class sends an email message using the System.Net.Mail namespace
       /// </summary>
       /// <param name="fromEmail">Sender email address</param>
       /// <param name="toEmail">Recipient email address</param>
       /// <param name="bcc">Blind carbon copy email address</param>
       /// <param name="cc">Carbon copy email address</param>
       /// <param name="subject">Subject of the email message</param>
       /// <param name="body">Body of the email message</param>
       /// <param name="attachment">File to attach</param>

        public int EmailID { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string CC { get; set; }
        public string BCC { get; set; }
        public string Subject { get; set; }

        public string Body { get; set; }
        [NotMapped]
        public List<string> AttachmentFullPath { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public int EmailStatus { get; set; }
        public DateTime? DelaySendingUntil { get; set; }
    }
}
