#pragma checksum "C:\Users\admin\Downloads\Misión TIC 2022\C3\DS-C3-23\Modulo 04\neuromante\neuromante-1984\UCS.App\UCS.App.Frontend\Pages\Listas\Detalles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "202ba6538385118a4472e72cc2d036fc578cfeda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(UCS.App.Frontend.Pages.Listas.Pages_Listas_Detalles), @"mvc.1.0.razor-page", @"/Pages/Listas/Detalles.cshtml")]
namespace UCS.App.Frontend.Pages.Listas
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
#line 1 "C:\Users\admin\Downloads\Misión TIC 2022\C3\DS-C3-23\Modulo 04\neuromante\neuromante-1984\UCS.App\UCS.App.Frontend\Pages\_ViewImports.cshtml"
using UCS.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"202ba6538385118a4472e72cc2d036fc578cfeda", @"/Pages/Listas/Detalles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80c648aa65a011f36a118bf2bcc9d747325a648a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Listas_Detalles : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Listas/Personas/", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\admin\Downloads\Misión TIC 2022\C3\DS-C3-23\Modulo 04\neuromante\neuromante-1984\UCS.App\UCS.App.Frontend\Pages\Listas\Detalles.cshtml"
  
    int? profesorId = @Model.Profesor?.id;
    int? estudianteId = @Model.Estudiante?.id;


    if(profesorId.HasValue){
        Console.WriteLine("Profesor: "+@Model.Profesor);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Detalles de profesor</h1>\r\n        <table class=\"table\">\r\n            \r\n                <tr><td>Id: ");
#nullable restore
#line 16 "C:\Users\admin\Downloads\Misión TIC 2022\C3\DS-C3-23\Modulo 04\neuromante\neuromante-1984\UCS.App\UCS.App.Frontend\Pages\Listas\Detalles.cshtml"
                       Write(Model.Profesor.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                <tr><td>Nombre: ");
#nullable restore
#line 17 "C:\Users\admin\Downloads\Misión TIC 2022\C3\DS-C3-23\Modulo 04\neuromante\neuromante-1984\UCS.App\UCS.App.Frontend\Pages\Listas\Detalles.cshtml"
                           Write(Model.Profesor.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td></tr>\r\n                <tr><td>Apellido: ");
#nullable restore
#line 18 "C:\Users\admin\Downloads\Misión TIC 2022\C3\DS-C3-23\Modulo 04\neuromante\neuromante-1984\UCS.App\UCS.App.Frontend\Pages\Listas\Detalles.cshtml"
                             Write(Model.Profesor.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                <tr><td>identificacion: ");
#nullable restore
#line 19 "C:\Users\admin\Downloads\Misión TIC 2022\C3\DS-C3-23\Modulo 04\neuromante\neuromante-1984\UCS.App\UCS.App.Frontend\Pages\Listas\Detalles.cshtml"
                                   Write(Model.Profesor.identificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                <tr><td>edad: ");
#nullable restore
#line 20 "C:\Users\admin\Downloads\Misión TIC 2022\C3\DS-C3-23\Modulo 04\neuromante\neuromante-1984\UCS.App\UCS.App.Frontend\Pages\Listas\Detalles.cshtml"
                         Write(Model.Profesor.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                <tr><td>estado covid: ");
#nullable restore
#line 21 "C:\Users\admin\Downloads\Misión TIC 2022\C3\DS-C3-23\Modulo 04\neuromante\neuromante-1984\UCS.App\UCS.App.Frontend\Pages\Listas\Detalles.cshtml"
                                 Write(Model.Profesor.EstadoCovid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                <tr><td>Departamento: ");
#nullable restore
#line 22 "C:\Users\admin\Downloads\Misión TIC 2022\C3\DS-C3-23\Modulo 04\neuromante\neuromante-1984\UCS.App\UCS.App.Frontend\Pages\Listas\Detalles.cshtml"
                                 Write(Model.Profesor.departamento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                <tr><td>Materia: ");
#nullable restore
#line 23 "C:\Users\admin\Downloads\Misión TIC 2022\C3\DS-C3-23\Modulo 04\neuromante\neuromante-1984\UCS.App\UCS.App.Frontend\Pages\Listas\Detalles.cshtml"
                            Write(Model.Profesor.materia);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td></tr>\r\n                <tr><td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "202ba6538385118a4472e72cc2d036fc578cfeda7255", async() => {
                WriteLiteral("\r\n                            Lista Personas\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td></tr>\r\n                    \r\n            \r\n            \r\n        </table>\r\n");
#nullable restore
#line 33 "C:\Users\admin\Downloads\Misión TIC 2022\C3\DS-C3-23\Modulo 04\neuromante\neuromante-1984\UCS.App\UCS.App.Frontend\Pages\Listas\Detalles.cshtml"
    }

    if(estudianteId.HasValue){
        Console.WriteLine("Estudiante: "+@Model.Estudiante);

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Detalles de Estudiante</h1>\r\n        <table class=\"table\">\r\n           \r\n                <tr><td>Id: ");
#nullable restore
#line 40 "C:\Users\admin\Downloads\Misión TIC 2022\C3\DS-C3-23\Modulo 04\neuromante\neuromante-1984\UCS.App\UCS.App.Frontend\Pages\Listas\Detalles.cshtml"
                       Write(Model.Estudiante.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                <tr><td>Nombre: ");
#nullable restore
#line 41 "C:\Users\admin\Downloads\Misión TIC 2022\C3\DS-C3-23\Modulo 04\neuromante\neuromante-1984\UCS.App\UCS.App.Frontend\Pages\Listas\Detalles.cshtml"
                           Write(Model.Estudiante.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td></tr>\r\n                <tr><td>Apellido: ");
#nullable restore
#line 42 "C:\Users\admin\Downloads\Misión TIC 2022\C3\DS-C3-23\Modulo 04\neuromante\neuromante-1984\UCS.App\UCS.App.Frontend\Pages\Listas\Detalles.cshtml"
                             Write(Model.Estudiante.apellido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                <tr><td>identificacion: ");
#nullable restore
#line 43 "C:\Users\admin\Downloads\Misión TIC 2022\C3\DS-C3-23\Modulo 04\neuromante\neuromante-1984\UCS.App\UCS.App.Frontend\Pages\Listas\Detalles.cshtml"
                                   Write(Model.Estudiante.identificacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                <tr><td>edad: ");
#nullable restore
#line 44 "C:\Users\admin\Downloads\Misión TIC 2022\C3\DS-C3-23\Modulo 04\neuromante\neuromante-1984\UCS.App\UCS.App.Frontend\Pages\Listas\Detalles.cshtml"
                         Write(Model.Estudiante.edad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                <tr><td>estado covid: ");
#nullable restore
#line 45 "C:\Users\admin\Downloads\Misión TIC 2022\C3\DS-C3-23\Modulo 04\neuromante\neuromante-1984\UCS.App\UCS.App.Frontend\Pages\Listas\Detalles.cshtml"
                                 Write(Model.Estudiante.EstadoCovid);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>\r\n                <tr><td>carrera: ");
#nullable restore
#line 46 "C:\Users\admin\Downloads\Misión TIC 2022\C3\DS-C3-23\Modulo 04\neuromante\neuromante-1984\UCS.App\UCS.App.Frontend\Pages\Listas\Detalles.cshtml"
                            Write(Model.Estudiante.carrera);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td></tr>\r\n                <tr><td>Semestre: ");
#nullable restore
#line 47 "C:\Users\admin\Downloads\Misión TIC 2022\C3\DS-C3-23\Modulo 04\neuromante\neuromante-1984\UCS.App\UCS.App.Frontend\Pages\Listas\Detalles.cshtml"
                             Write(Model.Estudiante.Semestre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td></tr>\r\n                <tr><td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "202ba6538385118a4472e72cc2d036fc578cfeda12102", async() => {
                WriteLiteral("\r\n                            Lista Personas\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td></tr> \r\n                    \r\n            \r\n            \r\n        </table>\r\n");
#nullable restore
#line 57 "C:\Users\admin\Downloads\Misión TIC 2022\C3\DS-C3-23\Modulo 04\neuromante\neuromante-1984\UCS.App\UCS.App.Frontend\Pages\Listas\Detalles.cshtml"
    }



#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UCS.App.Frontend.Pages.DetallesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UCS.App.Frontend.Pages.DetallesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<UCS.App.Frontend.Pages.DetallesModel>)PageContext?.ViewData;
        public UCS.App.Frontend.Pages.DetallesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591