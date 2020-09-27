using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartDomain { 
  public  class TransactionStatus 
    {
        [Key]
        public int TransactionStatusID { get; set; }

        public string Name { get; set; }

          

    }
}

