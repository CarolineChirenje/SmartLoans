#pragma checksum "C:\DEV\SmartWealth\SmartSave\Views\CustomSettings\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a2fed0c62deabc5feb7af252444bac434ebfaef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomSettings_Dashboard), @"mvc.1.0.view", @"/Views/CustomSettings/Dashboard.cshtml")]
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
#line 1 "C:\DEV\SmartWealth\SmartSave\Views\_ViewImports.cshtml"
using SmartSave;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DEV\SmartWealth\SmartSave\Views\_ViewImports.cshtml"
using SmartSave.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DEV\SmartWealth\SmartSave\Views\CustomSettings\Dashboard.cshtml"
using SmartHelper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a2fed0c62deabc5feb7af252444bac434ebfaef", @"/Views/CustomSettings/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1af0fb89db395063d8921ee12bbd8af94a13b0be", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomSettings_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<section class=\"content-header\">\r\n    <h1>\r\n        Dashboard\r\n        <small>");
#nullable restore
#line 7 "C:\DEV\SmartWealth\SmartSave\Views\CustomSettings\Dashboard.cshtml"
          Write(UtilityService.ApplicationName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
    </h1>
    <ol class=""breadcrumb"">
        <li><a href=""../Views/Home/Dashboard.cshtml""><i class=""fa fa-dashboard""></i>Settings Menu</a></li>
        <li class=""active"">Dashboard</li>
    </ol>
     </section>
<!-- Main content -->
<section class=""content"">
    <!-- Small boxes (Stat box) -->
 </section>
     ");
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
