#pragma checksum "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79a271ab8e200dca32f3ea2842ad2a4e294d6431"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fee_ViewFee), @"mvc.1.0.view", @"/Views/Fee/ViewFee.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Fee/ViewFee.cshtml", typeof(AspNetCore.Views_Fee_ViewFee))]
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
#line 2 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
using SmartHelper;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79a271ab8e200dca32f3ea2842ad2a4e294d6431", @"/Views/Fee/ViewFee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9906be48bf7b893089acfeca7d3efff7da363c1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Fee_ViewFee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartDomain.Fee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Fee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewFeePrices", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "StudentsLinkedToFee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Fee/ViewFee"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewFeePrice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 290, true);
            WriteLiteral(@"<section class=""content-header"">
    <h1>
        Fee
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <!-- Horizontal Form -->
    <div class=""box box-info"">
        <div class=""box-header with-border"">

            <h3 class=""box-title"">");
            EndContext();
            BeginContext(336, 10, false);
#line 14 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
                             Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(346, 91, true);
            WriteLiteral("</h3>\r\n        </div>\r\n        <!-- /.box-header -->\r\n        <!-- form start -->\r\n        ");
            EndContext();
            BeginContext(437, 3590, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79a271ab8e200dca32f3ea2842ad2a4e294d64318360", async() => {
                BeginContext(503, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 19 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
             if (ViewData["Error"] != null)
            {

#line default
#line hidden
                BeginContext(563, 62, true);
                WriteLiteral("<div class=\"container\">\r\n                    <strong class=\"\">");
                EndContext();
                BeginContext(626, 28, false);
#line 21 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
                                Write(ViewData["Error"].ToString());

#line default
#line hidden
                EndContext();
                BeginContext(654, 113, true);
                WriteLiteral("</strong>\r\n                    <div class=\"panel panel-danger\">\r\n                        <div class=\"panel-body\">");
                EndContext();
                BeginContext(768, 24, false);
#line 23 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
                                           Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(792, 62, true);
                WriteLiteral("</div>\r\n                    </div>\r\n\r\n                </div>\r\n");
                EndContext();
#line 27 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
            }

#line default
#line hidden
                BeginContext(869, 290, true);
                WriteLiteral(@"            <div class=""box-body"">

                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Name</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""Name""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1159, "\"", 1178, 1);
#line 33 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
WriteAttributeValue("", 1167, Model.Name, 1167, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1179, 261, true);
                WriteLiteral(@">
                    </div>
                </div>
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Frequency</label>
                    <div class=""col-sm-10"">
                        ");
                EndContext();
                BeginContext(1440, 183, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79a271ab8e200dca32f3ea2842ad2a4e294d643111221", async() => {
                    BeginContext(1528, 30, true);
                    WriteLiteral("\r\n                            ");
                    EndContext();
                    BeginContext(1558, 30, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79a271ab8e200dca32f3ea2842ad2a4e294d643111656", async() => {
                        BeginContext(1575, 4, true);
                        WriteLiteral("----");
                        EndContext();
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
                    EndContext();
                    BeginContext(1588, 26, true);
                    WriteLiteral("\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 39 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FeeFrequencyID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 39 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.FrequencyList;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1623, 330, true);
                WriteLiteral(@"
                    </div>
                </div>


                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Active Status</label>
                    <div class=""col-sm-2"">

                        <label class=""checkbox-inline"">
                            ");
                EndContext();
                BeginContext(1954, 41, false);
#line 51 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
                       Write(Html.CheckBoxFor(model => model.IsActive));

#line default
#line hidden
                EndContext();
                BeginContext(1995, 326, true);
                WriteLiteral(@"
                        </label>
                      
                    </div>
                </div>

                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Pricing History</label>
                    <div class=""col-sm-10"">
                        ");
                EndContext();
                BeginContext(2321, 108, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79a271ab8e200dca32f3ea2842ad2a4e294d643116108", async() => {
                    BeginContext(2401, 24, false);
#line 60 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
                                                                                                  Write(Model.FeePrices?.Count());

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 60 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
                                                                             WriteLiteral(Model.FeeID);

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
                BeginContext(2429, 268, true);
                WriteLiteral(@"
                    </div>
                </div>

                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Students on Fee</label>
                    <div class=""col-sm-10"">
                        ");
                EndContext();
                BeginContext(2697, 113, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79a271ab8e200dca32f3ea2842ad2a4e294d643119263", async() => {
                    BeginContext(2783, 23, false);
#line 67 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
                                                                                                        Write(Model.Students?.Count());

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 67 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
                                                                                   WriteLiteral(Model.FeeID);

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
                BeginContext(2810, 327, true);
                WriteLiteral(@"
                    </div>
                </div>

                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">LastChanged By</label>
                    <div class=""col-sm-10"">
                        <label for=""inputEmail3"" class=""form-control label-default"">");
                EndContext();
                BeginContext(3138, 19, false);
#line 74 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
                                                                               Write(Model.LastChangedBy);

#line default
#line hidden
                EndContext();
                BeginContext(3157, 333, true);
                WriteLiteral(@"</label>
                    </div>
                </div>

                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Last Updated</label>
                    <div class=""col-sm-10"">
                        <label for=""inputEmail3"" class=""form-control label-default"">");
                EndContext();
                BeginContext(3491, 51, false);
#line 81 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
                                                                               Write(UtilityService.ShowDateTime(@Model.LastChangedDate));

#line default
#line hidden
                EndContext();
                BeginContext(3542, 111, true);
                WriteLiteral("</label>\r\n                    </div>\r\n                </div>\r\n                <input type=\"hidden\" name=\"FeeID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3653, "\"", 3673, 1);
#line 84 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
WriteAttributeValue("", 3661, Model.FeeID, 3661, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3674, 112, true);
                WriteLiteral(" />\r\n            </div>\r\n            <!-- /.box-body -->\r\n            <div class=\"box-footer\">\r\n                ");
                EndContext();
                BeginContext(3786, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79a271ab8e200dca32f3ea2842ad2a4e294d643124321", async() => {
                    BeginContext(3858, 6, true);
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
                BeginContext(3868, 152, true);
                WriteLiteral("\r\n                <button type=\"submit\" class=\"btn btn-info pull-right\">Update</button>\r\n            </div>\r\n            <!-- /.box-footer -->\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4027, 952, true);
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
                    <ul class=""nav nav-tabs"">
                        <li class=""active"">
                            <a href=""#PricingHistory"" data-toggle=""tab"">Pricing History</a>
                        </li>
                       

                    </ul>
                    <!-- Tab panes -->
                    <div class=""tab-content"">
                        <div class=""tab-pane fade in active"" id=""PricingHistory"">

                            <div class=""panel panel-default"">
                                <div class=""panel-heading"">
                                    Fee: ");
            EndContext();
            BeginContext(4980, 10, false);
#line 115 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
                                    Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4990, 1103, true);
            WriteLiteral(@"
                                </div>
                            </div>
                            <!-- /.panel-heading -->
                            <div class=""panel-body"">
                                <div class=""dataTable_wrapper"">
                                    <table class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
                                        <thead>
                                            <tr>
                                                <th>Amount</th>
                                                <th>Discount</th>
                                                <th>Period</th>
                                                <th>Last Changed Date</th>
                                                <th>Changed By</th>
                                                <th>Active Status</th>
                                                <th>Action</th>
                                            </tr>
                    ");
            WriteLiteral("                    </thead>\r\n                                        <tbody>\r\n");
            EndContext();
#line 134 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
                                             if (Model != null)
                                            {

                                                

#line default
#line hidden
#line 137 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
                                                 foreach (var item in Model.FeePrices)
                                                {


#line default
#line hidden
            BeginContext(6348, 50, true);
            WriteLiteral("                                            <tr>\r\n");
            EndContext();
#line 141 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
                                                   string hasDiscount = UtilityService.ShowYesOrNo(item.HasDiscount);
                                                    string dateCreated = UtilityService.ShowDateTime(item.LastChangedDate);
                                                  

                                                

#line default
#line hidden
            BeginContext(6747, 54, true);
            WriteLiteral("\r\n                                                <td>");
            EndContext();
            BeginContext(6802, 41, false);
#line 147 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(6843, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(6903, 43, false);
#line 148 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Discount));

#line default
#line hidden
            EndContext();
            BeginContext(6946, 113, true);
            WriteLiteral("</td>\r\n                                                <td>\r\n                                                    ");
            EndContext();
            BeginContext(7060, 41, false);
#line 150 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Period));

#line default
#line hidden
            EndContext();
            BeginContext(7101, 105, true);
            WriteLiteral("\r\n                                                </td>\r\n                                            <td>");
            EndContext();
            BeginContext(7207, 11, false);
#line 152 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
                                           Write(dateCreated);

#line default
#line hidden
            EndContext();
            BeginContext(7218, 55, true);
            WriteLiteral("</td>\r\n                                            <td>");
            EndContext();
            BeginContext(7274, 48, false);
#line 153 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.LastChangedBy));

#line default
#line hidden
            EndContext();
            BeginContext(7322, 100, true);
            WriteLiteral("</td>\r\n                                           \r\n                                            <td>");
            EndContext();
            BeginContext(7422, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79a271ab8e200dca32f3ea2842ad2a4e294d643133713", async() => {
                BeginContext(7472, 4, true);
                WriteLiteral("View");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7480, 58, true);
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
            EndContext();
#line 157 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
                                                }

#line default
#line hidden
#line 157 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Fee\ViewFee.cshtml"
                                                 
                                            }

#line default
#line hidden
            BeginContext(7636, 499, true);
            WriteLiteral(@"                                    </table>
                                </div>
                            </div>
                            <div class=""box-footer"">
                                <a class=""btn  btn-small btn-success pull-right"" data-toggle=""modal"" data-target=""#DocumentForm"">Add Permission</a>
                            </div>
                        </div>
                        </div>
                    </div>
                    <!-- /.box -->
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartDomain.Fee> Html { get; private set; }
    }
}
#pragma warning restore 1591
