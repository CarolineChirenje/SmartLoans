#pragma checksum "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73298177bb45ce90ec7fd8efa85b1dce22831ccb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_MenuList_MainMenu), @"mvc.1.0.view", @"/Views/Shared/Components/MenuList/MainMenu.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\_ViewImports.cshtml"
using SmartLoan.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
using SmartLoan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
using SmartHelper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73298177bb45ce90ec7fd8efa85b1dce22831ccb", @"/Views/Shared/Components/MenuList/MainMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a83c5e5401d63e9f19604f61ec10fe4c4974d7dd", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a83c5e5401d63e9f19604f61ec10fe4c4974d7dd", @"/Views/Shared/_ViewImports.cshtml")]
    public class Views_Shared_Components_MenuList_MainMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<ul class=\"sidebar-menu\" data-widget=\"tree\">\r\n    <li class=\"header\">");
#nullable restore
#line 4 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
                  Write(UserAppData.ApplicationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 5 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
     if (UtilityService.ApplyRoleBasedMenus)
    {
        List<int> _roleMenus = UtilityService.GetRoleMenus;
        List<int> _roleMenuGroups = UtilityService.GetRoleMenusGroups;



        

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
         foreach (var item in Model)
        {

            if (_roleMenuGroups.Contains(item.MenuGroupID))
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <li");
            BeginWriteAttribute("class", " class=\"", 484, "\"", 519, 2);
            WriteAttributeValue("", 492, "treeview", 492, 8, true);
#nullable restore
#line 18 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
WriteAttributeValue(" ", 500, item.IsActiveMenu, 501, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73298177bb45ce90ec7fd8efa85b1dce22831ccb5579", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
                          
                            var parentCSS = UtilityService.HtmlEncode(item.CSSClass);
                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <i");
                BeginWriteAttribute("class", " class=\"", 761, "\"", 779, 1);
#nullable restore
#line 23 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
WriteAttributeValue("", 769, parentCSS, 769, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i> <span>");
#nullable restore
#line 23 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
                                                    Write(item.DisplayName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                        <span class=\"pull-right-container\">\r\n                            <i class=\"fa fa-angle-left pull-right\"></i>\r\n                        </span>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <ul class=\"treeview-menu\">\r\n");
#nullable restore
#line 29 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
                          
                            List<SmartDomain.Menu> _menus = item.Menus;
                            var menuList = _menus.Where(m => _roleMenus.Contains(m.MenuID)).ToList();

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
                         foreach (var menu in menuList)
                        {
                            var menuCSS = UtilityService.HtmlEncode(menu.CSSClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li class=\"nav-item\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73298177bb45ce90ec7fd8efa85b1dce22831ccb9049", async() => {
                WriteLiteral("\r\n                                    <i");
                BeginWriteAttribute("class", " class=\"", 1655, "\"", 1680, 2);
#nullable restore
#line 39 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
WriteAttributeValue("", 1663, menuCSS, 1663, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1671, "nav-icon", 1672, 9, true);
                EndWriteAttribute();
                WriteLiteral("></i>");
#nullable restore
#line 39 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
                                                                Write(menu.DisplayName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
                                       WriteLiteral(menu.ControllerName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 38 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
                                                                         WriteLiteral(menu.ActionName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </li>\r\n");
#nullable restore
#line 42 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </ul>\r\n                </li>\r\n");
#nullable restore
#line 47 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
         
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li");
            BeginWriteAttribute("class", " class=\"", 1973, "\"", 2008, 2);
            WriteAttributeValue("", 1981, "treeview", 1981, 8, true);
#nullable restore
#line 54 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
WriteAttributeValue(" ", 1989, item.IsActiveMenu, 1990, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73298177bb45ce90ec7fd8efa85b1dce22831ccb13638", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 56 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
                      
                        var parentCSS = UtilityService.HtmlEncode(item.CSSClass);
                    

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <i");
                BeginWriteAttribute("class", " class=\"", 2230, "\"", 2248, 1);
#nullable restore
#line 59 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
WriteAttributeValue("", 2238, parentCSS, 2238, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></i> <span>");
#nullable restore
#line 59 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
                                                Write(item.DisplayName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                    <span class=\"pull-right-container\">\r\n                        <i class=\"fa fa-angle-left pull-right\"></i>\r\n                    </span>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <ul class=\"treeview-menu\">\r\n");
#nullable restore
#line 65 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
                     foreach (var menu in item.Menus)
                    {
                        var menuCSS = UtilityService.HtmlEncode(menu.CSSClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"nav-item\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "73298177bb45ce90ec7fd8efa85b1dce22831ccb16656", async() => {
                WriteLiteral("\r\n                            <i");
                BeginWriteAttribute("class", " class=\"", 2837, "\"", 2862, 2);
#nullable restore
#line 70 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
WriteAttributeValue("", 2845, menuCSS, 2845, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 2853, "nav-icon", 2854, 9, true);
                EndWriteAttribute();
                WriteLiteral("></i>");
#nullable restore
#line 70 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
                                                        Write(menu.DisplayName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
                               WriteLiteral(menu.ControllerName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
                                                                 WriteLiteral(menu.ActionName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </li>\r\n");
#nullable restore
#line 73 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </li>\r\n");
#nullable restore
#line 76 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\DEV\SmartLoans\SmartLoans\Views\Shared\Components\MenuList\MainMenu.cshtml"
         

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591