#pragma checksum "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\MAINBOARD\AddMainboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4515e76359ae938f81b4d307b513eaafbaca477"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MAINBOARD_AddMainboard), @"mvc.1.0.view", @"/Views/MAINBOARD/AddMainboard.cshtml")]
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
#line 1 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\_ViewImports.cshtml"
using ComputerSelection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\_ViewImports.cshtml"
using ComputerSelection.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4515e76359ae938f81b4d307b513eaafbaca477", @"/Views/MAINBOARD/AddMainboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3ec50d9d9922064009f375f53ee5581218d6006", @"/Views/_ViewImports.cshtml")]
    public class Views_MAINBOARD_AddMainboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ComputerSelection.Models.MAINBOARDViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddMainBoard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MainBoard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4515e76359ae938f81b4d307b513eaafbaca4773996", async() => {
                WriteLiteral("\r\n    <div class=\"form-horizontal\">\r\n        <h4>Add MainBoard</h4>\r\n        <hr />\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 8 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\MAINBOARD\AddMainboard.cshtml"
       Write(Html.LabelFor(model => model.Model, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 10 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\MAINBOARD\AddMainboard.cshtml"
           Write(Html.EditorFor(model => model.Model, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 11 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\MAINBOARD\AddMainboard.cshtml"
           Write(Html.ValidationMessageFor(model => model.Model, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\MAINBOARD\AddMainboard.cshtml"
       Write(Html.LabelFor(model => model.ProcessorModel, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 17 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\MAINBOARD\AddMainboard.cshtml"
           Write(Html.EditorFor(model => model.ProcessorModel, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 18 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\MAINBOARD\AddMainboard.cshtml"
           Write(Html.ValidationMessageFor(model => model.ProcessorModel, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 22 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\MAINBOARD\AddMainboard.cshtml"
       Write(Html.LabelFor(model => model.ProcessorSupport, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 24 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\MAINBOARD\AddMainboard.cshtml"
           Write(Html.EditorFor(model => model.ProcessorSupport, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 25 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\MAINBOARD\AddMainboard.cshtml"
           Write(Html.ValidationMessageFor(model => model.ProcessorSupport, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\MAINBOARD\AddMainboard.cshtml"
       Write(Html.LabelFor(model => model.Chipset, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 31 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\MAINBOARD\AddMainboard.cshtml"
           Write(Html.EditorFor(model => model.Chipset, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 32 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\MAINBOARD\AddMainboard.cshtml"
           Write(Html.ValidationMessageFor(model => model.Chipset, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\MAINBOARD\AddMainboard.cshtml"
       Write(Html.LabelFor(model => model.SocketStructure, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 38 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\MAINBOARD\AddMainboard.cshtml"
           Write(Html.EditorFor(model => model.SocketStructure, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 39 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\MAINBOARD\AddMainboard.cshtml"
           Write(Html.ValidationMessageFor(model => model.SocketStructure, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 43 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\MAINBOARD\AddMainboard.cshtml"
       Write(Html.LabelFor(model => model.RamType, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 45 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\MAINBOARD\AddMainboard.cshtml"
           Write(Html.EditorFor(model => model.RamType, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 46 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\MAINBOARD\AddMainboard.cshtml"
           Write(Html.ValidationMessageFor(model => model.RamType, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div> <div class=\"form-group\">\r\n            ");
#nullable restore
#line 49 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\MAINBOARD\AddMainboard.cshtml"
       Write(Html.LabelFor(model => model.M2_Slot, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 51 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\MAINBOARD\AddMainboard.cshtml"
           Write(Html.EditorFor(model => model.M2_Slot, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 52 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\MAINBOARD\AddMainboard.cshtml"
           Write(Html.ValidationMessageFor(model => model.M2_Slot, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 56 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\MAINBOARD\AddMainboard.cshtml"
       Write(Html.LabelFor(model => model.CasingStructure, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 58 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\MAINBOARD\AddMainboard.cshtml"
           Write(Html.EditorFor(model => model.CasingStructure, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 59 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\MAINBOARD\AddMainboard.cshtml"
           Write(Html.ValidationMessageFor(model => model.CasingStructure, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>
        </div>
        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Save"" class=""btn btn-default"" />
            </div>
        </div>
        <div>
            ");
#nullable restore
#line 68 "C:\Users\Ebb\Desktop\ComputerSelectionSENASONRADANYAPTI\ComputerSelection\Views\MAINBOARD\AddMainboard.cshtml"
       Write(Html.ActionLink("Back to List", "MAINBOARDList"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <br /><br />\r\n        <br /><br />\r\n        <br /><br />\r\n        <br /><br />\r\n        <br /><br />\r\n        <br /><br />\r\n        <br /><br />\r\n        <br /><br />\r\n        <br />\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ComputerSelection.Models.MAINBOARDViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591