#pragma checksum "C:\DEV\SmartWealth\SmartSave\Views\Courses\AddCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bcaf4b7467492e0cfd380322525f20227dc93ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_AddCourse), @"mvc.1.0.view", @"/Views/Courses/AddCourse.cshtml")]
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
#line 2 "C:\DEV\SmartWealth\SmartSave\Views\Courses\AddCourse.cshtml"
using SmartHelper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bcaf4b7467492e0cfd380322525f20227dc93ac", @"/Views/Courses/AddCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1af0fb89db395063d8921ee12bbd8af94a13b0be", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_AddCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartDomain.Department>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Courses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Courses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("AddCourse"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Content Header (Page header) -->
<section class=""content-header"">
    <h1>
        Courses
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <!-- Horizontal Form -->
    <div class=""box box-info"">
        <div class=""box-header with-border"">
            <h3 class=""box-title"">Add Courses</h3>
        </div>
        <!-- /.box-header -->
        <!-- form start -->
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bcaf4b7467492e0cfd380322525f20227dc93ac5879", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 20 "C:\DEV\SmartWealth\SmartSave\Views\Courses\AddCourse.cshtml"
             if (TempData["Error"] != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"container\">\r\n                    <div class=\"text-danger\">");
#nullable restore
#line 22 "C:\DEV\SmartWealth\SmartSave\Views\Courses\AddCourse.cshtml"
                                        Write(TempData["Error"].ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                </div>\r\n                <br />\r\n");
#nullable restore
#line 25 "C:\DEV\SmartWealth\SmartSave\Views\Courses\AddCourse.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"container\">\r\n                ");
#nullable restore
#line 27 "C:\DEV\SmartWealth\SmartSave\Views\Courses\AddCourse.cshtml"
           Write(Html.ValidationSummary(false, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n");
#nullable restore
#line 30 "C:\DEV\SmartWealth\SmartSave\Views\Courses\AddCourse.cshtml"
             if (TempData["Success"] != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"container\">\r\n                    <div class=\"text-success\">");
#nullable restore
#line 32 "C:\DEV\SmartWealth\SmartSave\Views\Courses\AddCourse.cshtml"
                                         Write(TempData["Success"].ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                </div>\r\n");
#nullable restore
#line 34 "C:\DEV\SmartWealth\SmartSave\Views\Courses\AddCourse.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\DEV\SmartWealth\SmartSave\Views\Courses\AddCourse.cshtml"
             if (TempData["Warning"] != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"container\">\r\n                    <div class=\"text-warning\">");
#nullable restore
#line 37 "C:\DEV\SmartWealth\SmartSave\Views\Courses\AddCourse.cshtml"
                                         Write(TempData["Warning"].ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                </div>\r\n");
#nullable restore
#line 39 "C:\DEV\SmartWealth\SmartSave\Views\Courses\AddCourse.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <div class=""box-body"">
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Title</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""Title"" placeholder=""Title"" required>

                    </div>
                </div>

                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Status</label>
                    <div class=""checkbox"">
                        <label class=""checkbox-inline"">
                            <input type=""checkbox"" data-val=""true"" id=""IsActive""
                                   name=""IsActive"" value=""true"">
                        </label>
                    </div>
                </div>
            </div>
            <!-- /.box-body -->
            <div class=""box-footer"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3bcaf4b7467492e0cfd380322525f20227dc93ac9867", async() => {
                    WriteLiteral("Cancel");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 62 "C:\DEV\SmartWealth\SmartSave\Views\Courses\AddCourse.cshtml"
                 if (UtilityService.HasPermission(Permissions.Add_Course))
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <button type=\"submit\" class=\"btn btn-info pull-right\">Create</button>\r\n");
#nullable restore
#line 65 "C:\DEV\SmartWealth\SmartSave\Views\Courses\AddCourse.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n            <!-- /.box-footer -->\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <!-- /.box -->\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartDomain.Department> Html { get; private set; }
    }
}
#pragma warning restore 1591
