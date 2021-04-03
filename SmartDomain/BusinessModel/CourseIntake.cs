using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartDomain
{
   public class CourseIntake : ChangeAudit
    {
        [Key]
        public int CourseIntakeID { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime  EndDate { get; set; }
        public int CourseID { get; set; }
        public virtual Course Course { get; set; }
        public int MaximumCapacity { get; set; }
        public bool IsActive { get; set; }
        public virtual List<AttendanceRegister> AttendanceRegisters { get; set; }
        [NotMapped]
        public string Duration { get { return $"{Name} ({StartDate.ToString("yyyy-MMM-dd")} - {EndDate.ToString("yyyy-MMM-dd")})"; }}
        [NotMapped]
        public string Period { get { return $"{StartDate.ToString("yyyy-MMM-dd")} - {EndDate.ToString("yyyy-MMM-dd")}"; } }


        [NotMapped]
        public DateTime AttendanceDate { get; set; }
        [NotMapped]
        public int CourseOutLine { get; set; }
        

    }
}
