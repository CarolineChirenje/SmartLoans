#pragma checksum "D:\Dev Projects\SmartSave\SmartSave\Views\Client\_MessageDisplay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffa75260a8f1ee09435b8a6eae8cc6ab9045a2f8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client__MessageDisplay), @"mvc.1.0.view", @"/Views/Client/_MessageDisplay.cshtml")]
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
#line 1 "D:\Dev Projects\SmartSave\SmartSave\Views\_ViewImports.cshtml"
using SmartSave;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Dev Projects\SmartSave\SmartSave\Views\_ViewImports.cshtml"
using SmartSave.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffa75260a8f1ee09435b8a6eae8cc6ab9045a2f8", @"/Views/Client/_MessageDisplay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1af0fb89db395063d8921ee12bbd8af94a13b0be", @"/Views/_ViewImports.cshtml")]
    public class Views_Client__MessageDisplay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n        <!-- /.box-header -->\r\n        <div class=\"box-body\">\r\n");
#nullable restore
#line 4 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\_MessageDisplay.cshtml"
             if (TempData["Error"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n                    <div class=\"text-danger\">");
#nullable restore
#line 6 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\_MessageDisplay.cshtml"
                                        Write(TempData["Error"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <br />\r\n");
#nullable restore
#line 9 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\_MessageDisplay.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"container\">\r\n                ");
#nullable restore
#line 11 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\_MessageDisplay.cshtml"
           Write(Html.ValidationSummary(false, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 13 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\_MessageDisplay.cshtml"
             if (TempData["Success"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n                    <div class=\"text-success\">");
#nullable restore
#line 15 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\_MessageDisplay.cshtml"
                                         Write(TempData["Success"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n");
#nullable restore
#line 17 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\_MessageDisplay.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\_MessageDisplay.cshtml"
             if (TempData["Warning"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n                    <div class=\"text-warning\">");
#nullable restore
#line 20 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\_MessageDisplay.cshtml"
                                         Write(TempData["Warning"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n");
#nullable restore
#line 22 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\_MessageDisplay.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("          \r\n        </div>\r\n\r\n     ");
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
