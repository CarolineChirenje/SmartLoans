#pragma checksum "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc110749dbd5307d5c0b1ef0375d7df775027ca6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Layouts_ViewLayoutGroup), @"mvc.1.0.view", @"/Views/Layouts/ViewLayoutGroup.cshtml")]
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
#line 1 "C:\DEV\SmartLoans\SmartLoans\Views\_ViewImports.cshtml"
using SmartLoan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DEV\SmartLoans\SmartLoans\Views\_ViewImports.cshtml"
using SmartLoan.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
using SmartHelper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc110749dbd5307d5c0b1ef0375d7df775027ca6", @"/Views/Layouts/ViewLayoutGroup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a83c5e5401d63e9f19604f61ec10fe4c4974d7dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Layouts_ViewLayoutGroup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartDomain.Layout>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Layouts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Layouts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Layouts/ViewLayoutGroup"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""content-header"">
    <h1>
       Layout Group
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <!-- Horizontal Form -->
    <div class=""box box-info"">
        <div class=""box-header with-border"">
            <h3 class=""box-title"">");
#nullable restore
#line 13 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
                             Write(Model.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc110749dbd5307d5c0b1ef0375d7df775027ca67012", async() => {
                WriteLiteral("Add Child Menu");
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
            WriteLiteral("\r\n        </div>\r\n        <!-- /.box-header -->\r\n        <!-- form start -->\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc110749dbd5307d5c0b1ef0375d7df775027ca68554", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
             if (TempData["Error"] != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"container\">\r\n                    <strong");
                BeginWriteAttribute("class", " class=\"", 756, "\"", 764, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 21 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
                                Write(TempData["Error"].ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                    <div class=\"panel panel-danger\">\r\n                        <div class=\"panel-body\">");
#nullable restore
#line 23 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
                                           Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 26 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <div class=""box-body"">

            <div class=""form-group"">
                <label for=""inputEmail3"" class=""col-sm-2 control-label"">Name</label>
                <div class=""col-sm-10"">
                    <input type=""text"" class=""form-control"" name=""DisplayName""");
                BeginWriteAttribute("value", " value=\"", 1285, "\"", 1311, 1);
#nullable restore
#line 32 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
WriteAttributeValue("", 1293, Model.DisplayName, 1293, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                </div>
            </div>
                  

            <div class=""form-group"">
                <label for=""inputEmail3"" class=""col-sm-2 control-label"">Children</label>
                <div class=""col-sm-10"">
                    <input type=""text"" class=""form-control"" name=""Children"" disabled");
                BeginWriteAttribute("value", " value=\"", 1634, "\"", 1663, 1);
#nullable restore
#line 40 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
WriteAttributeValue("", 1642, Model.Menus?.Count(), 1642, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">

                </div>
            </div>

            <div class=""form-group"">
                <label for=""inputEmail3"" class=""col-sm-2 control-label"">LastChanged By</label>
                <div class=""col-sm-10"">
                    <label for=""inputEmail3"" class=""form-control label-default"">");
#nullable restore
#line 48 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
                                                                           Write(Model.LastChangedBy);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                </div>
            </div>

            <div class=""form-group"">
                <label for=""inputEmail3"" class=""col-sm-2 control-label"">Last Updated</label>
                <div class=""col-sm-10"">
                    <label for=""inputEmail3"" class=""form-control label-default"">");
#nullable restore
#line 55 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
                                                                           Write(UtilityService.ShowDateTime(@Model.LastChangedDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                </div>\r\n            </div>\r\n            <input type=\"hidden\" name=\"LayoutID\"");
                BeginWriteAttribute("value", " value=\"", 2453, "\"", 2476, 1);
#nullable restore
#line 58 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
WriteAttributeValue("", 2461, Model.LayoutID, 2461, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n            <!-- /.box-body -->\r\n            <div class=\"box-footer\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc110749dbd5307d5c0b1ef0375d7df775027ca613371", async() => {
                    WriteLiteral("Cancel");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 63 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
                 if (UserAppData.HasPermission(Permissions.Update_Menu))
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <button type=\"submit\" class=\"btn btn-info pull-right\">Update</button>\r\n");
#nullable restore
#line 66 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <!-- /.box-footer -->\r\n        ");
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
            WriteLiteral(@"
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        Additional Information
                    </div>
                    <!-- /.panel-heading -->
                    <div class=""panel-body"">
                        <!-- Nav tabs -->

                        <ul class=""nav nav-tabs"" id=""myTab"">
");
#nullable restore
#line 82 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
                             if (UserAppData.HasPermission(Permissions.View_Menu))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li class=\"active\">\r\n                                    <a href=\"#ChildMenu\" data-toggle=\"tab\">Child Layouts</a>\r\n                                </li>\r\n");
#nullable restore
#line 87 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                           
                        </ul>
                        <!-- Tab panes -->
                        <div class=""tab-content"">

                            <div class=""tab-pane fade in active "" id=""ChildMenu"">
                                <div class=""panel panel-default"">
                                    <div class=""panel-heading"">
                                        Sub Layouts
                                    </div>
                                </div>
                                <!-- /.panel-heading -->
                                <div class=""panel-body"">
                                    <div class=""dataTable_wrapper"">
                                        <table id=""example1"" class=""table table-bordered table-striped"">
                                            <thead>
                                                <tr>
                                                    <th>Display Name</th>
                                          ");
            WriteLiteral(@"          <th>Path Name</th>
                                                    <th>Style</th>
                                                    <th>Order No</th>
                                                    <th>Last Changed Date</th>
                                                    <th>Changed By</th>
                                                    <th>Is Active</th>

                                                </tr>
                                            </thead>
                                            <tbody>

");
#nullable restore
#line 117 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
                                                 foreach (var item in Model.Menus)
                                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n");
#nullable restore
#line 121 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
                                                           string activeStatus = UtilityService.ShowYesOrNo(item.IsActive);
                                                            string dateCreated = UtilityService.ShowDateTime(item.LastChangedDate);

                                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 127 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
                                                         if (UserAppData.HasPermission(Permissions.View_Menu))
                                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc110749dbd5307d5c0b1ef0375d7df775027ca620957", async() => {
#nullable restore
#line 129 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
                                                                                                                                               Write(item.DisplayName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 129 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
                                                                                                                    WriteLiteral(item.LayoutMenuID);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("</td>\r\n");
#nullable restore
#line 130 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
                                                        }
                                                        else
                                                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                                            <td>");
#nullable restore
#line 134 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.DisplayName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 135 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
                                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <td>");
#nullable restore
#line 136 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.PathName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 137 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.CSSClass));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 138 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.OrderNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 139 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
                                                       Write(dateCreated);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                        <td>");
#nullable restore
#line 140 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.LastChangedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                                        <td>");
#nullable restore
#line 142 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
                                                       Write(activeStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 144 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </table>\r\n\r\n                                    </div>\r\n                                </div>\r\n\r\n                                <div class=\"box-footer\">\r\n");
#nullable restore
#line 151 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
                                     if (UserAppData.HasPermission(Permissions.Add_Menu))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc110749dbd5307d5c0b1ef0375d7df775027ca627565", async() => {
                WriteLiteral("New Menu");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<br />\r\n");
#nullable restore
#line 154 "C:\DEV\SmartLoans\SmartLoans\Views\Layouts\ViewLayoutGroup.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div>
                            </div>

                        </div>
                        <!-- /.panel -->
                    </div>

                </div>
            </div>
        </div>

    </div>
    <!-- /.box -->
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartDomain.Layout> Html { get; private set; }
    }
}
#pragma warning restore 1591
