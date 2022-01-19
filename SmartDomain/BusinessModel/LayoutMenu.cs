using System.ComponentModel.DataAnnotations;

namespace SmartDomain
{
    public class LayoutMenu : ChangeAudit
    {
        [Key]
        public int LayoutMenuID { get; set; }
        public int LayoutID { get; set; }
        public virtual Layout Layout { get; set; }
        public string DisplayName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string CSSClass { get; set; }
        public int OrderNo { get; set; }
        public bool IsActive { get; set; }
        public string PathName { get { return $"{ControllerName}/{ActionName}/"; } }
        public bool LinkRequiresID { get; set; } = true;


    }
}