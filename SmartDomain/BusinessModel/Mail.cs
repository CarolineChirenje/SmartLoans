using System;
using System.ComponentModel.DataAnnotations;

namespace SmartDomain
{

    public class Mail
    {
        [Key]
        public int MailID { get; set; }
        public string Application { get; set; }
        public string EmailAddress { get; set; }
        public DateTime SentDate { get; set; }

    }
}