#pragma checksum "C:\Users\T-Gamer\source\repos\Restaurante-Come-Bem\RestauranteComeBem\Views\Mesas\EmAtendimento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92c2c7082d3e28b8b8d4fbc5a8b06f8266526c66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mesas_EmAtendimento), @"mvc.1.0.view", @"/Views/Mesas/EmAtendimento.cshtml")]
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
#line 1 "C:\Users\T-Gamer\source\repos\Restaurante-Come-Bem\RestauranteComeBem\Views\_ViewImports.cshtml"
using RestauranteComeBem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\T-Gamer\source\repos\Restaurante-Come-Bem\RestauranteComeBem\Views\_ViewImports.cshtml"
using RestauranteComeBem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92c2c7082d3e28b8b8d4fbc5a8b06f8266526c66", @"/Views/Mesas/EmAtendimento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74f3ed1dad6c853c4db225f3e90f6c0e36060e79", @"/Views/_ViewImports.cshtml")]
    public class Views_Mesas_EmAtendimento : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comanda", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\T-Gamer\source\repos\Restaurante-Come-Bem\RestauranteComeBem\Views\Mesas\EmAtendimento.cshtml"
  
    ViewData["Title"] = "Mesas em Atendimento";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h3>Em Atendimento</h3>\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-2 box-mesa\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92c2c7082d3e28b8b8d4fbc5a8b06f8266526c664140", async() => {
                WriteLiteral("\r\n                <span class=\"material-icons text-warning icone-mesa\">local_dining</span>\r\n                <p>Mesa 5</p>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""col-md-2 box-mesa"">
            <a>
                <span class=""material-icons text-warning icone-mesa"">local_dining</span>
                <p>Mesa 9</p>
            </a>
        </div>
        <div class=""col-md-2 box-mesa"">
            <a>
                <span class=""material-icons text-warning icone-mesa"">local_dining</span>
                <p>Mesa 13</p>
            </a>
        </div>
        <div class=""col-md-2 box-mesa"">
            <a>
                <span class=""material-icons text-warning icone-mesa"">local_dining</span>
                <p>Mesa 14</p>
            </a>
        </div>
        <div class=""col-md-2 box-mesa"">
            <a>
                <span class=""material-icons text-warning icone-mesa"">local_dining</span>
                <p>Mesa 19</p>
            </a>
        </div>
        <div class=""col-md-2 box-mesa"">
            <a>
                <span class=""material-icons text-warning icone-mesa"">local_dining</span>
   ");
            WriteLiteral(@"             <p>Mesa 35</p>
            </a>
        </div>
        <div class=""col-md-2 box-mesa"">
            <a>
                <span class=""material-icons text-warning icone-mesa"">local_dining</span>
                <p>Mesa 40</p>
            </a>
        </div>
        <div class=""col-md-2 box-mesa"">
            <a>
                <span class=""material-icons text-warning icone-mesa"">local_dining</span>
                <p>Mesa 41</p>
            </a>
        </div>
        <div class=""col-md-2 box-mesa"">
            <a>
                <span class=""material-icons text-warning icone-mesa"">local_dining</span>
                <p>Mesa 45</p>
            </a>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
