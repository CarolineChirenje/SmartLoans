using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartDomain
{
    public class ClientMedicalDetail :ChangeAudit
    {
    [Key]
        public int ClientMedicalID { get; set; }

        public int ClientID { get; set; }
        public virtual Client Client { get; set; }
  
        public string Doctor { get; set; }

        public string Telephone { get; set; }

        public string MedicalAid { get; set; }

        public string MedicalAidNo { get; set; }
        public string Allergies { get; set; }

        public string PrescribedMedication { get; set; }
        public string Other { get; set; }

        public string  Hospital { get; set; }
    }
}
