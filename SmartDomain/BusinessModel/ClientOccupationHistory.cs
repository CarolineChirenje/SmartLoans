using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartDomain
{
    public class ClientOccupationHistory : ChangeAudit
    {

        [Key]
        public int ClientOccupationID { get; set; }
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
        public string Occupation { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salary { get; set; }
        
    }
}
