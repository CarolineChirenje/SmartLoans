using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
    public class UserToDo : ChangeAudit
    {
        [Key]
        public int UserToDoID { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }

        public string  ToDo { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DueDate { get; set; }
        
    }

}
