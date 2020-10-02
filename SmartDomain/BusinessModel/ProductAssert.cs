using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartDomain
{
    public class ProductAssert : ChangeAudit

    {
        [Key]
        public int ID { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        public int AssertID { get; set; }
        public virtual Assert Assert { get; set; }
          }
}