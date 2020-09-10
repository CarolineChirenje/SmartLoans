using System.ComponentModel.DataAnnotations;

namespace SmartDomain
{

    public class FeatureFlag : ChangeAudit
    {
        [Key]
        public int FeatureFlagID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

    }
}