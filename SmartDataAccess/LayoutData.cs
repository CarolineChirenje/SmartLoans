using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace SmartDataAccess
{
    public static class LayoutData
    {
        public static Layout[] GetLayouts()
        {
            List<Layout> layouts = new List<Layout>();

            var layout = from LayoutComponent s in Enum.GetValues(typeof(LayoutComponent))
                         select new { ID = s, Name = s.ToString() };

            foreach (var x in layout)
            {
                layouts.Add(new Layout()
                {
                    LayoutID = (int)x.ID,
                    DisplayName = x.Name.Replace("_", " "),
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                });

            }
            return layouts.ToArray();

        }

        public static LayoutMenu[] GetLayoutMenus()
        {
            List<LayoutMenu> menus = new List<LayoutMenu>
            {
                new LayoutMenu()
                {
                    LayoutMenuID = 1,
                    LayoutID = (int)LayoutComponent.Client,
                    DisplayName = "Loans",
                    ControllerName = "Client",
                    ActionName = "Loans",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-bomb"),
                    OrderNo = 1,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                 new LayoutMenu()
                {
                    LayoutMenuID = 2,
                    LayoutID = (int)LayoutComponent.Client,
                    DisplayName = "Payments File",
                    ControllerName = "Client",
                    ActionName = "PaidTransactions",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-cc-mastercard"),
                    OrderNo = 2,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                new LayoutMenu()
                {
                    LayoutMenuID =3,
                    LayoutID = (int)LayoutComponent.Client,
                    DisplayName = "Outstanding Payments",
                    ControllerName = "Client",
                    ActionName = "PendingTransactions",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-credit-card"),
                    OrderNo = 3,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                new LayoutMenu()
                {
                    LayoutMenuID =4,
                    LayoutID = (int)LayoutComponent.Client,
                    DisplayName = "Statements",
                    ControllerName = "Client",
                    ActionName = "Statements",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-file"),
                    OrderNo = 4,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },

                 new LayoutMenu()
                {
                    LayoutMenuID =5,
                    LayoutID = (int)LayoutComponent.Client,
                    DisplayName = "Notes",
                    ControllerName = "Client",
                    ActionName = "Notes",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-comments"),
                    OrderNo = 5,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                 new LayoutMenu()
                {
                    LayoutMenuID =6,
                    LayoutID = (int)LayoutComponent.Client,
                    DisplayName = "Documents",
                    ControllerName = "Client",
                    ActionName = "Documents",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-book"),
                    OrderNo = 6,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                   new LayoutMenu()
                {
                    LayoutMenuID =7,
                    LayoutID = (int)LayoutComponent.Client,
                    DisplayName = "Dependents",
                    ControllerName = "Client",
                    ActionName = "Dependents",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-child"),
                    OrderNo = 7,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                   new LayoutMenu()
                {
                    LayoutMenuID =8,
                    LayoutID = (int)LayoutComponent.Client,
                    DisplayName = "Contacts",
                    ControllerName = "Client",
                    ActionName = "Contacts",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("glyphicon glyphicon-envelope"),
                    OrderNo = 8,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
               
               
                
                 new LayoutMenu()
                {
                    LayoutMenuID =9,
                    LayoutID = (int)LayoutComponent.Khonapo_Fund,
                    DisplayName = "Fund Set Up",
                    ControllerName = "Fund",
                    ActionName = "Fund",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-calculator"),
                    OrderNo =9,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser",
                    LinkRequiresID=false
                },
                    new LayoutMenu()
                {
                   LayoutMenuID =10,
                    LayoutID = (int)LayoutComponent.Khonapo_Fund,
                    DisplayName = "Fund Items",
                    ControllerName = "FundItem",
                    ActionName = "FundItems",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-navicon"),
                    OrderNo =10,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser",
                    LinkRequiresID=false
                },
                   new LayoutMenu()
                {
                    LayoutMenuID =11,
                    LayoutID = (int)LayoutComponent.Khonapo_Fund,
                    DisplayName = "Konapo Funds",
                    ControllerName = "KonapoFund",
                    ActionName = "KonapoFunds",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-line-chart"),
                    OrderNo =0,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser",
                      LinkRequiresID=false
                },
                   new LayoutMenu()
                {
                    LayoutMenuID =12,
                    LayoutID = (int)LayoutComponent.Developer_Menu,
                    DisplayName = "Support",
                    ControllerName = "Support",
                    ActionName = "Support",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-anchor"),
                    OrderNo =12,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },

                  new LayoutMenu()
                {
                    LayoutMenuID =13,
                    LayoutID = (int)LayoutComponent.Developer_Menu,
                    DisplayName = "Licence",
                    ControllerName = "Licence",
                    ActionName = "Licence",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa  fa-key"),
                    OrderNo =13,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
                },
                 new LayoutMenu()
                {
                    LayoutMenuID =14,
                    LayoutID = (int)LayoutComponent.Developer_Menu,
                    DisplayName = "Maintanance",
                    ControllerName = "Maintanance",
                    ActionName = "Maintanance",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-wrench"),
                    OrderNo =14,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                  new LayoutMenu()
                {
                    LayoutMenuID =15,
                    LayoutID = (int)LayoutComponent.Developer_Menu,
                    DisplayName = "Feature Flags",
                    ControllerName = "FeatureFlag",
                    ActionName = "FeatureFlag",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-building"),
                    OrderNo =15,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                 new LayoutMenu()
                {
                    LayoutMenuID =16,
                    LayoutID = (int)LayoutComponent.Settings,
                    DisplayName = "Application Settings",
                    ControllerName = "CustomSettings",
                    ActionName = "CustomSettings",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-spinner"),
                    OrderNo = 16,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
               },
                         new LayoutMenu()
                {
                    LayoutMenuID =17,
                    LayoutID = (int)LayoutComponent.Settings,
                    DisplayName = "User Management",
                    ControllerName = "User",
                    ActionName = "Users",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-users"),
                    OrderNo =17,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                new LayoutMenu()
                {
                    LayoutMenuID =18,
                    LayoutID = (int)LayoutComponent.Settings,
                    DisplayName = "Roles & Permissions",
                    ControllerName = "Roles",
                    ActionName = "Roles",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-asterisk"),
                    OrderNo = 18,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                new LayoutMenu()
                {
                    LayoutMenuID =19,
                    LayoutID = (int)LayoutComponent.Settings,
                    DisplayName = "Companies",
                    ControllerName = "Company",
                    ActionName = "Companies",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-building"),
                    OrderNo =19,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
                                    },

                new LayoutMenu()
                {
                    LayoutMenuID =20,
                    LayoutID = (int)LayoutComponent.Settings,
                    DisplayName = "Transaction Types",
                    ControllerName = "TransactionType",
                    ActionName = "TransactionType",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-money"),
                    OrderNo = 20,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                new LayoutMenu()
                {
                    LayoutMenuID =21,
                    LayoutID = (int)LayoutComponent.Settings,
                    DisplayName = "Loan Uses",
                    ControllerName = "LoanUse",
                    ActionName = "LoanUse",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-lightbulb-o"),
                    OrderNo =21,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
                },
                new LayoutMenu()
                {
                    LayoutMenuID =22,
                    LayoutID = (int)LayoutComponent.Settings,
                    DisplayName = "Banks",
                    ControllerName = "BankAccounts",
                    ActionName = "BankAccounts",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-university"),
                    OrderNo =22,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                new LayoutMenu()
                {
                    LayoutMenuID =23,
                    LayoutID = (int)LayoutComponent.Settings,
                    DisplayName = "Notice Board",
                    ControllerName = "NoticeBoard",
                    ActionName = "NoticeBoard",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-bell"),
                    OrderNo =23,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
               },
               new LayoutMenu()
                {
                    LayoutMenuID =24,
                    LayoutID = (int)LayoutComponent.Settings,
                    DisplayName = "Email Templates",
                    ControllerName = "EmailTemplate",
                    ActionName = "EmailTemplate",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-envelope-o"),
                    OrderNo =24,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
                },

               new LayoutMenu()
                {
                    LayoutMenuID =25,
                    LayoutID = (int)LayoutComponent.Settings,
                    DisplayName = "Departments",
                    ControllerName = "Department",
                    ActionName = "Department",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-building"),
                    OrderNo =25,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                new LayoutMenu()
                {
                    LayoutMenuID =26,
                    LayoutID = (int)LayoutComponent.Settings,
                    DisplayName = "Document Types",
                    ControllerName = "DocumentType",
                    ActionName = "DocumentTypes",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-file"),
                    OrderNo = 26,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
               },
                 new LayoutMenu()
                {
                    LayoutMenuID =27,
                    LayoutID = (int)LayoutComponent.Settings,
                    DisplayName = "Currency",
                    ControllerName = "Currency",
                    ActionName = "Currency",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-money"),
                    OrderNo =27,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
               new LayoutMenu()
                {
                    LayoutMenuID =28,
                    LayoutID = (int)LayoutComponent.Settings,
                    DisplayName = "Country",
                    ControllerName = "Country",
                    ActionName = "Country",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-globe"),
                    OrderNo =28,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
                },
                 new LayoutMenu()
                {
                    LayoutMenuID =29,
                    LayoutID = (int)LayoutComponent.Employees,
                    DisplayName = "My Account",
                    ControllerName = "Client",
                    ActionName = "MyAccount",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-heart"),
                    OrderNo = 29,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                 new LayoutMenu()
                {
                    LayoutMenuID =30,
                    LayoutID = (int)LayoutComponent.Employers,
                    DisplayName = "Employees",
                    ControllerName = "Client",
                    ActionName = "Clients",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-users"),
                    OrderNo = 30,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                 new LayoutMenu()
                {
                    LayoutMenuID =31,
                    LayoutID = (int)LayoutComponent.Settings,
                    DisplayName = "Loan Types",
                    ControllerName = "LoanType",
                    ActionName = "LoanType",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-lightbulb-o"),
                    OrderNo =31,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
                },
                  new LayoutMenu()
                {
                    LayoutMenuID =32,
                    LayoutID = (int)LayoutComponent.Settings,
                    DisplayName = "Loan Status",
                    ControllerName = "LoanStatus",
                    ActionName = "LoanStatus",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-lightbulb-o"),
                    OrderNo =32,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
                },
               
            };
            return menus.ToArray();

        }
    }
}
