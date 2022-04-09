using System;
using System.ComponentModel.DataAnnotations;

namespace SmartDomain
{
    public class LoanNote : Notes

    {
        [Key]
        public int LoanNoteID { get; set; }
        public int LoanID { get; set; }
        public virtual Loan Loan { get; set; }
        public bool VisibleToAdminOnly { get; set; }

    }
}