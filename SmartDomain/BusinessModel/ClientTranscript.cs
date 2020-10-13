﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartDomain
{
    public class ClientTranscript : ChangeAudit
    {

        [Key]
        public int ClientTranscriptID { get; set; }
        public int ClientCourseID { get; set; }
        public virtual ClientCourse ClientCourse { get; set; }
        public int CourseOutlineID { get; set; }
        public DateTime DateRegistered { get; set; }

    }
}