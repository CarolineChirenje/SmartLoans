using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartDomain
{
    public class Statement
    {
        [Key]
        public int StatementID { get; set; }
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
