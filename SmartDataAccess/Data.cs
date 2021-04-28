using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using CustomSetting = SmartDomain.CustomSetting;

namespace SmartDataAccess
{
    public static class Data
    {

        public static WeekDay[] GetWeekDays()
        {

            List<WeekDay> weekDays = new List<WeekDay>();
            var weekDay = from DaysOfTheWeek s in Enum.GetValues(typeof(DaysOfTheWeek))
                          select new { ID = s, Name = s.ToString() };

            foreach (var x in weekDay)
            {
                weekDays.Add(new WeekDay()
                {
                    WeekDayID = (int)x.ID,
                    Name = x.Name.Replace("_", " "),


                });

            }
            return weekDays.ToArray();
        }
        public static CustomVariableType[] GetCustomVariableTypes()
        {
            List<CustomVariableType> variableTypes = new List<CustomVariableType>
            {
                new CustomVariableType()
                {
                    CustomVariableTypeID = (int)VariableType.Boolean,
                    Name =VariableType.Boolean.ToString().Replace("_", " "),
                    IsActive = true,

                                       LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },   new CustomVariableType()
                {
                    CustomVariableTypeID = (int)VariableType.Double,
                    Name =VariableType.Double.ToString().Replace("_", " "),
                    IsActive = true,
                                       LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                   new CustomVariableType()
                {
                    CustomVariableTypeID = (int)VariableType.Integer,
                    Name =VariableType.Integer.ToString().Replace("_", " "),
                    IsActive = true,
                                       LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                      new CustomVariableType()
                {
                    CustomVariableTypeID = (int)VariableType.Long,
                    Name =VariableType.Long.ToString().Replace("_", " "),
                    IsActive = true,
                                       LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                         new CustomVariableType()
                {
                    CustomVariableTypeID = (int)VariableType.String,
                    Name =VariableType.String.ToString().Replace("_", " "),
                    IsActive = true,
                                       LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                              new CustomVariableType()
                {
                    CustomVariableTypeID = (int)VariableType.Decimal,
                    Name =VariableType.Decimal.ToString().Replace("_", " "),
                    IsActive = true,
                                       LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                              new CustomVariableType()
                {
                    CustomVariableTypeID = (int)VariableType.Date_Time,
                    Name =VariableType.Date_Time.ToString().Replace("_", " "),
                    IsActive = true,
                                       LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },             new CustomVariableType()
                {
                    CustomVariableTypeID = (int)VariableType.Password,
                    Name =VariableType.Password.ToString().Replace("_", " "),
                    IsActive = true,
                                       LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },

               new CustomVariableType()
                {
                    CustomVariableTypeID = (int)VariableType.Percentage,
                    Name =VariableType.Percentage.ToString().Replace("_", " "),
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
            };

            return variableTypes.ToArray();
        }


        public static PriorityRank[] GetPriorityRanks()
        {
            List<PriorityRank> priorityRanks = new List<PriorityRank>
            {
                new PriorityRank()
                {
                    PriorityRankID = (int)Priority.Critical,
                    Name = Priority.Critical.ToString().Replace("_", " "),
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                new PriorityRank()
                {
                    PriorityRankID = (int)Priority.High,
                    Name = Priority.High.ToString().Replace("_", " "),
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                 new PriorityRank()
                {
                    PriorityRankID = (int)Priority.Medium,
                    Name = Priority.Medium.ToString().Replace("_", " "),
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
               },
                 new PriorityRank()
                {
                    PriorityRankID = (int)Priority.Low,
                    Name = Priority.Low.ToString().Replace("_", " "),
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
               }
            };

            return priorityRanks.ToArray();

        }
        public static SmartDomain.CustomSetting[] GetApplicationSettings()
        {
            List<CustomSetting> settings = new List<SmartDomain.CustomSetting>
            {
                new SmartDomain.CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Application_Name,
                    Name = AppSetting.Application_Name.ToString().Replace("_", " "),
                    Value="Smart Save",
                    Description="Displayed as the Application Name",
                    CustomVariableTypeID=(int)VariableType.String,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                 new SmartDomain.CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Application_Name_Prefix,
                    Name = AppSetting.Application_Name_Prefix.ToString().Replace("_", " "),
                    Value="SS",
                    Description="Short Name for Application",
                    CustomVariableTypeID=(int)VariableType.String,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                new SmartDomain.CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.System_Version,
                    Name = AppSetting.System_Version.ToString().Replace("_", " "),
                    Value="1.0.0.0",
                    Description="Displays Current Version of the System",
                    CustomVariableTypeID=(int)VariableType.String,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                 new CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Account_Number_Length,
                    Name = AppSetting.Account_Number_Length.ToString().Replace("_", " "),
                    Value="9",
                    Description="Limit Account Number Size",
                    CustomVariableTypeID=(int)VariableType.Integer,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },

                new CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Account_Number_Prefix,
                    Name = AppSetting.Account_Number_Prefix.ToString().Replace("_", " "),
                    Value="SS",
                    Description="Account Number Prefix if Any",
                    CustomVariableTypeID=(int)VariableType.String,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },

                new CustomSetting()
                {

                    CustomSettingID = (int)AppSetting.Show_Custom_Exceptions_To_Users,
                    Name = AppSetting.Show_Custom_Exceptions_To_Users.ToString().Replace("_", " "),
                    Value="true",
                    Description="Allows system to hide exceptions and show custom error page to user",
                    CustomVariableTypeID=(int)VariableType.Boolean,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },

                  new CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Date_Format,
                    Name = AppSetting.Date_Format.ToString().Replace("_", " "),
                    Value="yyyy-MMM-dd",
                    Description ="Format Used to display date",
                    CustomVariableTypeID=(int)VariableType.Date_Time,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                   new CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Date_Time_Format,
                    Name = AppSetting.Date_Time_Format.ToString().Replace("_", " "),
                    Value="yyyy-MMM-dd HH:mm",
                    Description ="Format Used to display date time",
                    CustomVariableTypeID=(int)VariableType.Date_Time,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
               new CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Mail_SMTP_Port,
                    Name = AppSetting.Mail_SMTP_Port.ToString().Replace("_", " "),
                    Value="587",
                    Description ="Port used to Send Emails",
                    CustomVariableTypeID=(int)VariableType.Integer,
                    CustomSettingTypeID=(int)SettingType.Email,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
               },
               new CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Mail_SMTP_Host,
                    Name = AppSetting.Mail_SMTP_Host.ToString().Replace("_", " "),
                    Value="smtp.gmail.com",
                    Description ="Host used to Send Emails",
                    CustomVariableTypeID=(int)VariableType.String,
                    CustomSettingTypeID=(int)SettingType.Email,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
               },
                new CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Mail_Enable_SSL,
                    Name = AppSetting.Mail_Enable_SSL.ToString().Replace("_", " "),
                    Value="true",
                    Description ="Enable SSL",
                    CustomVariableTypeID=(int)VariableType.Boolean,
                    CustomSettingTypeID=(int)SettingType.Email,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
               },
               new CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Mail_Use_Default_Credentials,
                    Name = AppSetting.Mail_Use_Default_Credentials.ToString().Replace("_", " "),
                    Value="false",
                    Description ="Use Default Mail Credentials",
                    CustomVariableTypeID=(int)VariableType.Boolean,
                    CustomSettingTypeID=(int)SettingType.Email,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
               },
                new CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Mail_Credential_User_Name,
                    Name = AppSetting.Mail_Credential_User_Name.ToString().Replace("_", " "),
                    Value="carolinesolutions89@gmail.com",
                    Description ="Email Address used to email",
                    CustomVariableTypeID=(int)VariableType.String,
                    CustomSettingTypeID=(int)SettingType.Email,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
               },
                new CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Mail_Credential_Password,
                    Name = AppSetting.Mail_Credential_Password.ToString().Replace("_", " "),
                    Value=Encryption.Encrypt("dcoizhxiqzvwvzak"), //smart save app password
                    Description ="Email Password",
                    CustomVariableTypeID=(int)VariableType.Password,
                    CustomSettingTypeID=(int)SettingType.Email,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
               },
              new CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Mail_Display_Name,
                    Name = AppSetting.Mail_Display_Name.ToString().Replace("_", " "),
                    Value="Smart Admin",
                    Description ="Display Sender Name As",
                    CustomVariableTypeID=(int)VariableType.String,
                    CustomSettingTypeID=(int)SettingType.Email,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
               },

            new CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.VAT_Percentage,
                    Name = AppSetting.VAT_Percentage.ToString().Replace("_", " "),
                    Value="0.14",
                    Description ="Percentage To Which VAT is calculated on ",
                    CustomVariableTypeID=(int)VariableType.Percentage,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
               },
               new CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.File_Maximum_UpLoadable_Size,
                    Name = AppSetting.File_Maximum_UpLoadable_Size.ToString().Replace("_", " "),
                    Value="5",
                    Description ="Maximum file size that can be uploaded to the System",
                    CustomVariableTypeID=(int)VariableType.Decimal,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
               },

               new SmartDomain.CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Report_Footer_1,
                    Name = AppSetting.Report_Footer_1.ToString().Replace("_", " "),
                    Value="W. Guri Mrs. (Chairman), *E. Guri (Managing)",
                    Description="First Line on the Report Footer",
                    CustomVariableTypeID=(int)VariableType.String,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                new SmartDomain.CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Report_Footer_2,
                    Name = AppSetting.Report_Footer_2.ToString().Replace("_", " "),
                    Value="*Executive.",
                    Description="Additional Line on the Report Footer (can be blank)",
                    CustomVariableTypeID=(int)VariableType.String,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },

                new SmartDomain.CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Report_FootNotes,
                    Name = AppSetting.Report_FootNotes.ToString().Replace("_", " "),
                    Value="",
                    Description="Foot notes that you would like to include on your statement (not mandatory)",
                    CustomVariableTypeID=(int)VariableType.String,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },

                new SmartDomain.CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Capture_VAT_Inclusive_Payments,
                    Name = AppSetting.Capture_VAT_Inclusive_Payments.ToString().Replace("_", " "),
                    Value="true",
                    Description="Instructs the System to Advise User to Capture VAT inclusive amounts and calculate breakdown accordingly",
                    CustomVariableTypeID=(int)VariableType.Boolean,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
            new SmartDomain.CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Statement_Password_For_Admin,
                    Name = AppSetting.Statement_Password_For_Admin.ToString().Replace("_", " "),
                    Value="123456",
                    Description="Password Used to Open Password Protected Statement By System Administrators",
                    CustomVariableTypeID=(int)VariableType.String,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                 new SmartDomain.CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Statement_Password_Protect,
                    Name = AppSetting.Statement_Password_Protect.ToString().Replace("_", " "),
                    Value="true",
                    Description="Allows to password protect statements being sent by Email",
                    CustomVariableTypeID=(int)VariableType.Boolean,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                new SmartDomain.CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Statement_Show_Table_Boarders,
                    Name = AppSetting.Statement_Show_Table_Boarders.ToString().Replace("_", " "),
                    Value="true",
                    Description="Determines if table borders will be shown on the report ",
                    CustomVariableTypeID=(int)VariableType.Boolean,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                  new SmartDomain.CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Mail_Default_Subject,
                    Name = AppSetting.Mail_Default_Subject.ToString().Replace("_", " "),
                    Value=$"Smart Save  Admin",
                    Description="Default Email Subject Name Used By Auto-Generated Emails",
                    CustomVariableTypeID=(int)VariableType.String,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                     new SmartDomain.CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Password_Reset_Pin_Code_Length,
                    Name = AppSetting.Password_Reset_Pin_Code_Length.ToString().Replace("_", " "),
                    Value="5",
                    Description="Password Reset Pin Code Length",
                    CustomVariableTypeID=(int)VariableType.Integer,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                  new SmartDomain.CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Password_Reset_Pin_Validity,
                    Name = AppSetting.Password_Reset_Pin_Validity.ToString().Replace("_", " "),
                    Value="2",
                    Description="Password Reset Pin Code Validity Period in Days",
                    CustomVariableTypeID=(int)VariableType.Integer,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                  new SmartDomain.CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Site_URL,
                    Name = AppSetting.Site_URL.ToString().Replace("_", " "),
                    Value=@"https://localhost:5001",
                    Description="Site URL",
                    CustomVariableTypeID=(int)VariableType.String,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                new SmartDomain.CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Site_Customer_Service_Email,
                    Name = AppSetting.Site_Customer_Service_Email.ToString().Replace("_", " "),
                    Value=@"carochire@gmail.com",
                    Description="Customer Support Email",
                    CustomVariableTypeID=(int)VariableType.String,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                 new SmartDomain.CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Site_Customer_Service_Number,
                    Name = AppSetting.Site_Customer_Service_Number.ToString().Replace("_", " "),
                    Value=@"0731143168",
                    Description="Customer Support Number",
                    CustomVariableTypeID=(int)VariableType.String,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },

                 new SmartDomain.CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Site_Test_Email_Account,
                    Name = AppSetting.Site_Test_Email_Account.ToString().Replace("_", " "),
                    Value="carochire@gmail.com",
                    Description="Default Email Addresss that overrides Client Email Address in a Test Environment ",
                    CustomVariableTypeID=(int)VariableType.String,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                new SmartDomain.CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Site_Default_Environment,
                    Name = AppSetting.Site_Default_Environment.ToString().Replace("_", " "),
                    Value="1",
                    Description="Current System Environment Set it to 1 For Test Environment  or 2 for Production Environment if no value has been set System defaults to Test Environment ",
                    CustomVariableTypeID=(int)VariableType.Integer,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                 new SmartDomain.CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Application_Role_Based_Menus,
                    Name = AppSetting.Application_Role_Based_Menus.ToString().Replace("_", " "),
                    Value="false",
                    Description="Display menus based on User Role",
                    CustomVariableTypeID=(int)VariableType.Boolean,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },

                  new SmartDomain.CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Password_Validity_Period,
                    Name = AppSetting.Password_Validity_Period.ToString().Replace("_", " "),
                    Value="30",
                    Description="Password Validity Period in Days",
                    CustomVariableTypeID=(int)VariableType.Integer,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },

                new SmartDomain.CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Account_Number_Auto_Generate,
                    Name = AppSetting.Account_Number_Auto_Generate.ToString().Replace("_", " "),
                    Value="true",
                    Description="Auto Generate Account Numbers",
                    CustomVariableTypeID=(int)VariableType.Boolean,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                 new SmartDomain.CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Application_Is_VAT_Compliant,
                    Name = AppSetting.Application_Is_VAT_Compliant.ToString().Replace("_", " "),
                    Value="false",
                    Description="Allows System To Be VAT Compliant and Show calculated VAT Amounts ",
                    CustomVariableTypeID=(int)VariableType.Boolean,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
            
                  new SmartDomain.CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Client_Notes_Default_Due_Date_Interval,
                    Name = AppSetting.Client_Notes_Default_Due_Date_Interval.ToString().Replace("_", " "),
                    Value="5",
                    Description="Default Due date for note if not set by person who created it",
                    CustomVariableTypeID=(int)VariableType.Integer,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
              
                new SmartDomain.CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Report_Body_Font_Name,
                    Name = AppSetting.Report_Body_Font_Name.ToString().Replace("_", " "),
                    Value="Arial",
                    Description="Sets the Font Name for PDF Reports Body Section",
                    CustomVariableTypeID=(int)VariableType.String,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                  new SmartDomain.CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Report_Body_Font_Size,
                    Name = AppSetting.Report_Body_Font_Size.ToString().Replace("_", " "),
                    Value="9",
                    Description="Sets the Font Size for PDF Reports Body Section",
                    CustomVariableTypeID=(int)VariableType.Integer,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                 new SmartDomain.CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Report_Footer_Font_Name,
                    Name = AppSetting.Report_Footer_Font_Name.ToString().Replace("_", " "),
                    Value="Arial",
                    Description="Sets the Font Name for PDF Reports Footer Section",
                    CustomVariableTypeID=(int)VariableType.String,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                  new SmartDomain.CustomSetting()
                {
                    CustomSettingID = (int)AppSetting.Report_Footer_Font_Size,
                    Name = AppSetting.Report_Footer_Font_Size.ToString().Replace("_", " "),
                    Value="8",
                    Description="Sets the Font Size for PDF Reports Footer Section",
                    CustomVariableTypeID=(int)VariableType.Integer,
                    CustomSettingTypeID=(int)SettingType.All,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                };

            return settings.ToArray();

        }
        public static CustomSettingType[] GetCustomSettingTypes()
        {
            List<CustomSettingType> settingTypes = new List<CustomSettingType>
            {
                new CustomSettingType()
                {
                    CustomSettingTypeID = (int)SettingType.BackEnd,
                    Name = SettingType.BackEnd.ToString().Replace("_", " "),
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
               new CustomSettingType()
                {
                    CustomSettingTypeID = (int)SettingType.Portal,
                    Name = SettingType.Portal.ToString().Replace("_", " "),
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                new CustomSettingType()
                {
                    CustomSettingTypeID = (int)SettingType.All,
                    Name = SettingType.All.ToString().Replace("_", " "),
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                new CustomSettingType()
                {
                    CustomSettingTypeID = (int)SettingType.Email,
                    Name = SettingType.Email.ToString().Replace("_", " "),
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                }
            };

            return settingTypes.ToArray();

        }
        public static RelationshipType[] GetRelationshipTypes()
        {
            List<RelationshipType> RelationshipTypes = new List<RelationshipType>
            {  new RelationshipType()
                {
                    RelationshipTypeID =1,
                    Name = "Self",
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                new RelationshipType()
                {
                    RelationshipTypeID =2,
                    Name = "Mother",
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
               new RelationshipType()
                {
                     RelationshipTypeID =3,
                    Name = "Father",
                    IsActive = true,
                  LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                new RelationshipType()
                {
                    RelationshipTypeID =4,
                    Name = "Sibling",
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                }
                ,
                new RelationshipType()
                {
                    RelationshipTypeID =5,
                    Name = "Spouse",
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                 new RelationshipType()
                {
                    RelationshipTypeID =6,
                    Name = "Business Partner",
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
               new RelationshipType()
                {
                    RelationshipTypeID =7,
                    Name = "Other",
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                }
            };

            return RelationshipTypes.ToArray();

        }
        public static ContactType[] GetContactTypes()
        {
            List<ContactType> ContactTypes = new List<ContactType>
            {
                new ContactType()
                {
                    ContactTypeID = (int)ContactTypeValues.Cell_Phone,
                    Name = ContactTypeValues.Cell_Phone.ToString().Replace("_", " "),
                    IsActive = true,
                                       LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
               new ContactType()
                {
                    ContactTypeID = (int)ContactTypeValues.Email_Address,
                    Name = ContactTypeValues.Email_Address.ToString().Replace("_", " "),
                    IsActive = true,
                                       LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                new ContactType()
                {
                    ContactTypeID = (int)ContactTypeValues.Postal_Address,
                    Name =ContactTypeValues.Postal_Address.ToString().Replace("_", " "),
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                }
                ,
                new ContactType()
                {
                    ContactTypeID = (int)ContactTypeValues.Residential_Address,
                    Name =ContactTypeValues.Residential_Address.ToString().Replace("_", " "),
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                }
                  ,
                new ContactType()
                {
                    ContactTypeID = (int)ContactTypeValues.Telephone,
                    Name =ContactTypeValues.Telephone.ToString().Replace("_", " "),
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                }
            };

            return ContactTypes.ToArray();

        }
        public static UserType[] GetUserTypes()
        {

            List<UserType> userTypes = new List<UserType>();
            var userType = from TypeOfUser s in Enum.GetValues(typeof(TypeOfUser))
                           select new { ID = s, Name = s.ToString() };

            foreach (var x in userType)
            {
                userTypes.Add(new UserType()
                {
                    UserTypeID = (int)x.ID,
                    Name = x.Name.Replace("_", " "),
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                });

            }
            return userTypes.ToArray();
        }
        public static Frequency[] GetFrequencies()
        {

            List<Frequency> frequencies = new List<Frequency>();
            var p = from FrequencyList s in Enum.GetValues(typeof(FrequencyList))
                    select new { ID = s, Name = s.ToString() };

            foreach (var x in p)
            {
                frequencies.Add(new Frequency()
                {
                    FrequencyID = (int)x.ID,
                    Name = x.Name.Replace("_", " "),
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                });

            }
            return frequencies.ToArray();
        }
        public static PaymentStatus[] GetPaymentStatuses()
        {
            List<PaymentStatus> payments = new List<PaymentStatus>();
            var pstatus = from PaymentState s in Enum.GetValues(typeof(PaymentState))
                          select new { ID = s, Name = s.ToString() };

            foreach (var p in pstatus)
            {
                payments.Add(new PaymentStatus()
                {
                    PaymentStatusID = (int)p.ID,
                    Name = p.Name.Replace("_", " "),
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser",

                });

            }
            return payments.ToArray();

        }

        public static RolePermission[] GetPermissionsForSuperUserRole()
        {
            List<RolePermission> rolePermissions = new List<RolePermission>();
            int count = 1;
            foreach (var permission in GetPermissions())
            {
                rolePermissions.Add(new RolePermission()
                {
                    RolePermissionID = count,
                    PermissionID = permission.PermissionID,
                    RoleID = 1,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser",

                });


                count++;
            }
            return rolePermissions.ToArray();

        }
        public static Permission[] GetPermissions()
        {

            List<Permission> permissions = new List<Permission>();
            var perms = from Permissions s in Enum.GetValues(typeof(Permissions))
                        select new { ID = s, Name = s.ToString() };
            foreach (var perm in perms)
            {
                permissions.Add(new Permission()
                {
                    PermissionID = (int)perm.ID,
                    Name = perm.Name.Replace("_", " "),
                    IsActive = true,
                    IsDeleted = false,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                });
            }
            return permissions.ToArray();

        }
        public static string DescriptionAttr<T>(this T source)
        {
            FieldInfo fi = source.GetType().GetField(source.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0) return attributes[0].Description;
            else return source.ToString();
        }
        public static TransactionType[] GetTransactionTypes()
        {

            List<TransactionType> transactionTypes = new List<TransactionType>();
            var transTypes = from TransactionTypeList s in Enum.GetValues(typeof(TransactionTypeList))
                             select new { ID = s, Name = s.ToString() };

            foreach (var x in transTypes)
            {
                transactionTypes.Add(new TransactionType()
                {
                    TransactionTypeID = (int)x.ID,
                    Name = x.Name.Replace("_", " "),
                    Code = ((TransactionTypeList)x.ID).DescriptionAttr(),
                    TransactionStatusID = (int)TransactionState.Positive,
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                });

            }
            return transactionTypes.ToArray();
        }
        public static Role[] GetRoles()
        {
            List<Role> roles1 = new List<Role>();
            var roles = from DefaultRoles s in Enum.GetValues(typeof(DefaultRoles))
                        select new { ID = s, Name = s.ToString() };

            foreach (var x in roles)
            {
                roles1.Add(new Role()
                {
                    RoleID = (int)x.ID,
                    Name = x.Name.Replace("_", " "),
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                });

            }
            return roles1.ToArray();

        }

        public static Company[] GetDefaultCompany()
        {

            List<Company> company = new List<Company>
            {
                new Company()
                {
                    CompanyID = 1,
                    Name = String.IsNullOrEmpty(UtilityService.ApplicationName) ? "Smart Save" : UtilityService.ApplicationName,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser",
                    IsActive = true,
                    IsDefault=true

                }
            };

            return company.ToArray();

        }
        public static Gender[] GetGenders()
        {
            List<Gender> genders = new List<Gender>
            {
                new Gender()
                {
                    GenderID = (int)GenderOrientation.Female,
                    Name = GenderOrientation.Female.ToString().Replace("_", " "),
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
               new Gender()
                {
                    GenderID = (int)GenderOrientation.Male,
                    Name = GenderOrientation.Male.ToString().Replace("_", " "),
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
            };

            return genders.ToArray();

        }
        public static User[] GetUsers()
        {

            List<User> users = new List<User>
            {
                new User()
                        {
                            UserID = 1,
                            UserTypeID = (int)TypeOfUser.Administrator,
                            LastChangedDate = DateTime.Now,
                            EmailAddress = "carochire@gmail.com",
                            Password = Encryption.Encrypt(UtilityService.GetMessageToDisplay("ADMIN")),
                            IsActive = true,
                            UserName = "SuperUser",
                            FirstName = "Wadzanai",
                            LastName = "Chirenje",
                            IDNumber="8904161200188",
                            LastChangedBy = "SuperUser",
                            PasswordExpiryDate=DateTime.MinValue
                        },
                         new User()
                         {
                             UserID = 2,
                             UserTypeID = (int)TypeOfUser.Employer,
                             LastChangedDate = DateTime.Now,
                             EmailAddress = "carochire89@gmail.com",
                             Password = Encryption.Encrypt(UtilityService.GetMessageToDisplay("ADMIN")),
                             IsActive = true,
                             UserName = "Employer",
                             FirstName = "John",
                             LastName = "Jarani",
                             IDNumber="0000000000000",
                             LastChangedBy = "SuperUser",
                              PasswordExpiryDate=DateTime.MinValue
                         }
                         ,
                         new User()
                         {
                             UserID = 3,
                             UserTypeID = (int)TypeOfUser.Employee,
                             LastChangedDate = DateTime.Now,
                             EmailAddress = "carolinesolutions89@gmail.com",
                             Password = Encryption.Encrypt(UtilityService.GetMessageToDisplay("ADMIN")),
                             IsActive = true,
                             UserName = "Employee",
                             FirstName = "Ndini",
                             LastName = "Ndadaro",
                             IDNumber="1111111111111",
                             LastChangedBy = "SuperUser",
                              PasswordExpiryDate=DateTime.MinValue
                         },


            };

            return users.ToArray();

        }
        public static UserRole[] GetUserRoles()
        {

            List<UserRole> userRoles = new List<UserRole>
            {
                 new UserRole()
           {
               UserRoleID = 1,
               UserID = 1,
               RoleID =(int)DefaultRoles.Super_Admin,
               LastChangedBy = "SuperUser",
               LastChangedDate = DateTime.Now,
           },
            new UserRole()
            {
                UserRoleID = 2,
                UserID = 2,
                RoleID =(int)DefaultRoles.Administrator,
                LastChangedBy = "SuperUser",
                LastChangedDate = DateTime.Now,
            }
            };

            return userRoles.ToArray();

        }

        public static RoleMenu[] GetRoleMenus()
        {

            List<RoleMenu> roleMenus = new List<RoleMenu>();
            var menus = MenuData.GetMenus();
            //  int menuCount = menus.Length;
            int count = 1;//-(menuCount);
            foreach (var x in menus)
            {
                roleMenus.Add(new RoleMenu()
                {
                    RoleMenuID = count,
                    MenuID = (int)x.MenuID,
                    RoleID = (int)DefaultRoles.Super_Admin,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                });
                count++;
            }
            return roleMenus.ToArray();

        }
        public static BankAccountType[] GetBankAccountTypes()
        {

            List<BankAccountType> bankAccountTypes = new List<BankAccountType>();
            var accountTypes = from AccountType s in Enum.GetValues(typeof(AccountType))
                               select new { ID = s, Name = s.ToString() };

            foreach (var x in accountTypes)
            {
                bankAccountTypes.Add(new BankAccountType()
                {
                    BankAccountTypeID = (int)x.ID,
                    Name = x.Name.Replace("_", " "),
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                });

            }
            return bankAccountTypes.ToArray();

        }

        public static TransactionStatus[] GetTransactionStatus()
        {

            List<TransactionStatus> transactions = new List<TransactionStatus>();
            var transState = from TransactionState s in Enum.GetValues(typeof(TransactionState))
                             select new { ID = s, Name = s.ToString() };

            foreach (var x in transState)
            {
                transactions.Add(new TransactionStatus()
                {
                    TransactionStatusID = (int)x.ID,
                    Name = x.Name.Replace("_", " "),

                });

            }
            return transactions.ToArray();

        }
        public static Currency[] GetCurrencies()
        {

            List<Currency> curr = new List<Currency>();
            var currList = from CurrencyList s in Enum.GetValues(typeof(CurrencyList))
                           select new { ID = s, Name = s.ToString() };

            foreach (var x in currList)
            {
                curr.Add(new Currency()
                {
                    CurrencyID = (int)x.ID,
                    Name = x.Name.Replace("_", " "),
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                });

            }
            return curr.ToArray();






        }
        public static Country[] GetCountries()
        {

            List<Country> country = new List<Country>();
            var countryList = from CountryList s in Enum.GetValues(typeof(CountryList))
                              select new { ID = s, Name = s.ToString() };

            foreach (var x in countryList)
            {
                country.Add(new Country()
                {
                    CountryID = (int)x.ID,
                    Name = x.Name.Replace("_", " "),
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                });

            }
            return country.ToArray();

        }
        public static FeatureFlag[] GetFeatureFlags()
        {

            List<FeatureFlag> featureFlags = new List<FeatureFlag>();
            var features = from FeatureFlagList s in Enum.GetValues(typeof(FeatureFlagList))
                           select new { ID = s, Name = s.ToString() };

            foreach (var x in features)
            {
                featureFlags.Add(new FeatureFlag()
                {
                    FeatureFlagID = (int)x.ID,
                    Name = x.Name.Replace("_", " "),
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                });

            }
            return featureFlags.ToArray();
        }

        public static DocumentFormat[] GetDocumentFormats()
        {

            List<DocumentFormat> documentFormats = new List<DocumentFormat>();
            var formats = from DocumentFormatList s in Enum.GetValues(typeof(DocumentFormatList))
                          select new { ID = s, Name = s.ToString() };

            foreach (var x in formats)
            {
                documentFormats.Add(new DocumentFormat()
                {
                    DocumentFormatID = (int)x.ID,
                    Name = x.Name.Replace("_", " "),
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                });

            }
            return documentFormats.ToArray();
        }
        public static DocumentType[] GetDocumentTypes()
        {

            List<DocumentType> documentTypes = new List<DocumentType>();
            var docTypes = from DocumentTypeList s in Enum.GetValues(typeof(DocumentTypeList))
                           select new { ID = s, Name = s.ToString() };

            foreach (var x in docTypes)
            {
                documentTypes.Add(new DocumentType()
                {
                    DocumentTypeID = (int)x.ID,
                    Name = x.Name.Replace("_", " "),
                    IsActive = true,
                    LastChangedDate = DateTime.Now,
                    DocumentFormatID = (int)DocumentFormatList.pdf,
                    LastChangedBy = "SuperUser"

                });

            }
            return documentTypes.ToArray();
        }
        public static StatementList[] GetStatementList()
        {

            List<StatementList> statementTypes = new List<StatementList>();
            var eTypes = from Statements s in Enum.GetValues(typeof(Statements))
                         select new { ID = s, Name = s.ToString() };

            foreach (var x in eTypes)
            {
                statementTypes.Add(new StatementList()
                {
                    StatementID = (int)x.ID,
                    Name = x.Name.Replace("_", " "),
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                });

            }
            return statementTypes.ToArray();
        }

        public static EmailType[] GetEmailTypes()
        {

            List<EmailType> emailTypes = new List<EmailType>();
            var eTypes = from EmailTypeList s in Enum.GetValues(typeof(EmailTypeList))
                         select new { ID = s, Name = s.ToString() };

            foreach (var x in eTypes)
            {
                emailTypes.Add(new EmailType()
                {
                    EmailTypeID = (int)x.ID,
                    Name = x.Name.Replace("_", " "),
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                });

            }
            return emailTypes.ToArray();
        }

        public static EmailTemplate[] GetEmailTemplates()
        {
            List<EmailTemplate> emailTemplates = new List<EmailTemplate>
            {
                new EmailTemplate()
                {
                    EmailTemplateID =1,
                    EmailTypeID=(int)EmailTypeList.Client_Statement,
                    Subject ="Account Statement",
                    Body = @"Dear Customer, 

                        Attached is your Account statement. To view it you will need to open the PDF attachment and insert your password. Your password is your ID number. To view your statement you need to have Adobe PDF Reader installed. If you do not have it, you will need to do the following: - Copy and paste this URL into your browser: www.get.adobe.com/reader/?promoid=BUIGO - Go to the website - Click the download button and follow the easy instructions.


                        Regards,

                        Smart Saver",
                    PriorityRankID=(int)Priority.High,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                }

            };

            return emailTemplates.ToArray();

        }

        public static Titles[] GetTitles()
        {

            List<Titles> titleList = new List<Titles>();
            var titles = from Title t in Enum.GetValues(typeof(Title))
                         select new { ID = t, Name = t.ToString() };
            foreach (var title in titles)
            {
                titleList.Add(new Titles()
                {
                    TitleID = (int)title.ID,
                    Name = title.Name.Replace("_", " "),
                    IsActive = true,
                    IsDeleted = false,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                });
            }
            return titleList.ToArray();

        }

        public static ClientAccountType[] GetClientAccountTypes()
        {

            List<ClientAccountType> accountTypesList = new List<ClientAccountType>();
            var accountTypes = from Client_AccountType t in Enum.GetValues(typeof(Client_AccountType))
                               select new { ID = t, Name = t.ToString() };
            foreach (var accountType in accountTypes)
            {
                accountTypesList.Add(new ClientAccountType()
                {
                    ID = (int)accountType.ID,
                    Name = accountType.Name.Replace("_", " "),
                    IsActive = true,
                    IsDeleted = false,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                });
            }
            return accountTypesList.ToArray();

        }

        public static RecordStatus[] GetRecordStatuses()
        {

            List<RecordStatus> statusList = new List<RecordStatus>();
            var statuses = from RecordState t in Enum.GetValues(typeof(RecordState))
                           select new { ID = t, Name = t.ToString() };
            foreach (var status in statuses)
            {
                statusList.Add(new RecordStatus()
                {
                    RecordStatusID = (int)status.ID,
                    Name = status.Name.Replace("_", " "),
                    IsActive = true,
                    IsDeleted = false,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                });
            }
            return statusList.ToArray();

        }
        public static ClientGroup[] GetClientGroups()
        {

            List<ClientGroup>  clientGroups = new List<ClientGroup>();
            var p = from Affiliation s in Enum.GetValues(typeof(Affiliation))
                    select new { ID = s, Name = s.ToString() };

            foreach (var x in p)
            {
                clientGroups.Add(new ClientGroup()
                {
                    ClientGroupID = (int)x.ID,
                    Name = x.Name.Replace("_", " "),
                                     LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                });

            }
            return clientGroups.ToArray();
        }

        public static InvoiceStatus[] GetInvoiceStatuses()
        {

            List<InvoiceStatus> invoices = new List<InvoiceStatus>();
            var p = from InvoiceState s in Enum.GetValues(typeof(InvoiceState))
                    select new { ID = s, Name = s.ToString() };

            foreach (var x in p)
            {
                invoices.Add(new InvoiceStatus()
                {
                    InvoiceStatusID = (int)x.ID,
                    Name = x.Name.Replace("_", " "),
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                });

            }
            return invoices.ToArray();
        }
    }

}
