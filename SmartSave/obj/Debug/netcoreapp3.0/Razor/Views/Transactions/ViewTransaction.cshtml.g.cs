#pragma checksum "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65e853bff02e5e38992a830f9449d2283fd5b207"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transactions_ViewTransaction), @"mvc.1.0.view", @"/Views/Transactions/ViewTransaction.cshtml")]
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
#line 2 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
using SmartHelper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65e853bff02e5e38992a830f9449d2283fd5b207", @"/Views/Transactions/ViewTransaction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1af0fb89db395063d8921ee12bbd8af94a13b0be", @"/Views/_ViewImports.cshtml")]
    public class Views_Transactions_ViewTransaction : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartDomain.Transaction>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Client", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewClient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Transactions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ActionTransaction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PrintTransaction", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Transactions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("ViewTransaction"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<section class=\"content-header\">\r\n    <h1>\r\n        ");
#nullable restore
#line 5 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
   Write(Model.TransRef);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n</section>\r\n<!-- Main content -->\r\n<section class=\"content container-fluid\">\r\n    <!-- Horizontal Form -->\r\n    <div class=\"box box-info\">\r\n        <div class=\"box-header with-border\">\r\n\r\n            <h3 class=\"box-title\">");
#nullable restore
#line 14 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
                             Write(Model.TransactionType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        </div>\r\n        <!-- /.box-header -->\r\n        <!-- form start -->\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65e853bff02e5e38992a830f9449d2283fd5b2079287", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 20 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
             if (ViewData["Error"] != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"container\">\r\n                    <div class=\"text-danger\">");
#nullable restore
#line 22 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
                                        Write(ViewData["Error"].ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                </div>\r\n");
#nullable restore
#line 24 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 26 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
             if (ViewData["Success"] != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"container\">\r\n                    <div class=\"text-success\">");
#nullable restore
#line 28 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
                                         Write(ViewData["Success"].ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                </div>\r\n");
#nullable restore
#line 30 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
             if (ViewData["Warning"] != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"container\">\r\n                    <div class=\"text-warning\">");
#nullable restore
#line 33 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
                                         Write(ViewData["Warning"].ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                </div>\r\n");
#nullable restore
#line 35 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <div class=""box-body"">

                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Transaction Ref</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""TransRef"" disabled=""disabled""");
                BeginWriteAttribute("value", " value=\"", 1495, "\"", 1518, 1);
#nullable restore
#line 41 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
WriteAttributeValue("", 1503, Model.TransRef, 1503, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                </div>

                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Bank Account</label>
                    <div class=""col-sm-10"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65e853bff02e5e38992a830f9449d2283fd5b20713068", async() => {
                    WriteLiteral("\r\n                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65e853bff02e5e38992a830f9449d2283fd5b20713365", async() => {
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
                    WriteLiteral("\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 48 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BankAccountID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 48 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.BankAccountList;

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
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Transaction Date</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""TransactionDate"" disabled=""disabled""");
                BeginWriteAttribute("value", " value=\"", 2318, "\"", 2378, 1);
#nullable restore
#line 56 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
WriteAttributeValue("", 2326, UtilityService.ShowDateTime(@Model.TransactionDate), 2326, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                </div>
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Payment Date</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""PaymentDate"" disabled=""disabled""");
                BeginWriteAttribute("value", " value=\"", 2721, "\"", 2776, 1);
#nullable restore
#line 62 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
WriteAttributeValue("", 2729, UtilityService.ShowDateTime(Model.PaymentDate), 2729, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"inputEmail3\" class=\"col-sm-2 control-label\">Client Details</label>\r\n                    <div class=\"col-sm-10\">\r\n");
#nullable restore
#line 68 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
                         if (UtilityService.HasPermission(Permissions.View_Client))
                        {

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65e853bff02e5e38992a830f9449d2283fd5b20718591", async() => {
#nullable restore
#line 69 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
                                                                                                      Write(Model.Client.ClientRef);

#line default
#line hidden
#nullable disable
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
#nullable restore
#line 69 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
                                                                              WriteLiteral(Model.ClientID);

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
                WriteLiteral("\r\n");
#nullable restore
#line 70 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"text\" class=\"form-control\" disabled=\"disabled\"");
                BeginWriteAttribute("value", " value=\"", 3395, "\"", 3426, 1);
#nullable restore
#line 73 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
WriteAttributeValue("", 3403, Model.Client.ClientRef, 3403, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 74 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </div>
                </div>
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Transaction Type</label>
                    <div class=""col-sm-10"">

                        <input type=""text"" class=""form-control"" name=""TransactionTypeID"" disabled=""disabled""");
                BeginWriteAttribute("value", " value=\"", 3804, "\"", 3839, 1);
#nullable restore
#line 81 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
WriteAttributeValue("", 3812, Model.TransactionType.Name, 3812, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                </div>

                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Payment Type</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" disabled=""disabled""");
                BeginWriteAttribute("value", " value=\"", 4165, "\"", 4192, 1);
#nullable restore
#line 88 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
WriteAttributeValue("", 4173, Model.Product.Name, 4173, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                </div>

                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Amount Excl VAT</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""AmountExclVAT"" disabled=""disabled""");
                BeginWriteAttribute("value", " value=\"", 4542, "\"", 4570, 1);
#nullable restore
#line 95 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
WriteAttributeValue("", 4550, Model.AmountExclVAT, 4550, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                </div>
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">VAT</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""VAT"" disabled=""disabled""");
                BeginWriteAttribute("value", " value=\"", 4896, "\"", 4914, 1);
#nullable restore
#line 101 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
WriteAttributeValue("", 4904, Model.VAT, 4904, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                </div>
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Amount Incl VAT</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""Amount"" disabled=""disabled""");
                BeginWriteAttribute("value", " value=\"", 5255, "\"", 5276, 1);
#nullable restore
#line 107 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
WriteAttributeValue("", 5263, Model.Amount, 5263, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                </div>

                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Total Paid</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""TotalPaid"" disabled=""disabled""");
                BeginWriteAttribute("value", " value=\"", 5617, "\"", 5641, 1);
#nullable restore
#line 114 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
WriteAttributeValue("", 5625, Model.TotalPaid, 5625, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                </div>
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Payment Status</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""Payment"" disabled=""disabled""");
                BeginWriteAttribute("value", " value=\"", 5982, "\"", 6015, 1);
#nullable restore
#line 120 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
WriteAttributeValue("", 5990, Model.PaymentStatus.Name, 5990, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                </div>
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Last Changed By</label>
                    <div class=""col-sm-10"">
                        <label for=""inputEmail3"" class=""form-control label-default"">");
#nullable restore
#line 126 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
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
#line 133 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
                                                                               Write(UtilityService.ShowDateTime(@Model.LastChangedDate));

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </div>\r\n                </div>\r\n                <input type=\"hidden\" name=\"TransactionID\"");
                BeginWriteAttribute("value", " value=\"", 6867, "\"", 6895, 1);
#nullable restore
#line 136 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
WriteAttributeValue("", 6875, Model.TransactionID, 6875, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n            </div>\r\n            <!-- /.box-body -->\r\n            <div class=\"box-footer\">\r\n\r\n");
#nullable restore
#line 142 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
                  

                    int transactionTypeID = (int)TransactionTypeList.Reversal;
                    if (UtilityService.HasPermission(Permissions.Reverse_Payment))
                    {
                        if (Model.PaymentStatusID != (int)PaymentState.Reversed)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65e853bff02e5e38992a830f9449d2283fd5b20729960", async() => {
                    WriteLiteral("Reverse Transaction");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 149 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
                                                                                                                     WriteLiteral(Model.TransactionID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 149 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
                                                                                                                                                                        WriteLiteral(transactionTypeID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["transactionTypeID"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-transactionTypeID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["transactionTypeID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 150 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
                        }
                    }

                

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65e853bff02e5e38992a830f9449d2283fd5b20733790", async() => {
                    WriteLiteral("Generate PDF");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 155 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\ViewTransaction.cshtml"
                                                                                                         WriteLiteral(Model.TransactionID);

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
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65e853bff02e5e38992a830f9449d2283fd5b20736436", async() => {
                    WriteLiteral("Cancel");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n            <!-- /.box-footer -->\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <!-- /.box -->\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartDomain.Transaction> Html { get; private set; }
    }
}
#pragma warning restore 1591
