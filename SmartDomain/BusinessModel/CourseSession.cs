namespace SmartDomain
{
    public class CourseSession : ChangeAudit
    {
        public int CourseSessionID { get; set; }
        public int CourseTopicID { get; set; }
        public virtual CourseTopic CourseTopic { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

    }
}