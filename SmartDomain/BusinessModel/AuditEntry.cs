
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDomain
{
    public class AuditEntry
    {
        public int AuditEntryID { get; set; }
        public string Username { get; set; }
        public int AuditActionID { get; set; }
        public  string  Description { get; set; }
        public DateTime DateAdded { get; set; }
        public string AddedBy { get; set; }
    }
   
}
