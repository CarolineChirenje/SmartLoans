#pragma checksum "D:\Dev Projects\SmartFin\SmartAdmin\Views\Student\Students.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72b1a4d8fd369de03b61fbc1172efb0a88aedc3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Students), @"mvc.1.0.view", @"/Views/Student/Students.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Students.cshtml", typeof(AspNetCore.Views_Student_Students))]
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
#line 2 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Student\Students.cshtml"
using SmartHelper;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72b1a4d8fd369de03b61fbc1172efb0a88aedc3f", @"/Views/Student/Students.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9906be48bf7b893089acfeca7d3efff7da363c1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Students : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmartDomain.Student>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Dashboard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewStudent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeStudentStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddStudent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Student\Students.cshtml"
  
    ViewData["Title"] = "Students";

#line default
#line hidden
            BeginContext(106, 54, true);
            WriteLiteral("\r\n<section class=\"content-header\">\r\n    <h1>\r\n        ");
            EndContext();
            BeginContext(161, 17, false);
#line 9 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Student\Students.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(178, 54, true);
            WriteLiteral("\r\n    </h1>\r\n    <ol class=\"breadcrumb\">\r\n        <li>");
            EndContext();
            BeginContext(232, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72b1a4d8fd369de03b61fbc1172efb0a88aedc3f6959", async() => {
                BeginContext(259, 36, true);
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
            BeginContext(299, 34, true);
            WriteLiteral("</li>\r\n        <li class=\"active\">");
            EndContext();
            BeginContext(334, 17, false);
#line 13 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Student\Students.cshtml"
                      Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(351, 376, true);
            WriteLiteral(@"</li>
    </ol>
</section>
<!-- Main content -->
<section class=""content"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box"">
                <div class=""box-header"">
                    <h3 class=""box-title"">Manage Students</h3>
                </div>
                <!-- /.box-header -->
                <div class=""box-body"">
");
            EndContext();
#line 26 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Student\Students.cshtml"
                     if (ViewData["Error"] != null)
                    {

#line default
#line hidden
            BeginContext(801, 70, true);
            WriteLiteral("<div class=\"container\">\r\n                            <strong class=\"\">");
            EndContext();
            BeginContext(872, 28, false);
#line 28 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Student\Students.cshtml"
                                        Write(ViewData["Error"].ToString());

#line default
#line hidden
            EndContext();
            BeginContext(900, 129, true);
            WriteLiteral("</strong>\r\n                            <div class=\"panel panel-danger\">\r\n                                <div class=\"panel-body\">");
            EndContext();
            BeginContext(1030, 24, false);
#line 30 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Student\Students.cshtml"
                                                   Write(Html.ValidationSummary());

#line default
#line hidden
            EndContext();
            BeginContext(1054, 76, true);
            WriteLiteral("</div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 33 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Student\Students.cshtml"
                    }

#line default
#line hidden
            BeginContext(1153, 828, true);
            WriteLiteral(@"                    <div class=""dataTable_wrapper"">
                        <table class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
                            <thead>
                                <tr>
                                    <th>Account Number</th>
                                    <th>Full Name</th>
                                    <th>Date of Birth</th>
                                    <th>Gender</th>
                                    <th>Email</th>
                                    <th>Registration Date</th>
                                    <th>Is Active</th>
                                    <th>Action</th>
                                </tr>
                            </thead>
                            <tbody class=""odd gradeX"">
");
            EndContext();
#line 49 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Student\Students.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
            BeginContext(2078, 38, true);
            WriteLiteral("                                <tr>\r\n");
            EndContext();
#line 52 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Student\Students.cshtml"
                                      
                                        string activeStatus = UtilityService.ShowYesOrNo(item.IsActive);
                                        string dateCreated = UtilityService.ShowDateTime(item.LastChangedDate);
                                        string dateRegistered = UtilityService.ShowDateTime(item.RegistrationDate);
                                        string dob = UtilityService.ShowDate(item.DateOfBirth);
                                        string StudentStatus = UtilityService.ShowActiveAction(@item.IsActive);
                                        string gender = UtilityService.ShowGender(@item.GenderID);

                                    

#line default
#line hidden
            BeginContext(2843, 40, true);
            WriteLiteral("                                    <td>");
            EndContext();
            BeginContext(2883, 137, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72b1a4d8fd369de03b61fbc1172efb0a88aedc3f12736", async() => {
                BeginContext(2968, 48, false);
#line 61 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Student\Students.cshtml"
                                                                                                                       Write(Html.DisplayFor(modelItem => item.AccountNumber));

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
#line 61 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Student\Students.cshtml"
                                                                                               WriteLiteral(item.StudentID);

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
            BeginContext(3020, 48, true);
            WriteLiteral(" </td>\r\n                                    <td>");
            EndContext();
            BeginContext(3069, 50, false);
#line 62 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Student\Students.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.StudentFullName));

#line default
#line hidden
            EndContext();
            BeginContext(3119, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3167, 3, false);
#line 63 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Student\Students.cshtml"
                                   Write(dob);

#line default
#line hidden
            EndContext();
            BeginContext(3170, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3218, 6, false);
#line 64 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Student\Students.cshtml"
                                   Write(gender);

#line default
#line hidden
            EndContext();
            BeginContext(3224, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3272, 47, false);
#line 65 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Student\Students.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.EmailAddress));

#line default
#line hidden
            EndContext();
            BeginContext(3319, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3367, 14, false);
#line 66 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Student\Students.cshtml"
                                   Write(dateRegistered);

#line default
#line hidden
            EndContext();
            BeginContext(3381, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(3429, 12, false);
#line 67 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Student\Students.cshtml"
                                   Write(activeStatus);

#line default
#line hidden
            EndContext();
            BeginContext(3441, 49, true);
            WriteLiteral("</td>\r\n\r\n                                    <td>");
            EndContext();
            BeginContext(3490, 144, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72b1a4d8fd369de03b61fbc1172efb0a88aedc3f17999", async() => {
                BeginContext(3617, 13, false);
#line 69 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Student\Students.cshtml"
                                                                                                                                                                 Write(StudentStatus);

#line default
#line hidden
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
#line 69 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Student\Students.cshtml"
                                                                                                       WriteLiteral(item.StudentID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 69 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Student\Students.cshtml"
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
            BeginContext(3634, 12, true);
            WriteLiteral("| <a href=\"\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3646, "\"", 3681, 3);
            WriteAttributeValue("", 3656, "Delete(\'", 3656, 8, true);
#line 69 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Student\Students.cshtml"
WriteAttributeValue("", 3664, item.StudentID, 3664, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 3679, "\')", 3679, 2, true);
            EndWriteAttribute();
            BeginContext(3682, 57, true);
            WriteLiteral(">Delete</a></td>\r\n                                </tr>\r\n");
            EndContext();
#line 71 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Student\Students.cshtml"
                                }

#line default
#line hidden
            BeginContext(3774, 148, true);
            WriteLiteral("                        </table>\r\n                    </div>\r\n                </div>\r\n                <div class=\"box-footer\">\r\n                    ");
            EndContext();
            BeginContext(3922, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72b1a4d8fd369de03b61fbc1172efb0a88aedc3f22611", async() => {
                BeginContext(3994, 6, true);
                WriteLiteral("Cancel");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4004, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(4026, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72b1a4d8fd369de03b61fbc1172efb0a88aedc3f24294", async() => {
                BeginContext(4113, 3, true);
                WriteLiteral("New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4120, 463, true);
            WriteLiteral(@"<br />

                </div>
                <!-- /.box-body -->
            </div>
            <!-- /.box -->
        </div>
        <!-- /.col -->
    </div>
    <!-- /.row -->
</section>


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
            BeginContext(4584, 31, false);
#line 101 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Student\Students.cshtml"
                 Write(Url.Action("Delete", "Student"));

#line default
#line hidden
            EndContext();
            BeginContext(4615, 571, true);
            WriteLiteral(@"',
                data: {
                    id: id
                },
                error: function (result) {
                    alert(""error"");
                },
                success: function (result) {
                    if (result == true) {
                        var baseUrl=""/Students"";
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmartDomain.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
