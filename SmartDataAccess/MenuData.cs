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
                    MenuGroupID = (int)MenuGroups.Core_Services,
                    DisplayName = MenuGroups.Core_Services.ToString().Replace("_", " "),
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
                    MenuGroupID = (int)MenuGroups.Settings,
                    DisplayName = MenuGroups.Settings.ToString().Replace("_", " "),
                    IsActive = true,
                    IsActiveMenu = false,
                    CSSClass = UtilityService.HtmlDecode("fa fa-wrench"),
                    OrderNo = 7,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
                },
                  new MenuGroup()
                {
                    MenuGroupID = (int)MenuGroups.Programmes,
                    DisplayName = MenuGroups.Programmes.ToString().Replace("_", " "),
                    IsActive = true,
                    IsActiveMenu = false,
                    CSSClass = UtilityService.HtmlDecode("fa fa-graduation-cap"),
                    OrderNo = 8,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
                },
                    new MenuGroup()
                {
                    MenuGroupID = (int)MenuGroups.Konapo,
                    DisplayName = MenuGroups.Konapo.ToString().Replace("_", " "),
                    IsActive = true,
                    IsActiveMenu = false,
                    CSSClass = UtilityService.HtmlDecode("fa fa-line-chart"),
                    OrderNo = 5,
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
                 new MenuGroup()
                {
                    MenuGroupID = (int)MenuGroups.Invoicing,
                    DisplayName = MenuGroups.Invoicing.ToString().Replace("_", " "),
                    IsActive = true,
                    IsActiveMenu = false,
                    CSSClass = UtilityService.HtmlDecode("fa fa-bullseye"),
                    OrderNo = 4,
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
                    MenuID =3,
                    MenuGroupID = (int)MenuGroups.Konapo,
                    DisplayName = "Konapo Fund",
                    ControllerName = "KonapoFund",
                    ActionName = "KonapoFunds",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-calculator"),
                    OrderNo = 3,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                new Menu()
                {
                    MenuID = 4,
                    MenuGroupID = (int)MenuGroups.Core_Services,
                    DisplayName = "Transactions",
                    ControllerName = "Transactions",
                    ActionName = "Transactions",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-money"),
                    OrderNo = 4,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                   new Menu()
                {
                    MenuID = 5,
                    MenuGroupID = (int)MenuGroups.Invoicing,
                    DisplayName = "Invoices",
                    ControllerName = "Transactions",
                    ActionName = "Invoices",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-gear"),
                    OrderNo = 5,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },

                new Menu()
                {
                    MenuID = 6,
                    MenuGroupID = (int)MenuGroups.Core_Services,
                    DisplayName = "Products",
                    ControllerName = "Product",
                    ActionName = "Product",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-bomb"),
                    OrderNo =6,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
                },

                new Menu()
                {
                    MenuID = 7,
                    MenuGroupID = (int)MenuGroups.Programmes,
                    DisplayName = "Coaching Programmes",
                    ControllerName = "Courses",
                    ActionName = "Courses",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-university"),
                    OrderNo = 7,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },

                  new Menu()
                {
                    MenuID= 8,
                    MenuGroupID = (int)MenuGroups.Reporting,
                    DisplayName = "Reports",
                    ControllerName = "Reporting",
                    ActionName = "DashBoard",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fas fa-registered"),
                    OrderNo =8,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"
                },
                    new Menu()
                {
                    MenuID =9,
                    MenuGroupID = (int)MenuGroups.Settings,
                    DisplayName = "Parameters",
                    ControllerName = "CustomSettings",
                    ActionName = "Dashboard",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-gear"),
                    OrderNo = 9,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                 
                
              // put new menu here
              
                  new Menu()
                {
                    MenuID =9994,
                    MenuGroupID = (int)MenuGroups.Developer_Menu,
                    DisplayName = "Technical Menu",
                    ControllerName = "FeatureFlag",
                    ActionName = "Dashboard",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-desktop"),
                    OrderNo =9994,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                new Menu()
                {
                    MenuID = 9995,
                    MenuGroupID = (int)MenuGroups.Menu,
                    DisplayName = "Layout",
                    ControllerName = "Layouts",
                    ActionName = "Layouts",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-bars"),
                    OrderNo = 9995,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                 new Menu()
                {
                    MenuID = 9996,
                    MenuGroupID = (int)MenuGroups.Menu,
                    DisplayName = "Main Menu",
                    ControllerName = "Menus",
                    ActionName = "MainMenu",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-book"),
                    OrderNo = 9996,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },


            };
            return menus.ToArray();

        }
    }


}
