#pragma checksum "C:\Users\maru-\source\repos\Obligatorio2\Obligatorio2\Views\Usuario\Registro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eefb490a8c894687d1db357ed458b9408380cf9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Registro), @"mvc.1.0.view", @"/Views/Usuario/Registro.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eefb490a8c894687d1db357ed458b9408380cf9d", @"/Views/Usuario/Registro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87e36970f455aae1bee373d97230b042ea67aa2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Registro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formularioAlta"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<h1>Registro usuario</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eefb490a8c894687d1db357ed458b9408380cf9d3924", async() => {
                WriteLiteral(@"
    <label>Nombre</label>
    <input type=""text"" name=""nombre"" id=""nombre"" />
    <i>Debe contener al menos dos caracteres</i>
    <br />

    <label>Apellido</label>
    <input type=""text"" name=""apellido"" id=""apellido"" />
    <i>Debe contener al menos dos caracteres</i>
    <br />

    <label>Fecha de Nacimiento:</label>
    <input type=""date"" name=""fechaNacimiento"" id=""fechaNacimiento"" /><br />

    <label>Email</label>
    <input type=""text"" name=""email"" id=""email"" /><br />

    <label>Nombre de Usuario</label>
    <input type=""text"" name=""nombreUsuario"" id=""nombreUsuario"" /><br />

    <label>Password</label>
    <input type=""password"" name=""password"" id=""password"" />
    <i>Debe contener al menos una mayúscula, una minúscula, un dígito y más de 5 caracteres</i>
    <br />

    <input type=""submit"" value=""Registrar"" />
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 32 "C:\Users\maru-\source\repos\Obligatorio2\Obligatorio2\Views\Usuario\Registro.cshtml"
Write(ViewBag.Resultado);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<p id=\"pMensaje\"></p>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>

        document.querySelector(""#formularioAlta"").addEventListener('submit', validarFormulario);
        document.querySelector(""#pMensaje"").innerHTML = """";


        function validarFormulario(evento) {
            evento.preventDefault();

            let nombre = document.querySelector(""#nombre"").value

            let apellido = document.querySelector(""#apellido"").value

            let email = document.querySelector(""#email"").value

            let password = document.querySelector(""#password"").value

            let nombreUsuario = document.querySelector(""#nombreUsuario"").value

            let fechaNac = document.querySelector(""#fechaNacimiento"").value


            if (nombre != """" && apellido != """" && email != """" && password != """" && nombreUsuario != """" && fechaNac != """"
                && nombre.length > 1 && apellido.length > 1 && password.length > 5) {
                    console.log(""primer if"");
                        let mayusc = 0;
                   ");
                WriteLiteral(@"     let minusc = 0;
                        let digito = 0;
                        for (var i = 0; i < password.length; i++) {
                            
                            if (password.charCodeAt(i) >= 48 && password.charCodeAt(i) <= 57) {
                                console.log(""entro en digito"");
                                digito++;
                                document.querySelector(""#pMensaje"").innerHTML += ""funciona digitos"";
                            } else if (password.charAt(i) == password.charAt(i).toUpperCase()) {
                                mayusc++;
                                console.log(""entro en mayus"");
                                document.querySelector(""#pMensaje"").innerHTML += ""funciona mayusculas"";

                            } else if (password.charAt(i) == password.charAt(i).toLowerCase()) {
                                minusc++;
                                console.log(""entro en minus"");
                                docume");
                WriteLiteral(@"nt.querySelector(""#pMensaje"").innerHTML += ""funciona minusculas"";

                            }
                        }
              
                if (mayusc > 0 && minusc > 0 && digito > 0) {
                    this.submit();
                } else {
                    document.querySelector(""#pMensaje"").innerHTML += ""Error en password"";
                }
             
                
            } else {
                document.querySelector(""#pMensaje"").innerHTML = ""Error en los datos"";
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591