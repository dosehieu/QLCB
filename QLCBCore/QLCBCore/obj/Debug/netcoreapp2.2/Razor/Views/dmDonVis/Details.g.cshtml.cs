#pragma checksum "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c42df7ec5d123c55b828dc20a1dcd250617ad14"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_dmDonVis_Details), @"mvc.1.0.view", @"/Views/dmDonVis/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/dmDonVis/Details.cshtml", typeof(AspNetCore.Views_dmDonVis_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c42df7ec5d123c55b828dc20a1dcd250617ad14", @"/Views/dmDonVis/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df8d2327fad9e658ad606e5b92cad80f040e3425", @"/Views/_ViewImports.cshtml")]
    public class Views_dmDonVis_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QLCBCore.Models.dmDonVi>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(124, 130, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>dmDonVi</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(255, 43, false);
#line 15 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaDonVi));

#line default
#line hidden
            EndContext();
            BeginContext(298, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(362, 39, false);
#line 18 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaDonVi));

#line default
#line hidden
            EndContext();
            BeginContext(401, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(464, 44, false);
#line 21 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TenDonVi));

#line default
#line hidden
            EndContext();
            BeginContext(508, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(572, 40, false);
#line 24 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Details.cshtml"
       Write(Html.DisplayFor(model => model.TenDonVi));

#line default
#line hidden
            EndContext();
            BeginContext(612, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(675, 44, false);
#line 27 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RegionID));

#line default
#line hidden
            EndContext();
            BeginContext(719, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(783, 40, false);
#line 30 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Details.cshtml"
       Write(Html.DisplayFor(model => model.RegionID));

#line default
#line hidden
            EndContext();
            BeginContext(823, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(886, 41, false);
#line 33 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaCha));

#line default
#line hidden
            EndContext();
            BeginContext(927, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(991, 37, false);
#line 36 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaCha));

#line default
#line hidden
            EndContext();
            BeginContext(1028, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1091, 40, false);
#line 39 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Leve));

#line default
#line hidden
            EndContext();
            BeginContext(1131, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1195, 36, false);
#line 42 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Details.cshtml"
       Write(Html.DisplayFor(model => model.Leve));

#line default
#line hidden
            EndContext();
            BeginContext(1231, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1294, 39, false);
#line 45 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.STT));

#line default
#line hidden
            EndContext();
            BeginContext(1333, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1397, 35, false);
#line 48 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Details.cshtml"
       Write(Html.DisplayFor(model => model.STT));

#line default
#line hidden
            EndContext();
            BeginContext(1432, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1495, 46, false);
#line 51 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TenVietTat));

#line default
#line hidden
            EndContext();
            BeginContext(1541, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1605, 42, false);
#line 54 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Details.cshtml"
       Write(Html.DisplayFor(model => model.TenVietTat));

#line default
#line hidden
            EndContext();
            BeginContext(1647, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1710, 45, false);
#line 57 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.KieuDonvi));

#line default
#line hidden
            EndContext();
            BeginContext(1755, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1819, 41, false);
#line 60 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Details.cshtml"
       Write(Html.DisplayFor(model => model.KieuDonvi));

#line default
#line hidden
            EndContext();
            BeginContext(1860, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1923, 46, false);
#line 63 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DonViAllID));

#line default
#line hidden
            EndContext();
            BeginContext(1969, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2033, 42, false);
#line 66 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Details.cshtml"
       Write(Html.DisplayFor(model => model.DonViAllID));

#line default
#line hidden
            EndContext();
            BeginContext(2075, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2138, 45, false);
#line 69 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsDeleted));

#line default
#line hidden
            EndContext();
            BeginContext(2183, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2247, 41, false);
#line 72 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsDeleted));

#line default
#line hidden
            EndContext();
            BeginContext(2288, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2335, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c42df7ec5d123c55b828dc20a1dcd250617ad1412621", async() => {
                BeginContext(2381, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\ABC\Documents\QLCB\QLCBCore\QLCBCore\Views\dmDonVis\Details.cshtml"
                           WriteLiteral(Model.ID);

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
            BeginContext(2389, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2397, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c42df7ec5d123c55b828dc20a1dcd250617ad1414939", async() => {
                BeginContext(2419, 12, true);
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
            BeginContext(2435, 10, true);
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
