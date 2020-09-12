﻿using System;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Net;
using SmartHelper;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;

namespace SmartHelper
{
    public class UtilityService
    {



        public static string GetPanelColor(int count)

        {
            if (count == 1 || count == 0)
                return "panel panel-info";
            else if (count == 2)
                return "panel panel-warning";
            else if (count == 3)
                return "panel panel-danger";
            else
            {
                if (count % 2 == 0)
                    return "panel panel-warning";

                if (count % 3 == 0)
                    return "panel panel-danger";

            }
            return "panel panel-info";
        }


        public static bool HasPermission(Permissions permission) => GetData.IsPermitted((int)permission);


        public static string ApplicationName
        {
            get
            {
                return GetData.GetSettingValue((int)AppSetting.Application_Name).Value;

            }
        }
        public static string ApplicationNamePrefix
        {
            get
            {
                return GetData.GetSettingValue((int)AppSetting.Application_Name_Prefix).Value;

            }
        }

        public static string ReportLogo
        {
            get
            {
                return GetData.GetSettingValue((int)AppSetting.Report_Logo_Path).Value;

            }
        }

        public static string Report_Footer_1
        {
            get
            {
                return GetData.GetSettingValue((int)AppSetting.Report_Footer_1).Value;

            }
        }

        public static string Report_Footer_2
        {
            get
            {
                return GetData.GetSettingValue((int)AppSetting.Report_Footer_2).Value;

            }
        }

        public static bool PaymentsMustBeVatInclusive
        {
            get
            {

                string value = GetData.GetSettingValue((int)AppSetting.Capture_VAT_Inclusive_Payments).Value;
                return value.Equals("true") ? true : false;

            }
        }

        public static string VATPercentage
        {
            get
            {

                string _percentage = GetData.GetSettingValue((int)AppSetting.VAT_Percentage).Value;
                decimal _vatPercentage = 0;
                try
                {
                    _vatPercentage = decimal.Parse(_percentage, System.Globalization.CultureInfo.InvariantCulture); ;
                }
                catch (Exception)
                {

                    _vatPercentage = 0.15M;
                }

                decimal vatPercentage = _vatPercentage * 100M;

                return String.Concat(vatPercentage.ToString(), "%");

            }
        }

        public static bool StatementPasswordProtect
        {
            get
            {

                string value = GetData.GetSettingValue((int)AppSetting.Statement_Password_Protect).Value;
                return value.Equals("true") ? true : false;

            }
        }


        public static string StatementPasswordForAdmin
        {
            get
            {

                string value = GetData.GetSettingValue((int)AppSetting.Statement_Password_For_Admin).Value;
                return value;

            }
        }
        public static bool SaveStatementsToFolder
        {
            get
            {

                string value = GetData.GetSettingValue((int)AppSetting.Statement_Save_To_Folder).Value;
                return value.Equals("true") ? true : false;

            }
        }

        public static string StatementsSavePath
        {
            get
            {

                string value = GetData.GetSettingValue((int)AppSetting.Statement_Save_To_Physical_Location).Value;
                return value;

            }
        }

        public static string AppendFileTimeStamp( string fileName)
        {
            return string.Concat(
                System.IO.Path.GetFileNameWithoutExtension(fileName),
                DateTime.Now.ToString("yyyyMMddHHmmss"),
                 System.IO.Path.GetExtension(fileName)
                );
        }

        public static int DefaultCompanyID
        {
            get
            {
                string sqlCustomSetting = $"SELECT TOP 1 Value FROM CustomSettings WHERE CustomSettingID={(int)AppSetting.Default_Company_ID};";
                string _companyID = GetData.GetStringValue(sqlCustomSetting);
                int defaultCompanyID = 1;
                try
                {
                    defaultCompanyID = Int32.Parse(_companyID);
                }
                catch (Exception)
                {


                }
                return defaultCompanyID;

            }
        }


        public static bool FeatureFlagOn(int id)
        {

            string sqlCustomSetting = $"SELECT TOP 1 IsActive  FROM FeatureFlags WHERE FeatureFlagID={id};";
            string _result = GetData.GetStringValue(sqlCustomSetting);
            if (String.IsNullOrEmpty(_result))
                return false;
            if (_result.Equals("1"))
                return true;
            else
                return false;
        }
        //public static int UserType
        //{
        //    get
        //    {

        //        string sqlCustomSetting = $"SELECT TOP 1 * FROM CustomSettings WHERE CustomSettingID={CustomSettingID};";
        //        string _result = GetData.GetStringValue((int)AppSetting.VAT_Percentage).Value;
        //        decimal _vatPercentage = 0;
        //        try
        //        {
        //            _vatPercentage = decimal.Parse(_percentage, System.Globalization.CultureInfo.InvariantCulture); ;
        //        }
        //        catch (Exception)
        //        {

        //            _vatPercentage = 0.15M;
        //        }

        //        decimal vatPercentage = _vatPercentage * 100M;

        //        return String.Concat(vatPercentage.ToString(), "%");

        //    }
        //}
        /// <summary>
        /// Static value protected by access routine.
        /// </summary>
        static string _currentUserName;
        static string _currentFullName;
        static int _ClientID;
        /// <summary>
        /// Access routine for global variable.
        /// </summary>
        public static string CurrentUserName
        {
            get
            {
                return _currentUserName;
            }
            set
            {
                _currentUserName = value;
            }
        }


        public static int CurrentUserTypeID;


        public static int ClientID
        {
            get
            {
                return _ClientID;
            }
            set
            {
                _ClientID = value;
            }
        }
        public static string UserFullName
        {
            get
            {
                return _currentFullName;
            }
            set
            {
                _currentFullName = value;
            }
        }




        //public static AuditEntry Log(AuditActionEnum action, string description)
        //{

        //    AuditEntry entry = new AuditEntry
        //    {
        //        AddedBy = UtilityService.CurrentUserName,
        //        DateAdded = DateTime.Now,
        //        AuditActionID = (int)action,
        //        Description = description
        //    };
        //    return entry;
        //}
        public static void ClearUserNames()
        {
            UtilityService.UserFullName = string.Empty;
            UtilityService.CurrentUserName = string.Empty;
        }

        public static string HtmlDecode(string htmlValue) => WebUtility.HtmlDecode(htmlValue);

        public static string HtmlEncode(string stringValue) => WebUtility.HtmlEncode(stringValue);


        public static bool ListIsNotEmpty(List<Object> value) => (value != null) && (value.Count > 0);

        public static bool IsNotNull(Object value) => value != null;

        public static bool IsNull(Object value) => value == null;

        public static bool StringParameterHasValue(string value) => !String.IsNullOrEmpty(value);


        public static string GenerateUserName(string firstName, string LastName) => $"{firstName.Substring(0, 1).ToUpper()}{LastName}{GenerateRandomNumbers(2)}";
        ///Generate QueryRef
        internal static string GenerateQueryRef()
        {
            string sAlphNum = RandomAlphanumeric();
            string queryRef = $"Q{DateTime.Now.Year.ToString()}{ DateTime.Now.ToString("MMM").ToUpper()}{RandomAlphanumeric()}";
            return queryRef;

        }
        public static string GenerateTransactionRef(string ClientRef)
        {
            string sAlphNum = RandomAlphanumeric();
            string queryRef = $"T{ClientRef}{DateTime.Now.Year.ToString()}{ DateTime.Now.ToString("MM").ToUpper()}{RandomAlphanumeric(2)}";
            return queryRef.ToUpper();
        }


        public static string GetUserType(int userTypeID)
        {
            return Enum.GetName(typeof(TypeOfUser), userTypeID);
        }

        public static int GenerateRandomNumbers(int numberSize = 4)
        {
            int _min = 1000;
            int _max = 9999;
            switch (numberSize)
            {
                case 2:
                    _min = 10;
                    _max = 99;
                    break;
                case 4:
                    _min = 1000;
                    _max = 9999;
                    break;
                default:
                    break;
            }

            Random _rdm = new Random();
            return _rdm.Next(_min, _max);
        }
        #region Random Generators

        public static string GeneratePassword
        {
            get { return RandomAlphanumeric(5); }
        }
        static string RandomAlphanumeric(int length = 3)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(valid[(int)(num % (uint)valid.Length)]);
                }
            }

            return res.ToString();
        }

        #endregion Random Generators

        public static string ShowDateTime(DateTime? passedDate)
        {
            DateTime datePassed = passedDate ?? DateTime.MinValue;
            return datePassed.ToString(GetData.GetSettingValue((int)AppSetting.Date_Format).Value);
        }

        public static string ShowDate(DateTime? passedDate)
        {
            DateTime datePassed = passedDate ?? DateTime.MinValue;
            return datePassed.Date.ToString("yyyy-MM-dd");
        }
        public static string GetMessageToDisplay(string ResourceKey) => SmartHelper.ResourceManager.GetString(ResourceKey);
        public static string ShowYesOrNo(bool status) => status ? "Yes" : "No";

        public static string ShowActiveAction(bool status) => status ? "De-Activate" : "Re-Activate";

        public static string ShowOpenCloseAction(bool status) => status ? "Open" : "Closed";

        public static string ShowGender(int gender) => Enum.GetName(typeof(GenderOrientation), gender);



    }

    [Serializable]
    public class CustomException : Exception
    {
        public CustomException(string message)
        {

        }
        //   public static CustomException HandleDbEntityValidationException(DbEntityValidationException dbu)
        //     {
        //         StringBuilder messageBuilder = new StringBuilder();
        //         foreach (var error
        //in dbu.EntityValidationErrors)
        //         {
        //             foreach (var validationError
        //                 in error.ValidationErrors)
        //             {
        //                 messageBuilder.AppendLine($"{error.Entry.Entity.GetType().Name}." +
        //                     $"{validationError.PropertyName} - { validationError.ErrorMessage}"
        //                    );
        //             }
        //         }
        //         string message = messageBuilder.ToString();
        //         LogException(dbu, dbu.GetType().Name, message, ErrorSource.Database);
        //         return new CustomException(message);
        //     }
        public static CustomException ChimbadzoExceptions(string message) => new CustomException(message);
        //public static CustomException HandleDbUpdateException(DbUpdateException dbu)
        //{
        //    var messageBuilder = new StringBuilder("A DbUpdateException was caught while saving changes. ");
        //    try
        //    {
        //        foreach (var result in dbu.Entries)
        //        {
        //            messageBuilder.AppendFormat("Type: {0} was part of the problem. ", result.Entity.GetType().Name);
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        messageBuilder.Append("Error parsing DbUpdateException: " + e.ToString());
        //    }
        //    string message = messageBuilder.ToString();
        //    LogException(dbu, dbu.GetType().Name, message, ErrorSource.Database);
        //    return new CustomException(message);
        //}
        //public static CustomException HandleGenericException(Exception exception, ErrorSource errorType, string url = "Unknown")
        //{
        //    LogException(exception, exception.GetType().Name, null, errorType, url);
        //    return new CustomException(exception.Message);
        //}


        private static void LogException(Exception ex, string ExceptionType, string customMessage, ErrorSource errorType, string url = "Uknown")
        {
            //try
            //{
            //    ChimbadzoEntities db = new ChimbadzoEntities();
            //    SYS_ERRORLOG logError = new SYS_ERRORLOG();
            //    logError.ExceptionMessage = ex.Message;
            //    logError.CustomMessage = customMessage;
            //    logError.ExceptionType = ExceptionType;
            //    logError.StackTrace = ex.StackTrace;
            //    logError.DateCreated = DateTime.Now;
            //    logError.PageURL = url;
            //    logError.Type = (int)errorType;
            //    logError.UserCreated = UtilityService.CurrentUserName;
            //    db.SYS_ERRORLOG.Add(logError);
            //    db.SaveChanges();
            //}
            //catch (DbEntityValidationException exception)
            //{
            //    throw CustomException.HandleDbEntityValidationException(exception);
            //}
        }
    }





}

