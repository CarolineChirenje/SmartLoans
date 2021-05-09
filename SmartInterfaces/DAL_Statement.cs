using SmartDomain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text;

namespace SmartInterfaces
{
    public class StatementBase
    {
        [Key]
        public int StatementID { get; set; }
        public int ClientID { get; set; }
        public virtual ClientForm Client { get; set; }
       
    }

    public class Statement:StatementBase
    {
        
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool EmailStatement { get; set; }
        public bool PrintReversalsOnStatement { get; set; }
    }

    public class OutstandingStatement:Statement
    {
       
    }

    public class Receipt 
    {

        public string TransRef { get; set; }
        public byte[] Document { get; set; }
      
    }
}
