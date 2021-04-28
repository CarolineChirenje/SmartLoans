using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
    public class ErrorLog
    {
        [Key]
        public int ErrorLogID { get; set; }
        public int LogTypeID { get; set; }
        public string Error { get; set; }
        public DateTime DateGenerated { get; set; }

    }
}
