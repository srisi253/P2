#pragma checksum "C:\Users\maru-\source\repos\Obligatorio2\Obligatorio2\Views\Compra\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bceb4f75cbf7be007dbf2532ebe5fd340529d5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Compra_Index), @"mvc.1.0.view", @"/Views/Compra/Index.cshtml")]
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
#line 1 "C:\Users\maru-\source\repos\Obligatorio2\Obligatorio2\Views\_ViewImports.cshtml"
using Obligatorio2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maru-\source\repos\Obligatorio2\Obligatorio2\Views\_ViewImports.cshtml"
using Obligatorio2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maru-\source\repos\Obligatorio2\Obligatorio2\Views\Compra\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bceb4f75cbf7be007dbf2532ebe5fd340529d5a", @"/Views/Compra/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87e36970f455aae1bee373d97230b042ea67aa2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Compra_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Obligatorio2.Models.Compra>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("comprasPorFecha"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "C:\Users\maru-\source\repos\Obligatorio2\Obligatorio2\Views\Compra\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Lista de Compras del Sistema</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\maru-\source\repos\Obligatorio2\Obligatorio2\Views\Compra\Index.cshtml"
 if (Context.Session.GetString("logueadoRol") == "admin")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9bceb4f75cbf7be007dbf2532ebe5fd340529d5a4634", async() => {
                WriteLiteral(@"
        <label>Fecha Inicial</label>
        <input type=""date"" name=""fechaInicial"" id=""f1"" />

        <label>Fecha Final</label>
        <input type=""date"" name=""fechaFinal"" id=""f2"" />

        <input type=""submit"" value=""Ver Compras Entre Fechas"" />
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\maru-\source\repos\Obligatorio2\Obligatorio2\Views\Compra\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<p id=\"pMensaje\"></p>\r\n");
#nullable restore
#line 25 "C:\Users\maru-\source\repos\Obligatorio2\Obligatorio2\Views\Compra\Index.cshtml"
Write(ViewBag.Mensaje);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\maru-\source\repos\Obligatorio2\Obligatorio2\Views\Compra\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                Compra
            </th>
            <th>
                Actividad
            </th>
            <th>
                Usuario
            </th>
            <th>
                Cantidad de Entradas
            </th>
            <th>
                Fecha y Hora
            </th>
            <th>
                Costo
            </th>
            <th>
                Estado
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 59 "C:\Users\maru-\source\repos\Obligatorio2\Obligatorio2\Views\Compra\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 63 "C:\Users\maru-\source\repos\Obligatorio2\Obligatorio2\Views\Compra\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <th>\r\n                    ");
#nullable restore
#line 66 "C:\Users\maru-\source\repos\Obligatorio2\Obligatorio2\Views\Compra\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Actividad.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 69 "C:\Users\maru-\source\repos\Obligatorio2\Obligatorio2\Views\Compra\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Usuario.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <td>\r\n                    ");
#nullable restore
#line 72 "C:\Users\maru-\source\repos\Obligatorio2\Obligatorio2\Views\Compra\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CantidadEntradas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 75 "C:\Users\maru-\source\repos\Obligatorio2\Obligatorio2\Views\Compra\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FechayHora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 78 "C:\Users\maru-\source\repos\Obligatorio2\Obligatorio2\Views\Compra\Index.cshtml"
               Write(item.PrecioFinal());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 81 "C:\Users\maru-\source\repos\Obligatorio2\Obligatorio2\Views\Compra\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EstadoCompra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 84 "C:\Users\maru-\source\repos\Obligatorio2\Obligatorio2\Views\Compra\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>

        document.querySelector(""#comprasPorFecha"").addEventListener('submit', validarFormulario);
        document.querySelector(""#pMensaje"").innerHTML = """";


        function validarFormulario(evento) {
            evento.preventDefault();

            let f1 = document.querySelector(""#f1"").value

            let f2 = document.querySelector(""#f2"").value

            if (f1 != """" && f2 != """") {
                if (f1 <= f2) {
                    this.submit();
                } else {
                    document.querySelector(""#pMensaje"").innerHTML = ""La fecha final debe ser posterior a la inicial"";
                }
            }else {
                document.querySelector(""#pMensaje"").innerHTML = ""Seleccione fechas"";
            }

        }

    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Obligatorio2.Models.Compra>> Html { get; private set; }
    }
}
#pragma warning restore 1591
