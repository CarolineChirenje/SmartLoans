using SmartDomain;
using SmartHelper;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDataAccess
{
   public class MenuData
    {
        public static MenuGroup[] GetMenuGroups()
        {
            List<MenuGroup> parentMenus = new List<MenuGroup>
            {
                new MenuGroup()
                {
                    MenuGroupID = (int)MenuGroups.DashBoard,
                    DisplayName = MenuGroups.DashBoard.ToString().Replace("_", " "),
                    ControllerName = "Home",
                    ActionName = "Dashboard",
                    IsActive = true,
                    IsActiveMenu = false,
                    CSSClass = UtilityService.HtmlDecode("fa fa-umbrella"),
                    OrderNo = 1,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                new MenuGroup()
                {
                    MenuGroupID = (int)MenuGroups.Employees,
                    DisplayName = MenuGroups.Employees.ToString().Replace("_", " "),
                    IsActive = true,
                    IsActiveMenu = false,
                    CSSClass = UtilityService.HtmlDecode("fa fa-users"),
                    OrderNo = 2,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                   new MenuGroup()
                {
                    MenuGroupID = (int)MenuGroups.Product_And_Services,
                    DisplayName = MenuGroups.Product_And_Services.ToString().Replace("_", " "),
                    IsActive = true,
                    IsActiveMenu = false,
                    CSSClass = UtilityService.HtmlDecode("fa fa-money"),
                    OrderNo = 3,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },

             
                 new MenuGroup()
                {
                    MenuGroupID = (int)MenuGroups.Reporting,
                    DisplayName = MenuGroups.Reporting.ToString().Replace("_", " "),
                    IsActive = true,
                    IsActiveMenu = false,
                    CSSClass = UtilityService.HtmlDecode("fa fa-area-chart"),
                    OrderNo = 6,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                new MenuGroup()
                {
                    MenuGroupID = (int)MenuGroups.Custom_Settings,
                    DisplayName = MenuGroups.Custom_Settings.ToString().Replace("_", " "),
                    IsActive = true,
                    IsActiveMenu = false,
                    CSSClass = UtilityService.HtmlDecode("fa fa-wrench"),
                    OrderNo = 7,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
               
                new MenuGroup()
                {
                    MenuGroupID = (int)MenuGroups.Menu,
                    DisplayName = MenuGroups.Menu.ToString().Replace("_", " "),
                    IsActive = true,
                    IsActiveMenu = false,
                    CSSClass = UtilityService.HtmlDecode("fa fa-university"),
                    OrderNo = 9998,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                new MenuGroup()
                {
                    MenuGroupID = (int)MenuGroups.Developer_Menu,
                    DisplayName = MenuGroups.Developer_Menu.ToString().Replace("_", " "),
                    IsActive = true,
                    IsActiveMenu = false,
                    CSSClass = UtilityService.HtmlDecode("fa fa-desktop"),
                    OrderNo = 9999,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                
            };

            return parentMenus.ToArray();

        }

        public static Menu[] GetMenus()
        {
            List<Menu> menus = new List<Menu>
            {
                new Menu()
                {
                    MenuID = 1,
                    MenuGroupID = (int)MenuGroups.Employees,
                    DisplayName = "Employees",
                    ControllerName = "Client",
                    ActionName = "Clients",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-users"),
                    OrderNo = 1,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                 new Menu()
                {
                    MenuID = 2,
                    MenuGroupID = (int)MenuGroups.Employees,
                    DisplayName = "My Account",
                    ControllerName = "Client",
                    ActionName = "MyAccount",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-heart"),
                    OrderNo = 0,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                new Menu()
                {
                    MenuID = 3,
                    MenuGroupID = (int)MenuGroups.Product_And_Services,
                    DisplayName = "Transactions",
                    ControllerName = "Transactions",
                    ActionName = "Transactions",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-money"),
                    OrderNo = 2,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                   new Menu()
                {
                    MenuID = 4,
                    MenuGroupID = (int)MenuGroups.Product_And_Services,
                    DisplayName = "Generate Bulk Invoice",
                    ControllerName = "Transactions",
                    ActionName = "Schedule",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-gear"),
                    OrderNo = 4,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                 new Menu()
                {
                    MenuID = 5,
                    MenuGroupID = (int)MenuGroups.Product_And_Services,
                    DisplayName = "Generated Invoices",
                    ControllerName = "Transactions",
                    ActionName = "ScheduleReport",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-file"),
                    OrderNo =5,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },

                new Menu()
                {
                    MenuID = 6,
                    MenuGroupID = (int)MenuGroups.Product_And_Services,
                    DisplayName = "Products",
                    ControllerName = "Product",
                    ActionName = "Product",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-product-hunt"),
                    OrderNo =6,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
                },
                new Menu()
                {
                    MenuID =7,
                    MenuGroupID = (int)MenuGroups.Custom_Settings,
                    DisplayName = "Application Settings",
                    ControllerName = "CustomSettings",
                    ActionName = "CustomSettings",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-spinner"),
                    OrderNo = 7,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
               },
                new Menu()
                {
                    MenuID =8,
                    MenuGroupID = (int)MenuGroups.Custom_Settings,
                    DisplayName = "User Management",
                    ControllerName = "User",
                    ActionName = "Users",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-users"),
                    OrderNo = 8,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                new Menu()
                {
                    MenuID = 9,
                    MenuGroupID = (int)MenuGroups.Custom_Settings,
                    DisplayName = "Roles & Permissions",
                    ControllerName = "Roles",
                    ActionName = "Roles",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-asterisk"),
                    OrderNo = 9,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },

                new Menu()
                {
                    MenuID = 10,
                    MenuGroupID = (int)MenuGroups.Custom_Settings,
                    DisplayName = "Coaching Programmes",
                    ControllerName = "Courses",
                    ActionName = "Courses",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-university"),
                    OrderNo = 10,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                  new Menu()
                {
                    MenuID =11,
                    MenuGroupID = (int)MenuGroups.Custom_Settings,
                    DisplayName = "Companies",
                    ControllerName = "Company",
                    ActionName = "Companies",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-building"),
                    OrderNo =11,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                
                  new Menu()
                {
                    MenuID =12,
                    MenuGroupID = (int)MenuGroups.Custom_Settings,
                    DisplayName = "Transaction Types",
                    ControllerName = "TransactionType",
                    ActionName = "TransactionType",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-money"),
                    OrderNo = 12,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                 new Menu()
                {
                    MenuID =13,
                    MenuGroupID = (int)MenuGroups.Custom_Settings,
                    DisplayName = "Asserts",
                    ControllerName = "Assert",
                    ActionName = "Assert",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-lightbulb-o"),
                    OrderNo =13,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
                },
                 new Menu()
                {
                    MenuID =14,
                    MenuGroupID = (int)MenuGroups.Custom_Settings,
                    DisplayName = "Banks",
                    ControllerName = "BankAccounts",
                    ActionName = "BankAccounts",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-university"),
                    OrderNo =14,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                 new Menu()
                {
                    MenuID = 15,
                    MenuGroupID = (int)MenuGroups.Custom_Settings,
                    DisplayName = "Notice Board",
                    ControllerName = "NoticeBoard",
                    ActionName = "NoticeBoard",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa broadcast-tower"),
                    OrderNo =15,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
               },
                new Menu()
                {
                    MenuID =16,
                    MenuGroupID = (int)MenuGroups.Custom_Settings,
                    DisplayName = "Email Templates",
                    ControllerName = "EmailTemplate",
                    ActionName = "EmailTemplate",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-envelope-o"),
                    OrderNo =16,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },

                new Menu()
                {
                    MenuID =17,
                    MenuGroupID = (int)MenuGroups.Custom_Settings,
                    DisplayName = "Departments",
                    ControllerName = "Department",
                    ActionName = "Department",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-building"),
                    OrderNo =17,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                new Menu()
                {
                    MenuID = 18,
                    MenuGroupID = (int)MenuGroups.Custom_Settings,
                    DisplayName = "Document Types",
                    ControllerName = "DocumentType",
                    ActionName = "DocumentTypes",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-file"),
                    OrderNo = 18,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
               },
          
                
                 new Menu()
                {
                    MenuID =19,
                    MenuGroupID = (int)MenuGroups.Custom_Settings,
                    DisplayName = "Currency",
                    ControllerName = "Currency",
                    ActionName = "Currency",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-money"),
                    OrderNo =19,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                 new Menu()
                {
                    MenuID =20,
                    MenuGroupID = (int)MenuGroups.Custom_Settings,
                    DisplayName = "Country",
                    ControllerName = "Country",
                    ActionName = "Country",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-globe"),
                    OrderNo =20,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },

              // put new menu here
               
                 new Menu()
                {
                    MenuID = 9998,
                    MenuGroupID = (int)MenuGroups.Menu,
                    DisplayName = "Menu",
                    ControllerName = "Menus",
                    ActionName = "MainMenu",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-book"),
                    OrderNo = 9998,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },

                 new Menu()
                {
                    MenuID =9999,
                    MenuGroupID = (int)MenuGroups.Developer_Menu,
                    DisplayName = "Feature Flags",
                    ControllerName = "FeatureFlag",
                    ActionName = "FeatureFlag",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-building"),
                    OrderNo =9999,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
            };
            return menus.ToArray();

        }
    }
}
