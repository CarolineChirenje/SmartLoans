using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SmartDomain
{
    public class AttendanceRegisterDetail : ChangeAudit
    {
        [Key]
        public int AttendanceRegisterDetailID { get; set; }
        public int AttendanceRegisterID { get; set; }
        public virtual AttendanceRegister AttendanceRegister { get; set; }
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
        public bool Present { get; set; }
        [NotMapped]
        public string AttendanceStatus { get { return Present ? "P" : "A"; } }
    }
}
