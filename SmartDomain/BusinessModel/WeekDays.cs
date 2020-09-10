using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
    public class WeekDay
    {

        [Key]
        public int WeekDayID { get; set; }
        public string Name { get; set; }
    }
}
