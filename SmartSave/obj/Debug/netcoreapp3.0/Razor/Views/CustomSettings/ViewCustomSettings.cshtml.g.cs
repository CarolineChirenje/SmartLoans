#pragma checksum "D:\Dev Projects\SmartSave\SmartSave\Views\CustomSettings\ViewCustomSettings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62de99762fcc5267e084c4c8caa3014bfb9d9df5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomSettings_ViewCustomSettings), @"mvc.1.0.view", @"/Views/CustomSettings/ViewCustomSettings.cshtml")]
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
#line 2 "D:\Dev Projects\SmartSave\SmartSave\Views\CustomSettings\ViewCustomSettings.cshtml"
using SmartHelper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62de99762fcc5267e084c4c8caa3014bfb9d9df5", @"/Views/CustomSettings/ViewCustomSettings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1af0fb89db395063d8921ee12bbd8af94a13b0be", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomSettings_ViewCustomSettings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartDomain.CustomSetting>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/CustomSettings/ViewCustomSettings"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""content-header"">
    <h1>
        Custom Setting
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <!-- Horizontal Form -->
    <div class=""box box-info"">
        <div class=""box-header with-border"">

            <h3 class=""box-title"">");
#nullable restore
#line 14 "D:\Dev Projects\SmartSave\SmartSave\Views\CustomSettings\ViewCustomSettings.cshtml"
                             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n        <!-- /.box-header -->\r\n        <!-- form start -->\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62de99762fcc5267e084c4c8caa3014bfb9d9df57147", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 19 "D:\Dev Projects\SmartSave\SmartSave\Views\CustomSettings\ViewCustomSettings.cshtml"
             if (ViewData["Error"] != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"container\">\r\n                    <strong");
                BeginWriteAttribute("class", " class=\"", 658, "\"", 666, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 21 "D:\Dev Projects\SmartSave\SmartSave\Views\CustomSettings\ViewCustomSettings.cshtml"
                                Write(ViewData["Error"].ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                    <div class=\"panel panel-danger\">\r\n                        <div class=\"panel-body\">");
#nullable restore
#line 23 "D:\Dev Projects\SmartSave\SmartSave\Views\CustomSettings\ViewCustomSettings.cshtml"
                                           Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 26 "D:\Dev Projects\SmartSave\SmartSave\Views\CustomSettings\ViewCustomSettings.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            \r\n        <div class=\"box-body\">\r\n            <div class=\"form-group\">\r\n                <label for=\"inputEmail3\" class=\"col-sm-2 control-label\">Setting Type</label>\r\n\r\n                <div class=\"col-sm-10\">\r\n\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62de99762fcc5267e084c4c8caa3014bfb9d9df59086", async() => {
                    WriteLiteral("\r\n                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62de99762fcc5267e084c4c8caa3014bfb9d9df59378", async() => {
                        WriteLiteral("----");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 34 "D:\Dev Projects\SmartSave\SmartSave\Views\CustomSettings\ViewCustomSettings.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomSettingID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 34 "D:\Dev Projects\SmartSave\SmartSave\Views\CustomSettings\ViewCustomSettings.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.CustomSettingsList;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

                </div>
            </div>
            <div class=""form-group"">
                <label for=""inputEmail3"" class=""col-sm-2 control-label"">Name</label>
                <div class=""col-sm-10"">
                    <input type=""text"" class=""form-control"" name=""Name"" disabled=""disabled""");
                BeginWriteAttribute("value", " value=\"", 1638, "\"", 1657, 1);
#nullable restore
#line 43 "D:\Dev Projects\SmartSave\SmartSave\Views\CustomSettings\ViewCustomSettings.cshtml"
WriteAttributeValue("", 1646, Model.Name, 1646, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                </div>
            </div>

            <div class=""form-group"">
                <label for=""inputEmail3"" class=""col-sm-2 control-label"">Description</label>
                <div class=""col-sm-10"">
                    <textarea class=""form-control"" name=""Description"" disabled=""disabled"">");
#nullable restore
#line 50 "D:\Dev Projects\SmartSave\SmartSave\Views\CustomSettings\ViewCustomSettings.cshtml"
                                                                                     Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</textarea>
                </div>
            </div>

            <div class=""form-group"">
                <label for=""inputEmail3"" class=""col-sm-2 control-label"">Setting Type</label>

                <div class=""col-sm-10"">

                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62de99762fcc5267e084c4c8caa3014bfb9d9df514133", async() => {
                    WriteLiteral("\r\n                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62de99762fcc5267e084c4c8caa3014bfb9d9df514426", async() => {
                        WriteLiteral("----");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 59 "D:\Dev Projects\SmartSave\SmartSave\Views\CustomSettings\ViewCustomSettings.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomSettingTypeID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 59 "D:\Dev Projects\SmartSave\SmartSave\Views\CustomSettings\ViewCustomSettings.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.CustomSettingsTypeList;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label for=\"inputEmail3\" class=\"col-sm-2 control-label\">Setting Type</label>\r\n\r\n                <div class=\"col-sm-10\">\r\n\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62de99762fcc5267e084c4c8caa3014bfb9d9df517859", async() => {
                    WriteLiteral("\r\n                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62de99762fcc5267e084c4c8caa3014bfb9d9df518152", async() => {
                        WriteLiteral("----");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 70 "D:\Dev Projects\SmartSave\SmartSave\Views\CustomSettings\ViewCustomSettings.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomVariableTypeID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 70 "D:\Dev Projects\SmartSave\SmartSave\Views\CustomSettings\ViewCustomSettings.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.CustomVariableTypeList;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
            </div>
            <div class=""form-group"">
                <label for=""inputEmail3"" class=""col-sm-2 control-label"">Value</label>
                <div class=""col-sm-10"">
                    <input type=""text"" class=""form-control"" name=""Value""");
                BeginWriteAttribute("value", " value=\"", 3151, "\"", 3171, 1);
#nullable restore
#line 78 "D:\Dev Projects\SmartSave\SmartSave\Views\CustomSettings\ViewCustomSettings.cshtml"
WriteAttributeValue("", 3159, Model.Value, 3159, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                </div>
            </div>
            <div class=""form-group"">
                <label for=""inputEmail3"" class=""col-sm-2 control-label"">Active Status</label>
                <div class=""col-sm-2"">

                    <label class=""checkbox-inline"">
                        <input type=""checkbox"" class=""minimal"" name=""IsActive"" value=""true""");
                BeginWriteAttribute("checked", " checked=\"", 3538, "\"", 3563, 1);
#nullable restore
#line 86 "D:\Dev Projects\SmartSave\SmartSave\Views\CustomSettings\ViewCustomSettings.cshtml"
WriteAttributeValue("", 3548, Model.IsActive, 3548, 15, false);

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
#line 96 "D:\Dev Projects\SmartSave\SmartSave\Views\CustomSettings\ViewCustomSettings.cshtml"
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
#line 103 "D:\Dev Projects\SmartSave\SmartSave\Views\CustomSettings\ViewCustomSettings.cshtml"
                                                                           Write(UtilityService.ShowDateTime(@Model.LastChangedDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                </div>\r\n            </div>\r\n            <input type=\"hidden\" name=\"CustomSettingID\"");
                BeginWriteAttribute("value", " value=\"", 4467, "\"", 4497, 1);
#nullable restore
#line 106 "D:\Dev Projects\SmartSave\SmartSave\Views\CustomSettings\ViewCustomSettings.cshtml"
WriteAttributeValue("", 4475, Model.CustomSettingID, 4475, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n                 <!-- /.box-body -->\r\n                 <div class=\"box-footer\">\r\n                     ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62de99762fcc5267e084c4c8caa3014bfb9d9df524802", async() => {
                    WriteLiteral("Cancel");
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
                WriteLiteral("\r\n                     <button type=\"submit\" class=\"btn btn-info pull-right\">Update</button>\r\n                 </div>\r\n                 <!-- /.box-footer -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartDomain.CustomSetting> Html { get; private set; }
    }
}
#pragma warning restore 1591
