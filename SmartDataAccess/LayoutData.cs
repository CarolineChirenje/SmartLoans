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
                    DisplayName = "Products",
                    ControllerName = "Client",
                    ActionName = "Products",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fas fa-star"),
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
                    CSSClass = UtilityService.HtmlDecode("fas fa-battery-empty"),
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
                    DisplayName = "Coaching Programmes",
                    ControllerName = "Client",
                    ActionName = "Courses",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-graduation-cap"),
                    OrderNo =5,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                 new LayoutMenu()
                {
                    LayoutMenuID =6,
                    LayoutID = (int)LayoutComponent.Client,
                    DisplayName = "Notes",
                    ControllerName = "Client",
                    ActionName = "Notes",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-comments"),
                    OrderNo = 6,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                 new LayoutMenu()
                {
                    LayoutMenuID =7,
                    LayoutID = (int)LayoutComponent.Client,
                    DisplayName = "Documents",
                    ControllerName = "Client",
                    ActionName = "Documents",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-book"),
                    OrderNo = 7,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                   new LayoutMenu()
                {
                    LayoutMenuID =8,
                    LayoutID = (int)LayoutComponent.Client,
                    DisplayName = "Dependents",
                    ControllerName = "Client",
                    ActionName = "Dependents",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-child"),
                    OrderNo = 8,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                   new LayoutMenu()
                {
                    LayoutMenuID =9,
                    LayoutID = (int)LayoutComponent.Client,
                    DisplayName = "Contacts",
                    ControllerName = "Client",
                    ActionName = "Contacts",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fas fa-address-book"),
                    OrderNo = 9,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                  new LayoutMenu()
                {
                    LayoutMenuID =10,
                    LayoutID = (int)LayoutComponent.Client,
                    DisplayName = "Medical Files",
                    ControllerName = "Client",
                    ActionName = "MedicalFiles",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-stethoscope"),
                    OrderNo = 10,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                   new LayoutMenu()
                {
                    LayoutMenuID =11,
                    LayoutID = (int)LayoutComponent.Client,
                    DisplayName = "Attendance Register",
                    ControllerName = "Client",
                    ActionName = "AttendanceRegisters",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fa fa-pencil fa-fw"),
                    OrderNo = 11,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
                    new LayoutMenu()
                {
                    LayoutMenuID =12,
                    LayoutID = (int)LayoutComponent.Client,
                    DisplayName = "Finalised Deductions",
                    ControllerName = "Client",
                    ActionName = "Deductions",
                    IsActive = true,
                    CSSClass = UtilityService.HtmlDecode("fas fa-copy"),
                    OrderNo = 12,
                    LastChangedDate = DateTime.Now,
                    LastChangedBy = "SuperUser"

                },
            };
            return menus.ToArray();

        }
    }
}
