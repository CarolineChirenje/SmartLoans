using System.ComponentModel.DataAnnotations;

namespace SmartDomain
{
    public class PriorityRank : ChangeAudit
    {
        [Key]
        public int PriorityRankID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
  
    }
}

