#pragma checksum "C:\DEV\SmartWealth\SmartSave\Views\Roles\ViewPermission.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b52e6015f1bb1bd1d1d7b79b5fd0ecf70f33bc85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_ViewPermission), @"mvc.1.0.view", @"/Views/Roles/ViewPermission.cshtml")]
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
#line 2 "C:\DEV\SmartWealth\SmartSave\Views\Roles\ViewPermission.cshtml"
using SmartHelper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b52e6015f1bb1bd1d1d7b79b5fd0ecf70f33bc85", @"/Views/Roles/ViewPermission.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1af0fb89db395063d8921ee12bbd8af94a13b0be", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles_ViewPermission : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartDomain.Permission>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Roles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Roles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<section class=\"content-header\">\r\n    <h1>\r\n        ");
#nullable restore
#line 5 "C:\DEV\SmartWealth\SmartSave\Views\Roles\ViewPermission.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n</section>\r\n<!-- Main content -->\r\n<section class=\"content container-fluid\">\r\n    <!-- Horizontal Form -->\r\n    <div class=\"box box-info\">\r\n        <div class=\"box-header with-border\">\r\n\r\n            <h3 class=\"box-title\">");
#nullable restore
#line 14 "C:\DEV\SmartWealth\SmartSave\Views\Roles\ViewPermission.cshtml"
                             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n        <!-- /.box-header -->\r\n        <!-- form start -->\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b52e6015f1bb1bd1d1d7b79b5fd0ecf70f33bc855654", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\DEV\SmartWealth\SmartSave\Views\Roles\ViewPermission.cshtml"
             if (TempData["Error"] != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"container\">\r\n                    <strong");
                BeginWriteAttribute("class", " class=\"", 594, "\"", 602, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 21 "C:\DEV\SmartWealth\SmartSave\Views\Roles\ViewPermission.cshtml"
                                Write(TempData["Error"].ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                    <div class=\"panel panel-danger\">\r\n                        <div class=\"panel-body\">");
#nullable restore
#line 23 "C:\DEV\SmartWealth\SmartSave\Views\Roles\ViewPermission.cshtml"
                                           Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 26 "C:\DEV\SmartWealth\SmartSave\Views\Roles\ViewPermission.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <div class=""box-body"">

                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Name</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""Name""");
                BeginWriteAttribute("value", " value=\"", 1136, "\"", 1155, 1);
#nullable restore
#line 32 "C:\DEV\SmartWealth\SmartSave\Views\Roles\ViewPermission.cshtml"
WriteAttributeValue("", 1144, Model.Name, 1144, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled>
                    </div>
                </div>
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Description</label>
                    <div class=""col-sm-10"">
                        <textarea class=""form-control"" name=""Description""");
                BeginWriteAttribute("value", " value=\"", 1477, "\"", 1503, 1);
#nullable restore
#line 38 "C:\DEV\SmartWealth\SmartSave\Views\Roles\ViewPermission.cshtml"
WriteAttributeValue("", 1485, Model.Description, 1485, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" disabled>");
#nullable restore
#line 38 "C:\DEV\SmartWealth\SmartSave\Views\Roles\ViewPermission.cshtml"
                                                                                                         Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</textarea>
                    </div>
                </div>

                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Is Active</label>
                    <div class=""col-sm-2"">

                        <label class=""checkbox-inline"">
                            <input type=""checkbox"" class=""minimal"" name=""IsActive"" value=""true""");
                BeginWriteAttribute("checked", " checked=\"", 1934, "\"", 1959, 1);
#nullable restore
#line 47 "C:\DEV\SmartWealth\SmartSave\Views\Roles\ViewPermission.cshtml"
WriteAttributeValue("", 1944, Model.IsActive, 1944, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" disabled />
                        </label>
                        <input type=""hidden"" name=""IsActive"" value=""false"" />
                    </div>
                </div>

                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Roles With Permission</label>
                    <div class=""col-sm-10"">
                        ");
#nullable restore
#line 56 "C:\DEV\SmartWealth\SmartSave\Views\Roles\ViewPermission.cshtml"
                   Write(Model.RolePermissions?.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                </div>

                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">LastChanged By</label>
                    <div class=""col-sm-10"">
                        <label for=""inputEmail3"" class=""form-control label-default"">");
#nullable restore
#line 63 "C:\DEV\SmartWealth\SmartSave\Views\Roles\ViewPermission.cshtml"
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
#line 70 "C:\DEV\SmartWealth\SmartSave\Views\Roles\ViewPermission.cshtml"
                                                                               Write(UtilityService.ShowDateTime(@Model.LastChangedDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </div>\r\n                </div>\r\n                           </div>\r\n            <!-- /.box-body -->\r\n            <div class=\"box-footer\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b52e6015f1bb1bd1d1d7b79b5fd0ecf70f33bc8511863", async() => {
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
                WriteLiteral("\r\n               \r\n            </div>\r\n            <!-- /.box-footer -->\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n      \r\n        <!-- /.box -->\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartDomain.Permission> Html { get; private set; }
    }
}
#pragma warning restore 1591
