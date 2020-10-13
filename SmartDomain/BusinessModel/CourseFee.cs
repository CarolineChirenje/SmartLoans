using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartDomain
{
    public class CourseFee : ChangeAudit

    {
        [Key]
        public int CourseFeeID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CourseID { get; set; }
        public virtual Course Course { get; set; }
        public int FrequencyID { get; set; }
        public virtual Frequency Frequency { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }
        public bool IsActive { get; set; }

        [NotMapped]
        public string CostAmount { get; set; }

    }
}