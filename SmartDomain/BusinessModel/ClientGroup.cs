using System.ComponentModel.DataAnnotations;

namespace SmartDomain
{

    public class ClientGroup : ChangeAudit
    {
        [Key]
        public int ClientGroupID { get; set; }
        public string Name { get; set; }
       
    }
}