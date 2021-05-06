using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartInterfaces
{
    public class ClientList
    {
        public int ClientID { get; set; }
        public int TitleID { get; set; }
        public string AccountType { get; set; }
        public string Affiliation { get; set; }
        public string Status { get; set; }
        public string Initials { get; set; }
        public string LastName { get; set; }
        public string PrimaryApplicantName { get { return String.Concat(((Title)TitleID).ToString(), " ", Initials, " ", LastName); } }
        public string AccountNumber { get; set; }
        public int ApplicantTitleID { get; set; }
        public bool IsJointAccount { get; set;  }
        public string JointApplicantInitials { get; set; }
        public string JointApplicantLastName { get; set; }
        public string ClientRef { get { return String.Concat(AccountNumber, "-", ClientFullName); } }
        public string CoApplicantSalutation { get { return IsJointAccount ? String.Concat(((Title)ApplicantTitleID).ToString(), " ", JointApplicantInitials, " ", JointApplicantLastName) : ""; } }
        public string ClientFullName { get { return IsJointAccount ? (String.Concat(PrimaryApplicantName, (IsJointAccount ? $" & {CoApplicantSalutation}" : ""))) : PrimaryApplicantName; } }

    }
}
