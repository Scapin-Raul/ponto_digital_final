#pragma checksum "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a0fa3193596afc2fd699b17653260c23a5324e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a0fa3193596afc2fd699b17653260c23a5324e6", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Home\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(36, 1311, true);
            WriteLiteral(@"    
    <section id=""banner"">
        <img src=""img/logo/logo.png"" alt=""Logo Ponto Digital!"">
        <h2>O mais reconhecido do mercado! <br><span> Ponto Digital, </span><br> para gestão de funcionários!</h2>
    </section>

    <section id=""qualidades"">
        <h3>Qualidades e diferenciais do Ponto Digital</h3>
        <div id=""tudo"">
            <div class=""indiv"">
                <img src=""img/home/icone-velocidade.png"" alt=""Icone velocimetro"">
                <p>Temos o compromisso em relação ao tempo de entrega, sendo entregue em no <span>máximo 24 horas! </span> </p>
            </div>

            <div class=""indiv"">
                <img src=""img/home/icone-acesso-mundial.png"" alt=""Icone de acesso remoto"">
                <p>Gerencie seus funcionários de <span> qualquer lugar do  mundo</span>, necessitando  apenas de um dispositivo com internet!</p>
            </div>

            <div class=""indiv"">
                <img src=""img/home/icone-segurança.png"" alt=""Icone de segurança"">");
            WriteLiteral(@"
                <p><span> Com servidores 100% protegidos</span> sua gestão estará sempre segura conosco.</p>
            </div>
        </div>
    </section>

    <section id=""planos"">
        <h3>Ache o plano para você!</h3>
        <div>
            <div>
                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1347, "\'", 1390, 2);
#line 34 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Home\Index.cshtml"
WriteAttributeValue("", 1354, Url.Action("Index", "Planos"), 1354, 30, false);

#line default
#line hidden
            WriteAttributeValue("", 1384, "#plano", 1384, 6, true);
            EndWriteAttribute();
            BeginContext(1391, 86, true);
            WriteLiteral(" >Experimente Grátis!</a>\r\n            </div>\r\n\r\n            <div>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 1477, "\'", 1520, 2);
#line 38 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Home\Index.cshtml"
WriteAttributeValue("", 1484, Url.Action("Index", "Planos"), 1484, 30, false);

#line default
#line hidden
            WriteAttributeValue("", 1514, "#plano", 1514, 6, true);
            EndWriteAttribute();
            BeginContext(1521, 793, true);
            WriteLiteral(@" >Confira os planos <br> e escolha o seu!</a> 
            </div>       
        </div>
    </section>

    <section id=""depoimentos"">
        <div>
            <h3>Depoimentos de usuários do Ponto Digital:</h3>
            <div>
                <div>
                    <p> <span>Senai</span>: <br> ""Um software muito bom para controle de funcionários, o melhor do ramo!""</p>
                </div>

                <div>
                    <p> <span>Intel</span>:<br> ""Um atendimento excepcional, nada à reclamar.""</p>
                </div>

                <div>
                    <p> <span>Carrefour</span>:<br> ""Nada a complementar, software completo e fácil de usar.""</p>
                </div>
            </div>
        </div>    
        <a id=""comentarios""");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 2314, "\'", 2356, 1);
#line 60 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Home\Index.cshtml"
WriteAttributeValue("", 2321, Url.Action("Index", "Comentarios"), 2321, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2357, 93, true);
            WriteLiteral(">Faça você um depoimento sobre sua experiência com o Ponto Digital!</a>\r\n    </section>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
