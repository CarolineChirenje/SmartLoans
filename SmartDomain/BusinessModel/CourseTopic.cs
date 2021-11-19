using System.Collections.Generic;

namespace SmartDomain
{
    public class CourseTopic : ChangeAudit
    {
        public int CourseTopicID { get; set; }
        public int CourseID { get; set; }
        public virtual Course Course { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public virtual List<CourseSession> CourseSessions { get; set; }

    }
}