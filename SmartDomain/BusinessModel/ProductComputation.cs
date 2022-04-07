using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
    public class ProductComputation : ChangeAudit
    {
        [Key]
        public int ProductComputationID { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public bool IsActive { get; set; }
        [Required]
        [StringLength(50)]
        public string PluginName { get; set; }
        [Required]
        [StringLength(50)]
        public string Method { get; set; }
        [Required]
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateCreated { get; set; }




    }
}
