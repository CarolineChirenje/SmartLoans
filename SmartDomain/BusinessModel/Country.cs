using System.ComponentModel.DataAnnotations;

namespace SmartDomain
{

    public class Country : ChangeAudit
    {
        [Key]
        public int CountryID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

    }
}