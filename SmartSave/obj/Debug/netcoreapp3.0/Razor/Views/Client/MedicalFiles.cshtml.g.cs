#pragma checksum "D:\Dev Projects\SmartSave\SmartSave\Views\Client\MedicalFiles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15cc0e577f0591cf3a44ec65a536f2493e1526af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_MedicalFiles), @"mvc.1.0.view", @"/Views/Client/MedicalFiles.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
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
#line 2 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\MedicalFiles.cshtml"
using SmartHelper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\MedicalFiles.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15cc0e577f0591cf3a44ec65a536f2493e1526af", @"/Views/Client/MedicalFiles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1af0fb89db395063d8921ee12bbd8af94a13b0be", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_MedicalFiles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartInterfaces.Medical>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_MessageDisplay", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Client", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewMedicalDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ViewClient", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddClientMedicalDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\MedicalFiles.cshtml"
  
    TempData["Title"] = "Client Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Content Header (Page header) -->\r\n<section class=\"content-header\">\r\n    <h1>\r\n        ");
#nullable restore
#line 11 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\MedicalFiles.cshtml"
   Write(Model.ClientForm.ClientRef);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h1>\r\n</section>\r\n<!-- Main content -->\r\n<section class=\"content container-fluid\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "15cc0e577f0591cf3a44ec65a536f2493e1526af6611", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-12\">\r\n            <div class=\"tab-pane fade in\" id=\"MedicalDetails\">\r\n                <div class=\"panel panel-default\">\r\n                    <div class=\"panel-heading\">\r\n                        ");
#nullable restore
#line 22 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\MedicalFiles.cshtml"
                   Write(Model.ClientForm.ClientRef);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" - Medical Files
                    </div>
                </div>
                <!-- /.panel-heading -->
                <div class=""panel-body"">
                    <div class=""dataTable_wrapper"">
                        <table class=""table table-striped table-bordered table-hover"" id=""dataTables-example"">
                            <thead>
                                <tr>
                                    <th>Preffered Doctor</th>
                                    <th>Doctor Phone Number</th>
                                    <th>Medical Aid</th>
                                    <th>Medical Number</th>
                                    <th>Preffered Hospital</th>

                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 40 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\MedicalFiles.cshtml"
                                 if (Model.MedicalList != null)
                                {

                                    foreach (var item in Model.MedicalList)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15cc0e577f0591cf3a44ec65a536f2493e1526af9556", async() => {
#nullable restore
#line 46 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\MedicalFiles.cshtml"
                                                                                                                                          Write(item.Doctor);

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
#line 46 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\MedicalFiles.cshtml"
                                                                                                            WriteLiteral(item.ClientMedicalID);

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
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 47 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\MedicalFiles.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Telephone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 48 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\MedicalFiles.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.MedicalAid));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 49 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\MedicalFiles.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.MedicalAidNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 50 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\MedicalFiles.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Hospital));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 52 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\MedicalFiles.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </table>\r\n                    </div>\r\n                </div>\r\n\r\n                <div class=\"box-footer\">\r\n");
#nullable restore
#line 59 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\MedicalFiles.cshtml"
                     if (UtilityService.HasPermission(Permissions.Add_Client_Medical_Details))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a class=\"btn  btn-small btn-success pull-right\" data-toggle=\"modal\" data-target=\"#ClientMedicalForm\">Create Medical Record</a>\r\n");
#nullable restore
#line 62 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\MedicalFiles.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15cc0e577f0591cf3a44ec65a536f2493e1526af14729", async() => {
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
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\MedicalFiles.cshtml"
                                                                                                 WriteLiteral(Model.ClientForm.ClientID);

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
            WriteLiteral(@"

                </div>
            </div>
        </div>
    </div>

    <!-- /.box -->
</section>
<div class=""modal fade"" id=""ClientMedicalForm"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">");
#nullable restore
#line 76 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\MedicalFiles.cshtml"
                                                          Write(Model.ClientForm.ClientRef);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\">\r\n                    <span aria-hidden=\"true\">&times;</span>\r\n                </button>\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15cc0e577f0591cf3a44ec65a536f2493e1526af18200", async() => {
                WriteLiteral(@"
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label for=""inputEmail3"" class=""col-sm-2 control-label"">Allergies <i>(If Any)</i>:</label>
                        <textarea class=""form-control"" name=""Allergies""></textarea>
                    </div>

                    <div class=""form-group"">
                        <label for=""inputEmail3"" class=""col-sm-2 control-label"">Prescribed Medication  <i>(If Any)</i>:</label>
                        <textarea class=""form-control"" name=""PrescribedMedication""></textarea>
                    </div>

                    <div class=""form-group"">
                        <label for=""inputEmail3"" class=""col-sm-2 control-label"">Preffered Hospital:</label>
                        <input type=""text"" class=""form-control"" name=""Hospital"">
                    </div>
                    <div class=""form-group"">
                        <label for=""inputEmail3"" class=""col-sm-2 control-label"">Preffered D");
                WriteLiteral(@"octor:</label>
                        <input type=""text"" class=""form-control"" name=""Doctor"">
                    </div>

                    <div class=""form-group"">
                        <label for=""inputEmail3"" class=""col-sm-2 control-label"">Doctor Phone Number:</label>
                        <input type=""tel"" class=""form-control"" name=""Telephone"">
                    </div>
                    <div class=""form-group"">
                        <label for=""inputEmail3"" class=""col-sm-2 control-label"">Medical Aid Name:</label>
                        <input type=""text"" class=""form-control"" name=""MedicalAid"">
                    </div>

                    <div class=""form-group"">
                        <label for=""inputEmail3"" class=""col-sm-2 control-label"">Medical Aid Number:</label>
                        <input type=""tel"" class=""form-control"" name=""MedicalAidNo"">
                    </div>

                    <div class=""form-group"">
                        <label for=""inputEmail3"" ");
                WriteLiteral("class=\"col-sm-2 control-label\">Other Information  <i>(If Any)</i>:</label>\r\n                        <textarea class=\"form-control\" name=\"Other\"></textarea>\r\n                    </div>\r\n\r\n                    <input type=\"hidden\" name=\"ClientID\"");
                BeginWriteAttribute("value", " value=\"", 6060, "\"", 6083, 1);
#nullable restore
#line 121 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\MedicalFiles.cshtml"
WriteAttributeValue("", 6068, Model.ClientID, 6068, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n                </div>\r\n                <div class=\"modal-footer\">\r\n");
#nullable restore
#line 125 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\MedicalFiles.cshtml"
                     if (UtilityService.HasPermission(Permissions.Add_Client_Medical_Details))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <button type=\"submit\" class=\"btn btn-primary\">Save</button>");
#nullable restore
#line 127 "D:\Dev Projects\SmartSave\SmartSave\Views\Client\MedicalFiles.cshtml"
                                                                                   }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <button type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartInterfaces.Medical> Html { get; private set; }
    }
}
#pragma warning restore 1591
