#pragma checksum "D:\Dev Projects\SmartFin\SmartAdmin\Views\Class\SchoolClass.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8acce4a998fa1e628e689f01082171b0639afc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Class_SchoolClass), @"mvc.1.0.view", @"/Views/Class/SchoolClass.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Class/SchoolClass.cshtml", typeof(AspNetCore.Views_Class_SchoolClass))]
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
#line 2 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Class\SchoolClass.cshtml"
using SmartHelper;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8acce4a998fa1e628e689f01082171b0639afc4", @"/Views/Class/SchoolClass.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9906be48bf7b893089acfeca7d3efff7da363c1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Class_SchoolClass : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmartDomain.SchoolClass>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Dashboard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Class", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewClassStudents", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewClass", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ActionStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Class\SchoolClass.cshtml"
  
    ViewData["Title"] = "Classes";

#line default
#line hidden
            BeginContext(109, 54, true);
            WriteLiteral("\r\n<section class=\"content-header\">\r\n    <h1>\r\n        ");
            EndContext();
            BeginContext(164, 17, false);
#line 9 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Class\SchoolClass.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(181, 54, true);
            WriteLiteral("\r\n    </h1>\r\n    <ol class=\"breadcrumb\">\r\n        <li>");
            EndContext();
            BeginContext(235, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8acce4a998fa1e628e689f01082171b0639afc46602", async() => {
                BeginContext(262, 36, true);
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
            BeginContext(302, 34, true);
            WriteLiteral("</li>\r\n        <li class=\"active\">");
            EndContext();
            BeginContext(337, 17, false);
#line 13 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Class\SchoolClass.cshtml"
                      Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(354, 377, true);
            WriteLiteral(@"</li>
    </ol>
</section>
<!-- Main content -->
<section class=""content"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box"">
                <div class=""box-header"">
                    <h3 class=""box-title"">Manage Classes</h3>

                </div>
                <!-- /.box-header -->
                <div class=""box-body"">
");
            EndContext();
#line 27 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Class\SchoolClass.cshtml"
                     if (ViewData["Error"] != null)
                    {

#line default
#line hidden
            BeginContext(805, 70, true);
            WriteLiteral("<div class=\"container\">\r\n                            <strong class=\"\">");
            EndContext();
            BeginContext(876, 28, false);
#line 29 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Class\SchoolClass.cshtml"
                                        Write(ViewData["Error"].ToString());

#line default
#line hidden
            EndContext();
            BeginContext(904, 129, true);
            WriteLiteral("</strong>\r\n                            <div class=\"panel panel-danger\">\r\n                                <div class=\"panel-body\">");
            EndContext();
            BeginContext(1034, 24, false);
#line 31 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Class\SchoolClass.cshtml"
                                                   Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(1058, 76, true);
            WriteLiteral("</div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 34 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Class\SchoolClass.cshtml"
                    }

#line default
#line hidden
            BeginContext(1157, 696, true);
            WriteLiteral(@"                    <div class=""dataTable_wrapper"">
                        <table class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
                            <thead>
                                <tr>
                                    <th>Name</th>
                                    <th>Active Status</th>
                                    <th>Users</th>
                                    <th>Last Changed Date</th>
                                    <th>Last Changed By</th>
                                    <th>Action</th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 48 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Class\SchoolClass.cshtml"
                                 foreach (var item in Model)
                                {


#line default
#line hidden
            BeginContext(1952, 42, true);
            WriteLiteral("                                    <tr>\r\n");
            EndContext();
#line 52 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Class\SchoolClass.cshtml"
                                           string activeStatus = UtilityService.ShowYesOrNo(item.IsActive);
                                            string dateCreated = UtilityService.ShowDateTime(item.LastChangedDate);
                                            string status = @item.IsActive ? "Deactivate" : "Reactivate";

                                        

#line default
#line hidden
            BeginContext(2372, 46, true);
            WriteLiteral("\r\n                                        <td>");
            EndContext();
            BeginContext(2419, 44, false);
#line 58 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Class\SchoolClass.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.ClassName));

#line default
#line hidden
            EndContext();
            BeginContext(2463, 53, true);
            WriteLiteral("</td>\r\n\r\n                                        <td>");
            EndContext();
            BeginContext(2517, 12, false);
#line 60 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Class\SchoolClass.cshtml"
                                       Write(activeStatus);

#line default
#line hidden
            EndContext();
            BeginContext(2529, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2580, 123, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8acce4a998fa1e628e689f01082171b0639afc412746", async() => {
                BeginContext(2673, 26, false);
#line 61 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Class\SchoolClass.cshtml"
                                                                                                                                   Write(item.StudentClass?.Count());

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
#line 61 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Class\SchoolClass.cshtml"
                                                                                                       WriteLiteral(item.SchoolClassID);

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
            BeginContext(2703, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2755, 11, false);
#line 62 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Class\SchoolClass.cshtml"
                                       Write(dateCreated);

#line default
#line hidden
            EndContext();
            BeginContext(2766, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2818, 48, false);
#line 63 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Class\SchoolClass.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.LastChangedBy));

#line default
#line hidden
            EndContext();
            BeginContext(2866, 53, true);
            WriteLiteral("</td>\r\n\r\n                                        <td>");
            EndContext();
            BeginContext(2919, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8acce4a998fa1e628e689f01082171b0639afc416462", async() => {
                BeginContext(3003, 4, true);
                WriteLiteral("View");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Class\SchoolClass.cshtml"
                                                                                               WriteLiteral(item.SchoolClassID);

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
            BeginContext(3011, 2, true);
            WriteLiteral(" |");
            EndContext();
            BeginContext(3013, 132, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8acce4a998fa1e628e689f01082171b0639afc419048", async() => {
                BeginContext(3135, 6, false);
#line 65 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Class\SchoolClass.cshtml"
                                                                                                                                                                                                                                                              Write(status);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Class\SchoolClass.cshtml"
                                                                                                                                                                                                WriteLiteral(item.SchoolClassID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 65 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Class\SchoolClass.cshtml"
                                                                                                                                                                                                                                       WriteLiteral(item.IsActive);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["status"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-status", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["status"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3145, 13, true);
            WriteLiteral(" | <a href=\"\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3158, "\"", 3197, 3);
            WriteAttributeValue("", 3168, "Delete(\'", 3168, 8, true);
#line 65 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Class\SchoolClass.cshtml"
WriteAttributeValue("", 3176, item.SchoolClassID, 3176, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 3195, "\')", 3195, 2, true);
            EndWriteAttribute();
            BeginContext(3198, 61, true);
            WriteLiteral(">Delete</a></td>\r\n                                    </tr>\r\n");
            EndContext();
#line 67 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Class\SchoolClass.cshtml"
                                }

#line default
#line hidden
            BeginContext(3294, 185, true);
            WriteLiteral("                        </table>\r\n                    </div>\r\n                </div>\r\n                <!-- /.box-body -->\r\n                <div class=\"box-footer\">\r\n                    ");
            EndContext();
            BeginContext(3479, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8acce4a998fa1e628e689f01082171b0639afc423984", async() => {
                BeginContext(3551, 6, true);
                WriteLiteral("Cancel");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3561, 525, true);
            WriteLiteral(@"
                    <a href=""Add"" class=""btn btn-success pull-right"">Create</a><br />
                </div>
            </div>
            <!-- /.box -->
        </div>
        <!-- /.col -->
    </div>
    <!-- /.row -->
</section>

<!-- page script -->
<script>

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
            BeginContext(4087, 29, false);
#line 96 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Class\SchoolClass.cshtml"
                 Write(Url.Action("Delete", "Class"));

#line default
#line hidden
            EndContext();
            BeginContext(4116, 569, true);
            WriteLiteral(@"',
                data: {
                    id: id
                },
                error: function (result) {
                    alert(""error"");
                },
                success: function (result) {
                    if (result == true) {
                        var baseUrl =""/Class"";
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmartDomain.SchoolClass>> Html { get; private set; }
    }
}
#pragma warning restore 1591
