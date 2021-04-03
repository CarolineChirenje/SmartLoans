using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartDomain
{
   public class AttendanceRegister : ChangeAudit
    {
        [Key]
        public int AttendanceRegisterID { get; set; }

        public int CourseIntakeID { get; set; }
        public virtual CourseIntake CourseIntake { get; set; }

        public int? CourseOutlineID { get; set; }
        public virtual CourseOutline CourseOutline { get; set; }

        public string AttendanceDate { get; set; }

        public string RequestedBy { get; set; }

        public virtual List<AttendanceRegisterDetail> AttendanceRegisterDetails { get; set; }

    
    }
}
