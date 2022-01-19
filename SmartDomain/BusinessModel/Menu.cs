using System.ComponentModel.DataAnnotations;

namespace SmartDomain
{
    public class Menu : ChangeAudit
    {
        [Key]
        public int MenuID { get; set; }
        public int MenuGroupID { get; set; }
        public virtual MenuGroup MenuGroup { get; set; }
        public string DisplayName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string CSSClass { get; set; }
        public int OrderNo { get; set; }
        public bool IsActive { get; set; }
        public string PathName { get { return $"{ControllerName}/{ActionName}/"; } }
     


    }
}