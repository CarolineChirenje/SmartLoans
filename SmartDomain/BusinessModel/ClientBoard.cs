using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartDomain
{
   public class ClientBoard :ChangeAudit
    {
        [Key]
        public int ClientBoardID { get; set; }
                public int ClientID { get; set; }
        public virtual Client Client { get; set; }
     
        public string Details { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
                public bool SendToParent { get; set; }

        public bool SendToClient { get; set; }
    }
}
