using SmartLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace SmartSave.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

    }

    public class PasswordResetModel
    {
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required]
        public int UserID { get; set; }

    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string EmailAddress { get; set; }


    }
    public class RegisterAccountViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        [Display(Name = "Identity Number")]

        public string IDNumber { get; set; }



    }

    public class CheckBoxModel
    {
        public int LinkedID { get; set; }
        public IList<string> SelectedItems { get; set; }
        public IList<CheckBoxListItem> AvailableItems { get; set; }
        public CheckBoxModel()
        {
            LinkedID = 0;
            SelectedItems = new List<string>();
            AvailableItems = new List<CheckBoxListItem>();
        }
    }

    public class CheckBoxListItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsChecked { get; set; }
    }

    public class DashBoardViewModel
    {
        public int NewClientsCount { get; set; }
        public int ProductPayments { get; set; }
        public int Enquiries { get; set; }
        public int FullyBookedEquipment { get; set; }
        public int EventsThisWeek { get; set; }
        public int Notices { get; set; }

        public int ActiveNotices { get; set; }

    }
    public class PaymentViewModel
    {
        public int TransactionID { get; set; }
        public string TransRef { get; set; }
        public int ClientID { get; set; }
        public int ProductID { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int TransactionType { get; set; }
        public int PaymentStatusID { get; set; }
        public string Amount { get; set; }
        public string Narration { get; set; }
        public DateTime PaymentDate { get; set; }
        public int ParentPaymentID { get; set; }
        public string PaymentReasonID { get; set; }
        public string AccountNumber { get; set; }
        public int BankAccountID { get; set; }
        public int TransactionTypeID { get; set; }
        public bool IsFromClient { get; set; }
        public int AssertID { get; set; }
        public int AssertCategoryID { get; set; }

    }
    public class ScheduleModel
    {
        public int ProductID { get; set; }
        public int ClientID { get; set; }
        public bool IsSelected { get; set; }
        public DateTime CutOffDate { get; set; }
      
    }

   
    public class ScheduleModelDetails
    {
        /// <summary>  
        /// To hold list of schedules  
        /// </summary>  
        public List<ScheduleModel> ScheduleDetails { get; set; }

    }

}