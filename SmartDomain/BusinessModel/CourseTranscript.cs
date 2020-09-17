using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartDomain
{
    public class CourseTranscript : ChangeAudit
    {

        [Key]
        public int CourseTranscriptID { get; set; }
        public int ClientCourseID { get; set; }
        public virtual ClientCourse ClientCourse { get; set; }
        public int CourseOutlineID { get; set; }
        public bool IsDeRegistered { get; set; }

        public DateTime? DateRegistered { get; set; }
        public DateTime? DateCompleted { get; set; }
    }
}
