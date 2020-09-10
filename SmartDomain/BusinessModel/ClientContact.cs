using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
   public class ClientContact: ChangeAudit
    {
        public int ClientContactID { get; set; }

        public int ClientID { get; set; }
        public virtual Client Client { get; set; }

        public int ContactTypeID { get; set; }
        public virtual ContactType  ContactType { get; set; }

        public string ContactPerson { get; set; }

        public string Contact { get; set; }

        public int RelationshipTypeID { get; set; }
        public virtual RelationshipType RelationshipType { get; set; }

        public bool IsActive { get; set; }

      

    }
}
