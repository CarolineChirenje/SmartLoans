#pragma checksum "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a1596f57ceba4ec39bb7e27eedf1548edb3aa0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transactions_InvoiceDetails), @"mvc.1.0.view", @"/Views/Transactions/InvoiceDetails.cshtml")]
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
#line 2 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
using SmartHelper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1596f57ceba4ec39bb7e27eedf1548edb3aa0f", @"/Views/Transactions/InvoiceDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1af0fb89db395063d8921ee12bbd8af94a13b0be", @"/Views/_ViewImports.cshtml")]
    public class Views_Transactions_InvoiceDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartDomain.InvoiceDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Dashboard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Client", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewClient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Transactions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PrintSchedule", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Transactions/DeleteInvoiceEntries"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
  
    TempData["Title"] = "Deductions";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"content-header\">\r\n    <h1>\r\n        ");
#nullable restore
#line 9 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
   Write(TempData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n    <ol class=\"breadcrumb\">\r\n        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a1596f57ceba4ec39bb7e27eedf1548edb3aa0f9116", async() => {
                WriteLiteral("<i class=\"fa fa-dashboard\"></i> Home");
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
            WriteLiteral("</li>\r\n        <li class=\"active\">");
#nullable restore
#line 13 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                      Write(TempData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ol>\r\n</section>\r\n<!-- Main content -->\r\n<section class=\"content\">\r\n    <div class=\"row\">\r\n        <div class=\"col-xs-12\">\r\n            <div class=\"box\">\r\n                <div class=\"box-header\">\r\n                    <h3 class=\"box-title\">\r\n");
#nullable restore
#line 23 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                         if (Model != null)
                        {
                            Model.InvoiceTitle.ToString();
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </h3>\r\n                </div>\r\n                <!-- /.box-header -->\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a1596f57ceba4ec39bb7e27eedf1548edb3aa0f11240", async() => {
                WriteLiteral("\r\n                    <div class=\"box-body\">\r\n");
#nullable restore
#line 32 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                         if (TempData["Error"] != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"container\">\r\n                                <strong");
                BeginWriteAttribute("class", " class=\"", 1145, "\"", 1153, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 34 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                                            Write(TempData["Error"].ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                                <div class=\"panel panel-danger\">\r\n                                    <div class=\"panel-body\">");
#nullable restore
#line 36 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                                                       Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 39 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                        <div class=""dataTable_wrapper"">
                            <table class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
                                <thead>
                                    <tr>
");
#nullable restore
#line 46 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                                         if (Model.State != InvoiceState.Finalised)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <th>Select To Delete</th>\r\n");
#nullable restore
#line 49 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
}

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        <th>Affiliation</th>
                                        <th>Name</th>
                                        <th>Occupation</th>
                                        <th>Salary</th>
                                        <th>Product</th>
                                        <th>Invoice Number</th>
                                        <th>Sub Invoice Number</th>
                                        <th>Amount Due</th>

                                    </tr>
                                </thead>
                                <tbody class=""odd gradeX"">
");
#nullable restore
#line 62 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                                     foreach (var item in Model.DeductionDetails)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <tr>\r\n");
#nullable restore
#line 65 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                                              
                                                string affiliation = String.Empty;
                                                if (UtilityService.IsNotNull(item.Client.ClientGroup))
                                                {
                                                    affiliation = item.Client.ClientGroupID == (int)Affiliation.Individual ? "Individual" : (item.Client.CompanyID != null ? item.Client.Company.Name : "");
                                                }
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                                             if (Model.State != InvoiceState.Finalised)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <td align=\"center\"><input type=\"checkbox\" id=\"checkBoxAll\" name=\"ClientDeductionDetailID\"");
                BeginWriteAttribute("value", " value=\"", 3586, "\"", 3623, 1);
#nullable restore
#line 74 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
WriteAttributeValue("", 3594, item.ClientDeductionDetailID, 3594, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /></td>\r\n");
#nullable restore
#line 75 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"

                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <td>");
#nullable restore
#line 77 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                                           Write(affiliation);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 78 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                                             if (UtilityService.HasPermission(Permissions.View_User))
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a1596f57ceba4ec39bb7e27eedf1548edb3aa0f17493", async() => {
#nullable restore
#line 80 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                                                                                                                                Write(item.Client.ClientFullName);

#line default
#line hidden
#nullable disable
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
#nullable restore
#line 80 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                                                                                                         WriteLiteral(item.ClientID);

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
#line 81 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <td>");
#nullable restore
#line 84 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                                               Write(item.Client.ClientFullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 85 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <td>");
#nullable restore
#line 86 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Client.Occupation));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 87 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Client.Salary));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 88 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                                             if (UtilityService.HasPermission(Permissions.View_Product))
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a1596f57ceba4ec39bb7e27eedf1548edb3aa0f22322", async() => {
#nullable restore
#line 90 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                                                                                                                                   Write(item.Product.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                                                                                                           WriteLiteral(item.ProductID);

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
#line 91 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <td>");
#nullable restore
#line 94 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                                               Write(item.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 95 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <td>");
#nullable restore
#line 96 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                                           Write(item.ClientDeductionID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 97 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                                           Write(item.InvoiceNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n                                            <td>");
#nullable restore
#line 99 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.DeductedAmount));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n\r\n\r\n                                        </tr>\r\n");
#nullable restore
#line 104 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </table>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"box-footer\">\r\n\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a1596f57ceba4ec39bb7e27eedf1548edb3aa0f27513", async() => {
                    WriteLiteral("Print Schedule");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("<br />\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a1596f57ceba4ec39bb7e27eedf1548edb3aa0f29606", async() => {
                    WriteLiteral("Cancel");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 112 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                         if (UtilityService.HasPermission(Permissions.Remove_Invoice_Entries))
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("<button type=\"submit\" class=\"btn btn-danger\">Remove Multiple Invoice Entries</button>\r\n");
#nullable restore
#line 114 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\InvoiceDetails.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n\r\n                    <!-- /.box-body -->\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <!-- /.box -->\r\n        </div>\r\n        <!-- /.col -->\r\n    </div>\r\n    <!-- /.row -->\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartDomain.InvoiceDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
