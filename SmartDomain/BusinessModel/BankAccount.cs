using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
   public class BankAccount: ChangeAudit
    {
        [Key]
        public int BankAccountID { get; set; }
      
        public int BankAccountTypeID { get; set; }
        public virtual BankAccountType   BankAccountType { get; set; }

        public string AccountCode { get; set; }

        public string AccountName { get; set; }

        public string AccountNumber { get; set; }

       
        public int CurrencyID { get; set; }
        public virtual Currency CurrencyType { get; set; }

        public bool IsActive { get; set; }

        




    }
}
