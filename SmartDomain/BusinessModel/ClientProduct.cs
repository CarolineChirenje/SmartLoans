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

        public bool DoNotDeduct { get; set; }
        public DateTime DateRegistered { get { return DateTime.Now; } }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? DeductionPercentage { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal? IncreamentPercentage { get; set; }
        [NotMapped]
        public string DeductionAmount { get; set; }
        [NotMapped]
        public string IncreamentAmount { get; set; }
        [NotMapped]
        public string DeductionToBeApplied { get { return DoNotDeduct ? "Do Not Deduct" : (!DoNotDeduct && DeductionPercentage.HasValue ? "Deduct At Individual Level" : "Deduct At Product Level"); } }

    }
}
