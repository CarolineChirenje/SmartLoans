using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDomain
{
    public abstract class ChangeAudit
    {
        [ReadOnly(true)]
        [DataType(DataType.DateTime)]
        [DisplayName("Last Changed Date")]
        [DisplayFormat(DataFormatString = "{yyyy-MM-dd HH:mm}")]
        public DateTime LastChangedDate { get; set; }
        [ReadOnly(true)]
        [DisplayName("Last Changed By")]
        public string LastChangedBy { get; set; }
    }
}
