using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartDomain
{
    public class ClientProduct : ChangeAudit
    {
        [Key]
        public int ClientProductID { get; set; }
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        public bool IsActive { get; set; }
        public DateTime DateRegistered { get { return DateTime.Now; } }
        public decimal? DeductionPercentage { get; set; }
        public decimal? IncreamentPercentage { get; set; }
        [NotMapped]
        public string DeductionAmount { get; set; }
        [NotMapped]
        public string IncreamentAmount { get; set; }
    }
}
