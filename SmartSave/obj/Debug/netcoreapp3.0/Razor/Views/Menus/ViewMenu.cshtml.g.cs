#pragma checksum "D:\Dev Projects\SmartSave\SmartSave\Views\Menus\ViewMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "500666b4df796bf3604f9a063be2345f9e28f4ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menus_ViewMenu), @"mvc.1.0.view", @"/Views/Menus/ViewMenu.cshtml")]
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
#nullable restore
#line 2 "D:\Dev Projects\SmartSave\SmartSave\Views\Menus\ViewMenu.cshtml"
using SmartHelper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"500666b4df796bf3604f9a063be2345f9e28f4ac", @"/Views/Menus/ViewMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1af0fb89db395063d8921ee12bbd8af94a13b0be", @"/Views/_ViewImports.cshtml")]
    public class Views_Menus_ViewMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartDomain.Menu>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Menus/ViewMenu"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<section class=""content-header"">
    <h1>
        Menus
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <!-- Horizontal Form -->
    <div class=""box box-info"">
        <div class=""box-header with-border"">

            <h3 class=""box-title"">");
#nullable restore
#line 14 "D:\Dev Projects\SmartSave\SmartSave\Views\Menus\ViewMenu.cshtml"
                             Write(Model.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n        <!-- /.box-header -->\r\n        <!-- form start -->\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "500666b4df796bf3604f9a063be2345f9e28f4ac6078", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 19 "D:\Dev Projects\SmartSave\SmartSave\Views\Menus\ViewMenu.cshtml"
             if (ViewData["Error"] != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"container\">\r\n                    <strong");
                BeginWriteAttribute("class", " class=\"", 629, "\"", 637, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 21 "D:\Dev Projects\SmartSave\SmartSave\Views\Menus\ViewMenu.cshtml"
                                Write(ViewData["Error"].ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                    <div class=\"panel panel-danger\">\r\n                        <div class=\"panel-body\">");
#nullable restore
#line 23 "D:\Dev Projects\SmartSave\SmartSave\Views\Menus\ViewMenu.cshtml"
                                           Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 26 "D:\Dev Projects\SmartSave\SmartSave\Views\Menus\ViewMenu.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"              <div class=""box-body"">

                 <div class=""form-group"">
                     <label for=""inputEmail3"" class=""col-sm-2 control-label"">Name</label>
                     <div class=""col-sm-10"">
                         <input type=""text"" class=""form-control"" name=""Name""");
                BeginWriteAttribute("value", " value=\"", 1177, "\"", 1203, 1);
#nullable restore
#line 32 "D:\Dev Projects\SmartSave\SmartSave\Views\Menus\ViewMenu.cshtml"
WriteAttributeValue("", 1185, Model.DisplayName, 1185, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                     </div>
                 </div>
                 <div class=""form-group"">
                     <label for=""inputEmail3"" class=""col-sm-2 control-label"">Controller</label>
                     <div class=""col-sm-10"">
                         <input type=""text"" class=""form-control"" name=""ControllerName""");
                BeginWriteAttribute("value", " value=\"", 1533, "\"", 1562, 1);
#nullable restore
#line 38 "D:\Dev Projects\SmartSave\SmartSave\Views\Menus\ViewMenu.cshtml"
WriteAttributeValue("", 1541, Model.ControllerName, 1541, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                     </div>
                 </div>

                 <div class=""form-group"">
                     <label for=""inputEmail3"" class=""col-sm-2 control-label"">Action</label>
                     <div class=""col-sm-10"">
                         <input type=""text"" class=""form-control"" name=""ActionName""");
                BeginWriteAttribute("value", " value=\"", 1886, "\"", 1911, 1);
#nullable restore
#line 45 "D:\Dev Projects\SmartSave\SmartSave\Views\Menus\ViewMenu.cshtml"
WriteAttributeValue("", 1894, Model.ActionName, 1894, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                     </div>
                 </div>
                 <div class=""form-group"">
                     <label for=""inputEmail3"" class=""col-sm-2 control-label"">Order No</label>
                     <div class=""col-sm-10"">
                         <input type=""text"" class=""form-control"" name=""OrderNo""");
                BeginWriteAttribute("value", " value=\"", 2232, "\"", 2254, 1);
#nullable restore
#line 51 "D:\Dev Projects\SmartSave\SmartSave\Views\Menus\ViewMenu.cshtml"
WriteAttributeValue("", 2240, Model.OrderNo, 2240, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                     </div>
                 </div>
                 <div class=""form-group"">
                     <label for=""inputEmail3"" class=""col-sm-2 control-label"">Style</label>
                     <div class=""col-sm-10"">
                         <input type=""text"" class=""form-control"" name=""CSSClass""");
                BeginWriteAttribute("value", " value=\"", 2573, "\"", 2596, 1);
#nullable restore
#line 57 "D:\Dev Projects\SmartSave\SmartSave\Views\Menus\ViewMenu.cshtml"
WriteAttributeValue("", 2581, Model.CSSClass, 2581, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                     </div>
                 </div>

                 <div class=""form-group"">
                     <label for=""inputEmail3"" class=""col-sm-2 control-label"">Is Active</label>
                     <div class=""col-sm-2"">

                         <label class=""checkbox-inline"">
                             <input type=""checkbox"" class=""minimal"" name=""IsActive""");
                BeginWriteAttribute("value", " value=\"", 2983, "\"", 3006, 1);
#nullable restore
#line 66 "D:\Dev Projects\SmartSave\SmartSave\Views\Menus\ViewMenu.cshtml"
WriteAttributeValue("", 2991, Model.IsActive, 2991, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                         </label>
                         <input type=""hidden"" name=""IsActive"" value=""false"" />
                     </div>
                 </div>
                 <div class=""form-group"">
                     <label for=""inputEmail3"" class=""col-sm-2 control-label"">LastChanged By</label>
                     <div class=""col-sm-10"">
                         <label for=""inputEmail3"" class=""form-control label-default"">");
#nullable restore
#line 74 "D:\Dev Projects\SmartSave\SmartSave\Views\Menus\ViewMenu.cshtml"
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
#line 81 "D:\Dev Projects\SmartSave\SmartSave\Views\Menus\ViewMenu.cshtml"
                                                                                Write(UtilityService.ShowDateTime(@Model.LastChangedDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                     </div>\r\n                 </div>\r\n                 <input type=\"hidden\" name=\"MenuID\"");
                BeginWriteAttribute("value", " value=\"", 3982, "\"", 4003, 1);
#nullable restore
#line 84 "D:\Dev Projects\SmartSave\SmartSave\Views\Menus\ViewMenu.cshtml"
WriteAttributeValue("", 3990, Model.MenuID, 3990, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n             </div>\r\n            <!-- /.box-body -->\r\n            <div class=\"box-footer\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "500666b4df796bf3604f9a063be2345f9e28f4ac13974", async() => {
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
                WriteLiteral("\r\n                <button type=\"submit\" class=\"btn btn-info pull-right\">Update</button>\r\n            </div>\r\n            <!-- /.box-footer -->\r\n        ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartDomain.Menu> Html { get; private set; }
    }
}
#pragma warning restore 1591
