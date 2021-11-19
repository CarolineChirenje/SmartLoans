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
    public class User : ChangeAudit
    {
        private static readonly User _instance = new User();

        public static User Instance
        {
            get
            {
                return _instance;

            }
        }
        [Key]
        public int UserID { get; set; }
        public int UserTypeID { get; set; }
        public virtual UserType UserType { get; set; }
        public string EmailAddress { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("First Name(s)")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string IDNumber { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        public string UserName { get; set; }
     
        public string Password { get; set; }

        public DateTime PasswordExpiryDate { get; set; }
     
        public bool IsActive { get; set; }
        public bool CanOverrideMaintananceMode { get; set; }
        public byte[] ProfileImage { get; set; }
        public virtual List<UserRole> UserRoles { get; set; }

        public virtual List<UserAccessRestriction> UserAccessRestrictions { get; set; }

        [NotMapped]
        public virtual List<int> RoleList { get; set; }
        
        [NotMapped]
        public string UserFullName { get { return String.Concat(LastName, " ", FirstName); } }

   
    }

}
