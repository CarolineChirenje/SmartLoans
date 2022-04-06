using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHelper
{
    public class ConsumeResponse
    {
        public bool Success { get; set; }
        public string Result { get; set; }
    }
    public class MailOptions
    {
        public bool SMTPOnly { get; set; }
        public int SecureSocketOption { get; set; }
        public bool SMTPAndPortOnly { get; set; }
    }
    public class RabbitMQConfig
    {
        public int Port { get; set; }
        public string EndPoint { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Durable { get; set; }
        public bool Exclusive { get; set; }
        public bool AutoDelete { get; set; }
        public bool AutoAck { get; set; }
        public bool ReQueueOnError { get; set; }
        public bool AckMultiple { get; set; }
        public int PrefetchSize { get; set; }
        public int PrefetchCount { get; set; }
        public bool Global { get; set; }
        public bool UsePassiveDeclaration { get; set; }
        public string SiteEnvironment { get; set; }
    
    }
}
