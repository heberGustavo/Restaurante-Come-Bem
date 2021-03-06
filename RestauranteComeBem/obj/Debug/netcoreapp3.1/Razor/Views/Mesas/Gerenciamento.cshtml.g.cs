#pragma checksum "C:\Users\T-Gamer\source\repos\Restaurante-Come-Bem\RestauranteComeBem\Views\Mesas\Gerenciamento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efb7dd639b0083f91a8322d2cc497df123fc90b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mesas_Gerenciamento), @"mvc.1.0.view", @"/Views/Mesas/Gerenciamento.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"efb7dd639b0083f91a8322d2cc497df123fc90b6", @"/Views/Mesas/Gerenciamento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74f3ed1dad6c853c4db225f3e90f6c0e36060e79", @"/Views/_ViewImports.cshtml")]
    public class Views_Mesas_Gerenciamento : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline ml-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\T-Gamer\source\repos\Restaurante-Come-Bem\RestauranteComeBem\Views\Mesas\Gerenciamento.cshtml"
  
    ViewData["Title"] = "Gerenciamento de Mesas";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card-custom"">
    <div class=""row"">
        <div class=""col-md-4 card-custom-header"">
            <span class=""material-icons"">category</span>
            <h3 class=""d-inline"">Gerenciamento de Mesas</h3>
        </div>
        <div class=""col-md-9"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efb7dd639b0083f91a8322d2cc497df123fc90b64209", async() => {
                WriteLiteral(@"
                <div class=""form-group no-border"">
                    <input type=""text"" class=""form-control input-busca"" placeholder=""Buscar"">
                </div>
                <button type=""submit"" class=""btn btn-dark btn-just-icon btn-round"">
                    <i class=""material-icons"">search</i>
                </button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <div class=""col-md-3"">
            <button class=""btn btn-primary"" data-toggle=""modal"" data-target=""#modalCadastrarMesa"">Cadastrar Nova Categoria</button>
        </div>
    </div>
    <table class=""table table-hover"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">N??mero da Mesa</th>
                <th scope=""col"">A????es</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <th scope=""row"">1</th>
                <td>Mesas 1</td>
                <td>
                    <button class=""btn btn-info btn-sm""><span class=""material-icons"">create</span></button>
                    <button class=""btn btn-danger btn-sm""><span class=""material-icons"">delete_forever</span></button>
                </td>
            </tr>
            <tr>
                <th scope=""row"">2</th>
                <td>Mesas 58</td>
                <td>
                    <button class=""btn btn-info b");
            WriteLiteral(@"tn-sm""><span class=""material-icons"">create</span></button>
                    <button class=""btn btn-danger btn-sm""><span class=""material-icons"">delete_forever</span></button>
                </td>
            </tr>
            <tr>
                <th scope=""row"">3</th>
                <td>Mesas 89</td>
                <td>
                    <button class=""btn btn-info btn-sm""><span class=""material-icons"">create</span></button>
                    <button class=""btn btn-danger btn-sm""><span class=""material-icons"">delete_forever</span></button>
                </td>
            </tr>
        </tbody>
    </table>
</div>

<!-- Modal Cadastrar Categoria -->
<div class=""modal fade"" id=""modalCadastrarMesa"" tabindex=""-1"" role=""dialog"" aria-labelledby=""modalCadastrarMesaTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleMod");
            WriteLiteral(@"alLongTitle"">Cadastro de Mesas</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""row mb-2"">
                    <div class=""col-md-4"">
                        <button class=""btn btn-danger btn-sm"">+ 10 mesas</button>
                    </div>
                    <div class=""col-md-4"">
                        <button class=""btn btn-danger btn-sm"">+ 30 mesas</button>
                    </div>
                    <div class=""col-md-4"">
                        <button class=""btn btn-danger btn-sm"">+ 50 mesas</button>
                    </div>
                </div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efb7dd639b0083f91a8322d2cc497df123fc90b68916", async() => {
                WriteLiteral(@"
                    <small>Ou cadastre manualmente</small>
                    <div class=""form-group"">
                        <label for=""inputAddress"">N??mero da Mesa</label>
                        <input type=""text"" class=""form-control"" id=""inputAddress"" placeholder=""Ex: 100"">
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"modal-footer\">\r\n                <button type=\"button\" class=\"btn btn-primary\">Salvar</button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
