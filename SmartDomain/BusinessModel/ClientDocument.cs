using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
  public  class ClientDocument : Documents
    {
        [Key]
        public int ClientDocumentID { get; set; }
        public int ClientID { get; set; }
       
        public virtual Client Client { get; set; }
      
      
    }
}
