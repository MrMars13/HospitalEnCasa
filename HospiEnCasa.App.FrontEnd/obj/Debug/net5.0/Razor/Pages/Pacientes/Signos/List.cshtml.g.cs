#pragma checksum "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.FrontEnd\Pages\Pacientes\Signos\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21b52f1232a6b0f42bd5332d7a7ad308853abba6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(HospiEnCasa.App.FrontEnd.Pages.Pacientes.Signos.Pages_Pacientes_Signos_List), @"mvc.1.0.razor-page", @"/Pages/Pacientes/Signos/List.cshtml")]
namespace HospiEnCasa.App.FrontEnd.Pages.Pacientes.Signos
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
#line 1 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.FrontEnd\Pages\_ViewImports.cshtml"
using HospiEnCasa.App.FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21b52f1232a6b0f42bd5332d7a7ad308853abba6", @"/Pages/Pacientes/Signos/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"838d893bfb9edbc2070b3bf50586b3a2a49e3e05", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Pacientes_Signos_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../DetailPaciente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.FrontEnd\Pages\Pacientes\Signos\List.cshtml"
  
    int pacienteId = Model.Paciente.Id;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1> Listado de Signos Vitales </h1>\r\n<table class=\"table\">\r\n    <tr>\r\n        <th scope=\"col\">Tipo de Signo</th>\r\n        <th scope=\"col\">Valor</th>\r\n        <th scope=\"col\">Fecha y Hora</th>\r\n    </tr>\r\n");
#nullable restore
#line 13 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.FrontEnd\Pages\Pacientes\Signos\List.cshtml"
     foreach (var signo in Model.SignosPaciente)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 16 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.FrontEnd\Pages\Pacientes\Signos\List.cshtml"
           Write(signo.Signo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.FrontEnd\Pages\Pacientes\Signos\List.cshtml"
           Write(signo.Valor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.FrontEnd\Pages\Pacientes\Signos\List.cshtml"
           Write(signo.FechaHora);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 20 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.FrontEnd\Pages\Pacientes\Signos\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21b52f1232a6b0f42bd5332d7a7ad308853abba65454", async() => {
                WriteLiteral(" Regresar ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Hospitalizacion\HospiEnCasa.App\HospiEnCasa.App.FrontEnd\Pages\Pacientes\Signos\List.cshtml"
                                                          WriteLiteral(pacienteId);

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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HospiEnCasa.App.FrontEnd.Pages.Pacientes.Signos.ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.App.FrontEnd.Pages.Pacientes.Signos.ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HospiEnCasa.App.FrontEnd.Pages.Pacientes.Signos.ListModel>)PageContext?.ViewData;
        public HospiEnCasa.App.FrontEnd.Pages.Pacientes.Signos.ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591