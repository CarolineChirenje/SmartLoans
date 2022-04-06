using SmartLogic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using SmartDomain;
using SmartInterfaces;

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
        [Required(ErrorMessage = "This field is required.")]
        [DataType(DataType.Password)]
        [StringLength(15, ErrorMessage = "The {0}  cannot exceed {1} characters. ")]
        [Display(Name = "Password")]
        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Passwords must be at least 6 characters and contain at least 3 of 4 of the following: upper case (A-Z), lower case (a-z), number (0-9) and special character (e.g. !@#$%^&*)")]

        public string Password { get; set; }

            public string ConfirmPassword { get; set; }

        [Required]
        public int UserID { get; set; }

        public int ResetTypeID { get; set; } = 1;

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
    public class CourseView
    {
       
        public string Topic { get; set; }
        public List<CheckBoxListItem> Sessions { get; set; }
    }
    public class ClientCourseView
    {
        public int ClientID { get; set; }
        public bool IsDeRegistered { get; set; }
        public DateTime? DateCompleted { get; set; }
       
        public int CourseID { get; set; }
        public int ClientCourseID { get; set; }
        public ClientForm Client { get; set; }
        public List<CourseView> Course { get; set; }
    }
    public class DashBoardViewModel
    {
        public int NewClientsCount { get; set; }
        public int ProductPayments { get; set; }
        public int CoursePrograms { get; set; }
        public int Notices { get; set; }

        public int NewFunds { get; set; }

    }

    public class ProductAssert
    {
        public SelectList Asserts { get; set; }
        public decimal Fee { get; set; }
        
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
        public string Price { get; set; }
        public string TransactionalLevy { get; set; }
        public string Units { get; set; }
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
        public bool AutoGenerateReceipt { get; set; }
        public bool AutoEmailReceipt { get; set; }
    }
    public class ScheduleModel
    {
        public int ProductID { get; set; }
        public int ClientID { get; set; }
        public bool IsSelected { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime DateTo { get; set; }
        public DateTime DateFrom { get; set; }

    }
    public class Access
    {
        public string Name { get; set; }
    }

    public class ConfirmCode
    {
        public int UserID { get; set; }
        public string Code { get; set; }
        public bool DoNotAskForTheDay { get; set; }
      
    }

}