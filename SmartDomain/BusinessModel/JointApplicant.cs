using SmartDomain;
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
    public class JointApplicant : PersonalDetails
    {
        [Key]
        public int JointApplicantID { get; set; }
        [ForeignKey("ClientID")]
        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
        public int ApplicantGenderID { get; set; }
        public virtual Gender Gender { get; set; }
        public int RelationshipTypeID { get; set; }
        public virtual RelationshipType RelationshipType { get; set; }
        public int ApplicantTitleID { get; set; }
        public virtual Titles Title { get; set; }
        public int RecordStatusID { get; set; } = 1;
        public virtual RecordStatus RecordStatus { get; set; }

    }

}
