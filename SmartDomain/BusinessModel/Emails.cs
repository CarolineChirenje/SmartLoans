using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Text;

namespace SmartDomain
{
  public  class Email
    {
        /// <summary>
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

        public List<AttachmentFromFileSystem> FileSystemAttachmentList { get; set; }

        public List<AttachmentFromMemory> AttachmentFromMemory { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public int EmailStatus { get; set; }
        public DateTime? DelaySendingUntil { get; set; }

    }

    public class AttachmentFromMemory
    {
        public string Name { get; set; }
        public string FileExtension { get; set; }

        public MemoryStream MemoryStream { get; set; }

    }

    public class AttachmentFromFileSystem
    {
        public string Name { get; set; }


    }
}

