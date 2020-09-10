using System;
using System.ComponentModel.DataAnnotations;

namespace SmartDomain
{
    public class ProductNote : Notes

    {
        [Key]
        public int ProductNoteID { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
     
       
    }
}