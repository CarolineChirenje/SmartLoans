#pragma checksum "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\GeneratedInvoices.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28b0a8c512f5fd3cda9b1a569e431ae3a6a47e1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Transactions_GeneratedInvoices), @"mvc.1.0.view", @"/Views/Transactions/GeneratedInvoices.cshtml")]
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
#line 2 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\GeneratedInvoices.cshtml"
using SmartHelper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28b0a8c512f5fd3cda9b1a569e431ae3a6a47e1b", @"/Views/Transactions/GeneratedInvoices.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1af0fb89db395063d8921ee12bbd8af94a13b0be", @"/Views/_ViewImports.cshtml")]
    public class Views_Transactions_GeneratedInvoices : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SmartDomain.Invoice>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Dashboard"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Transactions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewInvoice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Invoices", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GenerateInvoice", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\GeneratedInvoices.cshtml"
  
    TempData["Title"] = "Generated Invoices";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"content-header\">\r\n    <h1>\r\n        ");
#nullable restore
#line 9 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\GeneratedInvoices.cshtml"
   Write(TempData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n    <ol class=\"breadcrumb\">\r\n        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28b0a8c512f5fd3cda9b1a569e431ae3a6a47e1b6673", async() => {
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
#line 13 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\GeneratedInvoices.cshtml"
                      Write(TempData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
    </ol>
</section>
<!-- Main content -->
<section class=""content"">
    <div class=""row"">
        <div class=""col-xs-12"">
            <div class=""box"">
                <div class=""box-header"">
                    <h3 class=""box-title"">Invoices</h3>
                </div>
                <!-- /.box-header -->

                <div class=""box-body"">
");
#nullable restore
#line 27 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\GeneratedInvoices.cshtml"
                     if (TempData["Error"] != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n                            <strong");
            BeginWriteAttribute("class", " class=\"", 866, "\"", 874, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 29 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\GeneratedInvoices.cshtml"
                                        Write(TempData["Error"].ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                            <div class=\"panel panel-danger\">\r\n                                <div class=\"panel-body\">");
#nullable restore
#line 31 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\GeneratedInvoices.cshtml"
                                                   Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 34 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\GeneratedInvoices.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <div class=""dataTable_wrapper"">
                        <table class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
                            <thead>
                                <tr>
                                    <th>Invoice Number</th>
                                    <th>Status</th>
                                    <th>Invoice Date</th>
                                    <th>Due Date</th>
                                    <th>Total Amount Due</th>
                                </tr>
                            </thead>
                            <tbody class=""odd gradeX"">
");
#nullable restore
#line 48 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\GeneratedInvoices.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n");
#nullable restore
#line 51 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\GeneratedInvoices.cshtml"
                                      
                                        string duedate = UtilityService.ShowDate(item.DueDate);
                                        string invoicedate = UtilityService.ShowDate(item.InvoiceDate);
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\GeneratedInvoices.cshtml"
                                     if (UtilityService.HasPermission(Permissions.View_Invoice))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28b0a8c512f5fd3cda9b1a569e431ae3a6a47e1b11713", async() => {
#nullable restore
#line 57 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\GeneratedInvoices.cshtml"
                                                                                                                                                Write(item.InvoiceID);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
#line 57 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\GeneratedInvoices.cshtml"
                                                                                                                        WriteLiteral(item.InvoiceID);

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
#line 58 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\GeneratedInvoices.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>");
#nullable restore
#line 61 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\GeneratedInvoices.cshtml"
                                       Write(item.InvoiceID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 62 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\GeneratedInvoices.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>");
#nullable restore
#line 63 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\GeneratedInvoices.cshtml"
                                   Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 64 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\GeneratedInvoices.cshtml"
                                   Write(invoicedate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 65 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\GeneratedInvoices.cshtml"
                                   Write(duedate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 66 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\GeneratedInvoices.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.TotalDeductedAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                </tr>\r\n");
#nullable restore
#line 68 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\GeneratedInvoices.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </table>\r\n                    </div>\r\n                </div>\r\n                <div class=\"box-footer\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28b0a8c512f5fd3cda9b1a569e431ae3a6a47e1b17037", async() => {
                WriteLiteral("Cancel");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 74 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\GeneratedInvoices.cshtml"
                     if (UtilityService.HasPermission(Permissions.Generate_Invoices))
                    {

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "28b0a8c512f5fd3cda9b1a569e431ae3a6a47e1b18753", async() => {
                WriteLiteral("Create Invoice");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 76 "D:\Dev Projects\SmartSave\SmartSave\Views\Transactions\GeneratedInvoices.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n\r\n                <!-- /.box-body -->\r\n\r\n            </div>\r\n            <!-- /.box -->\r\n        </div>\r\n        <!-- /.col -->\r\n    </div>\r\n    <!-- /.row -->\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SmartDomain.Invoice>> Html { get; private set; }
    }
}
#pragma warning restore 1591
