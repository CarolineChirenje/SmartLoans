namespace SmartDomain
{
    public class CourseOutline : ChangeAudit
    {
        public int CourseOutlineID { get; set; }
        public int CourseID { get; set; }
        public virtual Course Course { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

    }
}