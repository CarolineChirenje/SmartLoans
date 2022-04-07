using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
  public  class LoanDocument : Documents
    {
        [Key]
        public int LoanDocumentID { get; set; }
        public int LoanID { get; set; }
        public virtual Loan Loan { get; set; }


    }
}
