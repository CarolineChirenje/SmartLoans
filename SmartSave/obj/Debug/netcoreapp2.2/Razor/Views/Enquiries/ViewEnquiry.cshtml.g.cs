#pragma checksum "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewEnquiry.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ed3ce00a17081028065d8761a7fc2b152805139"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Enquiries_ViewEnquiry), @"mvc.1.0.view", @"/Views/Enquiries/ViewEnquiry.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Enquiries/ViewEnquiry.cshtml", typeof(AspNetCore.Views_Enquiries_ViewEnquiry))]
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
#line 1 "D:\Dev Projects\SmartFin\SmartAdmin\Views\_ViewImports.cshtml"
using SmartAdmin;

#line default
#line hidden
#line 2 "D:\Dev Projects\SmartFin\SmartAdmin\Views\_ViewImports.cshtml"
using SmartAdmin.Models;

#line default
#line hidden
#line 2 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewEnquiry.cshtml"
using SmartHelper;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ed3ce00a17081028065d8761a7fc2b152805139", @"/Views/Enquiries/ViewEnquiry.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9906be48bf7b893089acfeca7d3efff7da363c1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Enquiries_ViewEnquiry : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartDomain.Enquiry>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Enquiry", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewEnquiry", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Enquiry/ViewEnquiry"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(50, 294, true);
            WriteLiteral(@"<section class=""content-header"">
    <h1>
        Enquiry
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <!-- Horizontal Form -->
    <div class=""box box-info"">
        <div class=""box-header with-border"">

            <h3 class=""box-title"">");
            EndContext();
            BeginContext(345, 11, false);
#line 14 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewEnquiry.cshtml"
                             Write(Model.RefNo);

#line default
#line hidden
            EndContext();
            BeginContext(356, 91, true);
            WriteLiteral("</h3>\r\n        </div>\r\n        <!-- /.box-header -->\r\n        <!-- form start -->\r\n        ");
            EndContext();
            BeginContext(447, 4320, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ed3ce00a17081028065d8761a7fc2b1528051396940", async() => {
                BeginContext(521, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 19 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewEnquiry.cshtml"
             if (ViewData["Error"] != null)
            {

#line default
#line hidden
                BeginContext(581, 62, true);
                WriteLiteral("<div class=\"container\">\r\n                    <strong class=\"\">");
                EndContext();
                BeginContext(644, 28, false);
#line 21 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewEnquiry.cshtml"
                                Write(ViewData["Error"].ToString());

#line default
#line hidden
                EndContext();
                BeginContext(672, 113, true);
                WriteLiteral("</strong>\r\n                    <div class=\"panel panel-danger\">\r\n                        <div class=\"panel-body\">");
                EndContext();
                BeginContext(786, 24, false);
#line 23 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewEnquiry.cshtml"
                                           Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(810, 60, true);
                WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n");
                EndContext();
#line 26 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewEnquiry.cshtml"
            }

#line default
#line hidden
                BeginContext(885, 301, true);
                WriteLiteral(@"             <div class=""box-body"">

                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Email</label>
                    <div class=""col-sm-10"">
                        <input type=""email"" class=""form-control"" name=""EmailAddress""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1186, "\"", 1213, 1);
#line 32 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewEnquiry.cshtml"
WriteAttributeValue("", 1194, Model.EmailAddress, 1194, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1214, 355, true);
                WriteLiteral(@">
                    </div>
                </div>
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Contact Number</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""ContactNumber"" placeholder=""Contact Number""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1569, "\"", 1597, 1);
#line 38 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewEnquiry.cshtml"
WriteAttributeValue("", 1577, Model.ContactNumber, 1577, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1598, 311, true);
                WriteLiteral(@">
                    </div>
                </div>

                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Issue Details</label>
                    <div class=""col-sm-10"">
                        <textarea class=""form-control"" name=""Query"">");
                EndContext();
                BeginContext(1910, 11, false);
#line 45 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewEnquiry.cshtml"
                                                               Write(Model.Query);

#line default
#line hidden
                EndContext();
                BeginContext(1921, 406, true);
                WriteLiteral(@"</textarea>
                    </div>
                </div>
            </div>

            <div class=""form-group"">
                <label for=""inputEmail3"" class=""col-sm-2 control-label"">Active Status</label>
                <div class=""col-sm-2"">

                    <label class=""checkbox-inline"">
                        <input type=""checkbox"" class=""minimal"" name=""IsActive"" value=""true""");
                EndContext();
                BeginWriteAttribute("checked", " checked=\"", 2327, "\"", 2352, 1);
#line 55 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewEnquiry.cshtml"
WriteAttributeValue("", 2337, Model.IsActive, 2337, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2353, 411, true);
                WriteLiteral(@" />
                    </label>
                    <input type=""hidden"" name=""IsActive"" value=""false"" />
                </div>
            </div>

            <div class=""form-group"">
                <label for=""inputEmail3"" class=""col-sm-2 control-label"">LastChanged By</label>
                <div class=""col-sm-10"">
                    <label for=""inputEmail3"" class=""form-control label-default"">");
                EndContext();
                BeginContext(2765, 19, false);
#line 64 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewEnquiry.cshtml"
                                                                           Write(Model.LastChangedBy);

#line default
#line hidden
                EndContext();
                BeginContext(2784, 309, true);
                WriteLiteral(@"</label>
                </div>
            </div>

            <div class=""form-group"">
                <label for=""inputEmail3"" class=""col-sm-2 control-label"">Last Updated</label>
                <div class=""col-sm-10"">
                    <label for=""inputEmail3"" class=""form-control label-default"">");
                EndContext();
                BeginContext(3094, 51, false);
#line 71 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewEnquiry.cshtml"
                                                                           Write(UtilityService.ShowDateTime(@Model.LastChangedDate));

#line default
#line hidden
                EndContext();
                BeginContext(3145, 246, true);
                WriteLiteral("</label>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label for=\"inputEmail3\" class=\"col-sm-2 control-label\">Responses</label>\r\n                <div class=\"col-sm-10\">\r\n                    ");
                EndContext();
                BeginContext(3391, 119, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ed3ce00a17081028065d8761a7fc2b15280513913815", async() => {
                    BeginContext(3477, 29, false);
#line 78 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewEnquiry.cshtml"
                                                                                                    Write(Model.EnquiryDetails?.Count());

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 78 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewEnquiry.cshtml"
                                                                           WriteLiteral(Model.EnquiryID);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3510, 303, true);
                WriteLiteral(@"
                </div>
            </div>

            <div class=""form-group"">
                <label for=""inputEmail3"" class=""col-sm-2 control-label"">LastChanged By</label>
                <div class=""col-sm-10"">
                    <label for=""inputEmail3"" class=""form-control label-default"">");
                EndContext();
                BeginContext(3814, 19, false);
#line 85 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewEnquiry.cshtml"
                                                                           Write(Model.LastChangedBy);

#line default
#line hidden
                EndContext();
                BeginContext(3833, 309, true);
                WriteLiteral(@"</label>
                </div>
            </div>

            <div class=""form-group"">
                <label for=""inputEmail3"" class=""col-sm-2 control-label"">Last Updated</label>
                <div class=""col-sm-10"">
                    <label for=""inputEmail3"" class=""form-control label-default"">");
                EndContext();
                BeginContext(4143, 51, false);
#line 92 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewEnquiry.cshtml"
                                                                           Write(UtilityService.ShowDateTime(@Model.LastChangedDate));

#line default
#line hidden
                EndContext();
                BeginContext(4194, 103, true);
                WriteLiteral("</label>\r\n                </div>\r\n            </div>\r\n            <input type=\"hidden\" name=\"EnquiryID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4297, "\"", 4321, 1);
#line 95 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewEnquiry.cshtml"
WriteAttributeValue("", 4305, Model.EnquiryID, 4305, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4322, 103, true);
                WriteLiteral(" />\r\n                       <!-- /.box-body -->\r\n            <div class=\"box-footer\">\r\n                ");
                EndContext();
                BeginContext(4425, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ed3ce00a17081028065d8761a7fc2b15280513918850", async() => {
                    BeginContext(4497, 6, true);
                    WriteLiteral("Cancel");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4507, 108, true);
                WriteLiteral("\r\n                <button type=\"submit\" class=\"btn btn-info pull-right\">Respond</button> |\r\n                ");
                EndContext();
                BeginContext(4615, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ed3ce00a17081028065d8761a7fc2b15280513920726", async() => {
                    BeginContext(4687, 4, true);
                    WriteLiteral("Move");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4695, 65, true);
                WriteLiteral("\r\n            </div>\r\n            <!-- /.box-footer -->\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4767, 44, true);
            WriteLiteral("\r\n    </div>\r\n    <!-- /.box -->\r\n</section>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartDomain.Enquiry> Html { get; private set; }
    }
}
#pragma warning restore 1591
