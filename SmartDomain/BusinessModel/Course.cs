using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartDomain
{
    public class Course : ChangeAudit
    {
        [Key]
        public int CourseID { get; set; }
        public string Title { get; set; }
                      public bool IsActive { get; set; }
        public virtual List<CourseOutline> CourseOutlines { get; set; }

    }
}