#pragma checksum "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\RecordPayment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ece035beca88460b6fc3982cd557bc4dcd50a76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transactions_RecordPayment), @"mvc.1.0.view", @"/Views/Transactions/RecordPayment.cshtml")]
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
#line 2 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\RecordPayment.cshtml"
using SmartHelper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ece035beca88460b6fc3982cd557bc4dcd50a76", @"/Views/Transactions/RecordPayment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1af0fb89db395063d8921ee12bbd8af94a13b0be", @"/Views/_ViewImports.cshtml")]
    public class Views_Transactions_RecordPayment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartDomain.Transaction>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("ClientID"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("GetProduct(this.value)"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Transactions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Transactions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("RecordPayment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\RecordPayment.cshtml"
  
    TempData["Title"] = "Add New Transaction";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Content Header (Page header) -->
<section class=""content-header"">
    <h1>
        Transaction Details
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <!-- Horizontal Form -->
    <div class=""box box-info"">
        <div class=""box-header with-border"">
            <h3 class=""box-title"">Add New Transaction</h3>
        </div>
        <!-- /.box-header -->
        <!-- form start -->
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ece035beca88460b6fc3982cd557bc4dcd50a767822", async() => {
                WriteLiteral("\r\n            <div class=\"box-body\">\r\n\r\n");
#nullable restore
#line 25 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\RecordPayment.cshtml"
                 if (TempData["Error"] != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"container\">\r\n                        <div class=\"text-danger\">");
#nullable restore
#line 27 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\RecordPayment.cshtml"
                                            Write(TempData["Error"].ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </div>\r\n");
#nullable restore
#line 29 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\RecordPayment.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 31 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\RecordPayment.cshtml"
                 if (TempData["Success"] != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"container\">\r\n                        <div class=\"text-success\">");
#nullable restore
#line 33 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\RecordPayment.cshtml"
                                             Write(TempData["Success"].ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </div>\r\n");
#nullable restore
#line 35 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\RecordPayment.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\RecordPayment.cshtml"
                 if (TempData["Warning"] != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"container\">\r\n                        <div class=\"text-warning\">");
#nullable restore
#line 38 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\RecordPayment.cshtml"
                                             Write(TempData["Warning"].ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                    </div>\r\n");
#nullable restore
#line 40 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\RecordPayment.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"form-group\">\r\n                    <label for=\"inputEmail3\" class=\"col-sm-2 control-label\">Employee Details</label>\r\n                    <div class=\"col-sm-10\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ece035beca88460b6fc3982cd557bc4dcd50a7610927", async() => {
                    WriteLiteral("\r\n                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ece035beca88460b6fc3982cd557bc4dcd50a7611224", async() => {
                        WriteLiteral("--- Select Employee ---");
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
#line 44 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\RecordPayment.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ClientID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 44 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\RecordPayment.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.ClientList;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Product</label>
                    <div class=""col-sm-10"">
                        <select id=""ProductList"" name=""ProductID"" class=""form-control"">
                        </select>
                        <span id=""ProductListNotFound"" class=""text-danger text-bold""></span>
                    </div>
                </div>


                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Bank Account</label>
                    <div class=""col-sm-10"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ece035beca88460b6fc3982cd557bc4dcd50a7615292", async() => {
                    WriteLiteral("\r\n                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ece035beca88460b6fc3982cd557bc4dcd50a7615589", async() => {
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
#line 63 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\RecordPayment.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.BankAccountID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 63 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\RecordPayment.cshtml"
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
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Transaction Type</label>
                    <div class=""col-sm-10"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ece035beca88460b6fc3982cd557bc4dcd50a7619006", async() => {
                    WriteLiteral("\r\n                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ece035beca88460b6fc3982cd557bc4dcd50a7619303", async() => {
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
#line 72 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\RecordPayment.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TransactionTypeID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 72 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\RecordPayment.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.TransactionTypeList;

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
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Payment Date:</label>
                    <div class=""col-sm-10"">
                        <input type=""date"" class=""form-control"" name=""PaymentDate"" ID=""PaymentDate"">
                    </div>
                </div>

                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Narration:</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""Narration"" ID=""Narration"">
                    </div>
                </div>

                <div class=""form-group"">
");
#nullable restore
#line 92 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\RecordPayment.cshtml"
                      

                        if (SmartHelper.UtilityService.PaymentsMustBeVatInclusive)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-sm-10\">\r\n                                <label class=\"text-danger\">Payment Amount Should be VAT Inclusive Actual Breakdown will be Automatically Calculated By The System using a VAT Percentage of ");
#nullable restore
#line 97 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\RecordPayment.cshtml"
                                                                                                                                                                                       Write(SmartHelper.UtilityService.VATPercentage);

#line default
#line hidden
#nullable disable
                WriteLiteral(" .</label>\r\n                            </div>\r\n");
#nullable restore
#line 99 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\RecordPayment.cshtml"
                        }

                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-sm-10\">\r\n                                <label class=\"text-danger\">Payment Amount Should be VAT Exclusive Actual Breakdown will be Automatically Calculated By The System using a VAT Percentage of ");
#nullable restore
#line 104 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\RecordPayment.cshtml"
                                                                                                                                                                                       Write(SmartHelper.UtilityService.VATPercentage);

#line default
#line hidden
#nullable disable
                WriteLiteral(" .</label>\r\n                            </div>\r\n");
#nullable restore
#line 106 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\RecordPayment.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </div>
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Pay Amount</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" id=""Amount"" name=""Amount"">
                        <span id=""AmountError"" class=""text-danger text-bold""></span>
                    </div>
                </div>
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">VAT</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""VAT"" disabled=""disabled"" value=""0.00"">
                    </div>
                </div>

                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Amount Excl VAT</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-cont");
                WriteLiteral("rol\" name=\"AmountExclVAT\" disabled=\"disabled\" value=\"0.00\">\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n            <!-- /.box-body -->\r\n            <div class=\"box-footer\">\r\n");
#nullable restore
#line 133 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\RecordPayment.cshtml"
                 if (UtilityService.HasPermission(Permissions.Make_Payment))
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <button type=\"submit\" class=\"btn btn-success pull-right\">Submit</button>\r\n");
#nullable restore
#line 136 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\RecordPayment.cshtml"

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ece035beca88460b6fc3982cd557bc4dcd50a7627514", async() => {
                    WriteLiteral("Cancel");
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
                WriteLiteral("\r\n\r\n            </div>\r\n            <!-- /.box-footer -->\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <!-- /.box -->
</section>
<script>


    $(document).ready(function () {

        document.getElementById('PaymentDate').value = new Date().toISOString().substring(0, 10);
        $('#ClientID').trigger(""change"");

    });


    $(function () {
        $('#Amount').blur(function () {
            var tempVal = $('#Amount').val();
            if (tempVal != this.value.match(/^\d+\.?\d{0,2}/)) {
                $(""#AmountError"").text(""Only Decimal Numbers Separated by a Decimal Point Are Allowed in this field"")
                $("":submit"").attr(""disabled"", true);
            }
            else {
                $(""#AmountError"").text("""");
                $("":submit"").removeAttr(""disabled"");
            }
        })
    })

    function GetProduct(_clientID) {
        var procemessage = ""<option value='0'> Please wait whilst we retrieve Products registered to Individual...</option>"";
        $(""#ProductList"").html(procemessage).show();
        var url = ""/Transactio");
            WriteLiteral(@"ns/GetProductByClientID/"";
       // alert(_clientID);
        $.ajax({
            url: url,
            data: { clientID: _clientID },
            cache: false,
            type: ""POST"",
            success: function (data) {
                var markup = ""<option value='0'>----</option>"";
                if (data == null || data.length == 0) {
                    $(""#ProductListNotFound"").text(""Individual is not registered to any Products"")
                    $("":submit"").attr(""disabled"", true);
                }
                else {
                    $(""#ProductListNotFound"").text("""");
                    $("":submit"").removeAttr(""disabled"");
                 
                    for (var x = 0; x < data.length; x++) {
                        markup += ""<option value="" + data[x].value + "">"" + data[x].text + ""</option>"";
                    }
                }
                $(""#ProductList"").html(markup).show();
            },
            error: function (reponse) {
           ");
            WriteLiteral("     alert(\"error : \" + reponse);\r\n            }\r\n        });\r\n\r\n    }\r\n</script>");
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
