using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartInterfaces
{
    public class CourseBreakDown
    {
        public string CourseName { get; set; }
        public List<CourseSession> CourseSessions { get; set; }
    }
}
