#pragma checksum "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Admin\Aprovacao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "001402d271442b33400d2f6d69fd2af2c5ec30ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Aprovacao), @"mvc.1.0.view", @"/Views/Admin/Aprovacao.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Aprovacao.cshtml", typeof(AspNetCore.Views_Admin_Aprovacao))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"001402d271442b33400d2f6d69fd2af2c5ec30ee", @"/Views/Admin/Aprovacao.cshtml")]
    public class Views_Admin_Aprovacao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ponto_digital_final.ViewModels.AdminViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Admin\Aprovacao.cshtml"
  
    Layout = "_AdminLayout";

#line default
#line hidden
            BeginContext(92, 97, true);
            WriteLiteral("\r\n\r\n<section id=\"content\">\r\n    <h3>Página de Administração - Aprovação de Comentários</h3>\r\n\r\n\r\n");
            EndContext();
#line 11 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Admin\Aprovacao.cshtml"
     foreach (var item in @Model.listaDeReprovados)
    {

#line default
#line hidden
            BeginContext(249, 103, true);
            WriteLiteral("        <div class=\"comentario\">\r\n            <div class=\"topo\">\r\n                <p class=\"nomeEmail\">");
            EndContext();
            BeginContext(353, 9, false);
#line 15 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Admin\Aprovacao.cshtml"
                                Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(362, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(366, 10, false);
#line 15 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Admin\Aprovacao.cshtml"
                                             Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(376, 47, true);
            WriteLiteral("</p>\r\n                <div>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 423, "\"", 456, 2);
            WriteAttributeValue("", 430, "/Admin/Aprovar?id=", 430, 18, true);
#line 17 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Admin\Aprovacao.cshtml"
WriteAttributeValue("", 448, item.ID, 448, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(457, 89, true);
            WriteLiteral(">Aprovar</a> <a >Deletar</a>\r\n                </div>\r\n            </div>\r\n            <p>");
            EndContext();
            BeginContext(547, 10, false);
#line 20 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Admin\Aprovacao.cshtml"
          Write(item.Texto);

#line default
#line hidden
            EndContext();
            BeginContext(557, 34, true);
            WriteLiteral("</p>\r\n            <p class=\"data\">");
            EndContext();
            BeginContext(592, 29, false);
#line 21 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Admin\Aprovacao.cshtml"
                       Write(item.Data.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(621, 24, true);
            WriteLiteral("</p>\r\n        </div>  \r\n");
            EndContext();
#line 23 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Admin\Aprovacao.cshtml"

    }

#line default
#line hidden
            BeginContext(654, 12, true);
            WriteLiteral("\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ponto_digital_final.ViewModels.AdminViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591