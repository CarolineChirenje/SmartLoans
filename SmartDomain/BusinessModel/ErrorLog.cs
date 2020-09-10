using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
  public  class ErrorLog
    {
        [Key]
        public int ErrorLogID { get; set; }

        public int SourceID { get; set; }
        public string StackTrace { get; set; }
        public string Message { get; set; }
        public string LoggedBy { get; set; }
        public DateTime DateLogged { get; set; }

    }
}
