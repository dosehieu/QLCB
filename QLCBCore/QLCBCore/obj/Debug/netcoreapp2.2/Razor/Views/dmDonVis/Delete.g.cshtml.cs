#pragma checksum "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ee052d4a8b9544efa287b91414703a72936d43a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_dmDonVis_Delete), @"mvc.1.0.view", @"/Views/dmDonVis/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/dmDonVis/Delete.cshtml", typeof(AspNetCore.Views_dmDonVis_Delete))]
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
#line 1 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\_ViewImports.cshtml"
using QLCBCore;

#line default
#line hidden
#line 2 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\_ViewImports.cshtml"
using QLCBCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ee052d4a8b9544efa287b91414703a72936d43a", @"/Views/dmDonVis/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df8d2327fad9e658ad606e5b92cad80f040e3425", @"/Views/_ViewImports.cshtml")]
    public class Views_dmDonVis_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QLCBCore.Models.dmDonVi>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(123, 177, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>dmDonVi</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(301, 43, false);
#line 16 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaDonVi));

#line default
#line hidden
            EndContext();
            BeginContext(344, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(408, 39, false);
#line 19 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaDonVi));

#line default
#line hidden
            EndContext();
            BeginContext(447, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(510, 44, false);
#line 22 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TenDonVi));

#line default
#line hidden
            EndContext();
            BeginContext(554, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(618, 40, false);
#line 25 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TenDonVi));

#line default
#line hidden
            EndContext();
            BeginContext(658, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(721, 44, false);
#line 28 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RegionID));

#line default
#line hidden
            EndContext();
            BeginContext(765, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(829, 40, false);
#line 31 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RegionID));

#line default
#line hidden
            EndContext();
            BeginContext(869, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(932, 41, false);
#line 34 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaCha));

#line default
#line hidden
            EndContext();
            BeginContext(973, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1037, 37, false);
#line 37 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaCha));

#line default
#line hidden
            EndContext();
            BeginContext(1074, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1137, 40, false);
#line 40 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Leve));

#line default
#line hidden
            EndContext();
            BeginContext(1177, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1241, 36, false);
#line 43 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Leve));

#line default
#line hidden
            EndContext();
            BeginContext(1277, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1340, 39, false);
#line 46 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.STT));

#line default
#line hidden
            EndContext();
            BeginContext(1379, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1443, 35, false);
#line 49 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.STT));

#line default
#line hidden
            EndContext();
            BeginContext(1478, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1541, 46, false);
#line 52 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TenVietTat));

#line default
#line hidden
            EndContext();
            BeginContext(1587, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1651, 42, false);
#line 55 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TenVietTat));

#line default
#line hidden
            EndContext();
            BeginContext(1693, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1756, 45, false);
#line 58 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.KieuDonvi));

#line default
#line hidden
            EndContext();
            BeginContext(1801, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1865, 41, false);
#line 61 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.KieuDonvi));

#line default
#line hidden
            EndContext();
            BeginContext(1906, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1969, 46, false);
#line 64 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DonViAllID));

#line default
#line hidden
            EndContext();
            BeginContext(2015, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2079, 42, false);
#line 67 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DonViAllID));

#line default
#line hidden
            EndContext();
            BeginContext(2121, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2184, 45, false);
#line 70 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IsDeleted));

#line default
#line hidden
            EndContext();
            BeginContext(2229, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2293, 41, false);
#line 73 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IsDeleted));

#line default
#line hidden
            EndContext();
            BeginContext(2334, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2372, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ee052d4a8b9544efa287b91414703a72936d43a13341", async() => {
                BeginContext(2398, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2408, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2ee052d4a8b9544efa287b91414703a72936d43a13734", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 78 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2444, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2527, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ee052d4a8b9544efa287b91414703a72936d43a15635", async() => {
                    BeginContext(2549, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2565, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2578, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QLCBCore.Models.dmDonVi> Html { get; private set; }
    }
}
#pragma warning restore 1591