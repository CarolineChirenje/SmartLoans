#pragma checksum "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewResponses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb7ec25109cb6e49d633cb7b965c13c2dc9b5953"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Enquiries_ViewResponses), @"mvc.1.0.view", @"/Views/Enquiries/ViewResponses.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Enquiries/ViewResponses.cshtml", typeof(AspNetCore.Views_Enquiries_ViewResponses))]
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
#line 2 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewResponses.cshtml"
using SmartHelper;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb7ec25109cb6e49d633cb7b965c13c2dc9b5953", @"/Views/Enquiries/ViewResponses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9906be48bf7b893089acfeca7d3efff7da363c1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Enquiries_ViewResponses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmartDomain.EnquiryDetail>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Dashboard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Enquiries", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewEnquiry", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bower_components/datatables.net/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewResponses.cshtml"
  
    ViewData["Title"] = "Enquiries";

#line default
#line hidden
            BeginContext(113, 54, true);
            WriteLiteral("\r\n<section class=\"content-header\">\r\n    <h1>\r\n        ");
            EndContext();
            BeginContext(168, 17, false);
#line 9 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewResponses.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(185, 54, true);
            WriteLiteral("\r\n    </h1>\r\n    <ol class=\"breadcrumb\">\r\n        <li>");
            EndContext();
            BeginContext(239, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb7ec25109cb6e49d633cb7b965c13c2dc9b59535895", async() => {
                BeginContext(266, 36, true);
                WriteLiteral("<i class=\"fa fa-dashboard\"></i> Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(306, 34, true);
            WriteLiteral("</li>\r\n        <li class=\"active\">");
            EndContext();
            BeginContext(341, 17, false);
#line 13 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewResponses.cshtml"
                      Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(358, 251, true);
            WriteLiteral("</li>\r\n    </ol>\r\n</section>\r\n<!-- Main content -->\r\n<section class=\"content\">\r\n    <div class=\"row\">\r\n        <div class=\"col-xs-12\">\r\n            <div class=\"box\">\r\n                <div class=\"box-header\">\r\n                    <h3 class=\"box-title\">");
            EndContext();
            BeginContext(609, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb7ec25109cb6e49d633cb7b965c13c2dc9b59537870", async() => {
                BeginContext(692, 13, false);
#line 22 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewResponses.cshtml"
                                                                                                                       Write(ViewBag.RefNo);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewResponses.cshtml"
                                                                                                   WriteLiteral(ViewBag.ID);

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
            BeginContext(709, 570, true);
            WriteLiteral(@"</h3>
                </div>
                <!-- /.box-header -->
                 <div class=""box-body"">
                    <table id=""example1"" class=""table table-bordered table-striped"">
                        <thead>
                            <tr>
                                <th>Date Created</th>
                                <th>Logger</th>
                                <th>Response</th>
                                <th>Action</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 36 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewResponses.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1368, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(1447, 50, false);
#line 39 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewResponses.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.LastChangedDate));

#line default
#line hidden
            EndContext();
            BeginContext(1497, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1545, 48, false);
#line 40 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewResponses.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.LastChangedBy));

#line default
#line hidden
            EndContext();
            BeginContext(1593, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1641, 43, false);
#line 41 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewResponses.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Response));

#line default
#line hidden
            EndContext();
            BeginContext(1684, 48, true);
            WriteLiteral("</td>\r\n                                     <td>");
            EndContext();
            BeginContext(1732, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb7ec25109cb6e49d633cb7b965c13c2dc9b595312926", async() => {
                BeginContext(1818, 4, true);
                WriteLiteral("View");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewResponses.cshtml"
                                                                                                  WriteLiteral(item.EnquiryID);

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
            BeginContext(1826, 46, true);
            WriteLiteral("</td>\r\n                                </tr>\r\n");
            EndContext();
#line 44 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewResponses.cshtml"
                            }

#line default
#line hidden
            BeginContext(1903, 246, true);
            WriteLiteral("                    </table>\r\n                </div>\r\n                <!-- /.box-body -->\r\n            </div>\r\n            <!-- /.box -->\r\n        </div>\r\n        <!-- /.col -->\r\n    </div>\r\n    <!-- /.row -->\r\n</section>\r\n\r\n<!-- DataTables -->\r\n");
            EndContext();
            BeginContext(2149, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb7ec25109cb6e49d633cb7b965c13c2dc9b595316084", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2234, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2236, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb7ec25109cb6e49d633cb7b965c13c2dc9b595317264", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2327, 345, true);
            WriteLiteral(@"
<!-- page script -->
<script>
    $(function () {
        $('#example1').DataTable();
    });
    function Delete(id){
       // alert(id)
        var txt;
        var r = confirm(""Are you sure you want to Delete?"");
        if (r == true) {

            $.ajax(
            {
                type: ""POST"",
                url: '");
            EndContext();
            BeginContext(2673, 28, false);
#line 73 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Enquiries\ViewResponses.cshtml"
                 Write(Url.Action("Delete", "User"));

#line default
#line hidden
            EndContext();
            BeginContext(2701, 568, true);
            WriteLiteral(@"',
                data: {
                    id: id
                },
                error: function (result) {
                    alert(""error"");
                },
                success: function (result) {
                    if (result == true) {
                        var baseUrl=""/Users"";
                        window.location.reload();
                    }
                    else {
                        alert(""There is a problem, Try Later!"");
                    }
                }
            });
        }
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmartDomain.EnquiryDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
