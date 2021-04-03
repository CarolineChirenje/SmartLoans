﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartDomain
{
    public class ClientCourse : ChangeAudit
    {

        [Key]
        public int ClientCourseID { get; set; }
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
        public int CourseID { get; set; }
        public virtual Course Course { get; set; }
        public int? CourseIntakeID { get; set; }
        public virtual CourseIntake CourseIntake { get; set; }
        public DateTime DateRegistered { get; set; }
        public DateTime? DateCompleted { get; set; }
        public bool IsDeRegistered { get; set; }
    }
}
