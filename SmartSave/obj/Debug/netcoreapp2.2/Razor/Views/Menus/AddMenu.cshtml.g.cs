#pragma checksum "D:\Dev Projects\SmartFin\SmartAdmin\Views\Menus\AddMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "999bb176caa06a60db43d8dc562822339ad562fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menus_AddMenu), @"mvc.1.0.view", @"/Views/Menus/AddMenu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Menus/AddMenu.cshtml", typeof(AspNetCore.Views_Menus_AddMenu))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"999bb176caa06a60db43d8dc562822339ad562fa", @"/Views/Menus/AddMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9906be48bf7b893089acfeca7d3efff7da363c1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Menus_AddMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartDomain.Menu>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("AddMenu"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(25, 427, true);
            WriteLiteral(@"<!-- Content Header (Page header) -->
<section class=""content-header"">
    <h1>
        Menu
    </h1>
</section>
<!-- Main content -->
<section class=""content container-fluid"">
    <!-- Horizontal Form -->
    <div class=""box box-info"">
        <div class=""box-header with-border"">
            <h3 class=""box-title"">Add Menu</h3>
        </div>
        <!-- /.box-header -->
        <!-- form start -->
        ");
            EndContext();
            BeginContext(452, 3606, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "999bb176caa06a60db43d8dc562822339ad562fa6439", async() => {
                BeginContext(513, 38, true);
                WriteLiteral("\r\n            <div class=\"box-body\">\r\n");
                EndContext();
#line 19 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Menus\AddMenu.cshtml"
                 if (ViewData["Error"] != null)
                {

#line default
#line hidden
                BeginContext(617, 66, true);
                WriteLiteral("<div class=\"container\">\r\n                        <strong class=\"\">");
                EndContext();
                BeginContext(684, 28, false);
#line 21 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Menus\AddMenu.cshtml"
                                    Write(ViewData["Error"].ToString());

#line default
#line hidden
                EndContext();
                BeginContext(712, 121, true);
                WriteLiteral("</strong>\r\n                        <div class=\"panel panel-danger\">\r\n                            <div class=\"panel-body\">");
                EndContext();
                BeginContext(834, 24, false);
#line 23 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Menus\AddMenu.cshtml"
                                               Write(Html.ValidationSummary());

#line default
#line hidden
                EndContext();
                BeginContext(858, 68, true);
                WriteLiteral("</div>\r\n                        </div>\r\n                    </div>\r\n");
                EndContext();
#line 26 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Menus\AddMenu.cshtml"
                }

#line default
#line hidden
                BeginContext(945, 1623, true);
                WriteLiteral(@"                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Display Name</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""DisplayName"" placeholder=""Name"" required>

                    </div>
                </div>
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Controller Name</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""ControllerName"" placeholder=""Controller Name"" required>

                    </div>
                </div>
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Action Name</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""ActionName"" placeholder=""Action Name"" required>
");
                WriteLiteral(@"
                    </div>
                </div>
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Style</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""CSSClass"" placeholder=""Name"">

                    </div>
                </div>

                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Menu Group </label>
                    <div class=""col-sm-10"">

                        ");
                EndContext();
                BeginContext(2568, 248, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "999bb176caa06a60db43d8dc562822339ad562fa10143", async() => {
                    BeginContext(2730, 30, true);
                    WriteLiteral("\r\n                            ");
                    EndContext();
                    BeginContext(2760, 21, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "999bb176caa06a60db43d8dc562822339ad562fa10578", async() => {
                        BeginContext(2768, 4, true);
                        WriteLiteral("----");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2781, 26, true);
                    WriteLiteral("\r\n                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 60 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Menus\AddMenu.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MenuGroupID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 61 "D:\Dev Projects\SmartFin\SmartAdmin\Views\Menus\AddMenu.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.MenuGroups,"MenuGroupID","DisplayName"));

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
                BeginContext(2816, 1001, true);
                WriteLiteral(@"

                    </div>
                </div>
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Order No</label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""OrderNo"" placeholder=""Order Number"">

                    </div>
                </div>
                <div class=""form-group"">
                    <label for=""inputEmail3"" class=""col-sm-2 control-label"">Status</label>
                    <div class=""checkbox"">
                        <input type=""hidden"" name=""IsActive"" value=""false"" />
                        <label class=""checkbox-inline"">
                            <input type=""checkbox"" class=""minimal"" name=""IsActive"" checked />
                        </label>
                    </div>
                </div>
            </div>
            <!-- /.box-body -->
            <div class=""box-footer"">
                ");
                EndContext();
                BeginContext(3817, 82, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "999bb176caa06a60db43d8dc562822339ad562fa14852", async() => {
                    BeginContext(3889, 6, true);
                    WriteLiteral("Cancel");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3899, 152, true);
                WriteLiteral("\r\n                <button type=\"submit\" class=\"btn btn-info pull-right\">Create</button>\r\n            </div>\r\n            <!-- /.box-footer -->\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4058, 44, true);
            WriteLiteral("\r\n    </div>\r\n    <!-- /.box -->\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartDomain.Menu> Html { get; private set; }
    }
}
#pragma warning restore 1591
