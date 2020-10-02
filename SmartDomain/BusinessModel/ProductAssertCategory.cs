using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartDomain
{
    public class ProductAssertCategory : ChangeAudit

    {
        [Key]
        public int ID { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        public int AssertCategoryID { get; set; }
        public virtual AssertCategory AssertCategory { get; set; }
        public DateTime DateRegistered { get; set; }


    }
}