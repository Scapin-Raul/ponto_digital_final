#pragma checksum "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91a2749a3f95c455944744ac1a4303bf5cd29bbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91a2749a3f95c455944744ac1a4303bf5cd29bbf", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 38, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n");
            EndContext();
            BeginContext(38, 665, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "564c3245d57b4a50a250792d5788b1df", async() => {
                BeginContext(44, 299, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>PONTO DIGITAL</title>
    <link rel=""stylesheet"" href=""css/style.css"">
    <link rel=""stylesheet"" href=""css/login.css"">
");
                EndContext();
#line 10 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Shared\_Layout.cshtml"
     if (ViewData["Css"].Equals("Home"))
    {

#line default
#line hidden
                BeginContext(392, 53, true);
                WriteLiteral("        <link rel=\"stylesheet\" href=\"css/home.css\">\r\n");
                EndContext();
#line 13 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Shared\_Layout.cshtml"
    }else if (ViewData["Css"].Equals("Comentarios"))
    {

#line default
#line hidden
                BeginContext(506, 60, true);
                WriteLiteral("        <link rel=\"stylesheet\" href=\"css/comentarios.css\">\r\n");
                EndContext();
#line 16 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Shared\_Layout.cshtml"
    }else if (ViewData["Css"].Equals("Cadastro"))
    {

#line default
#line hidden
                BeginContext(624, 57, true);
                WriteLiteral("        <link rel=\"stylesheet\" href=\"css/cadastro.css\">\r\n");
                EndContext();
#line 19 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Shared\_Layout.cshtml"
    }

#line default
#line hidden
                BeginContext(688, 8, true);
                WriteLiteral("\r\n    \r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(703, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(707, 3669, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7990861a95f241e6b309fcc1e8e87a02", async() => {
                BeginContext(713, 284, true);
                WriteLiteral(@"
    <header>
        <h1>Ponto Digital</h1>
        <div id=""div_menu"">
                <span class=""botao_menu""><img src=""img/icone-sandwich.png"" alt=""Icone Menu""></span>
            <nav id=""menu"" class=""menu"">
                <ul class=""ul_menu"">
                    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 997, "\'", 1032, 1);
#line 31 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1004, Url.Action("Index", "Home"), 1004, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1033, 43, true);
                WriteLiteral(">Home</a></li> \r\n                    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 1076, "\'", 1113, 1);
#line 32 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1083, Url.Action("Index", "Planos"), 1083, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1114, 45, true);
                WriteLiteral(" >Planos</a></li>\r\n                    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 1159, "\'", 1200, 1);
#line 33 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1166, Url.Action("Index", "Quem-somos"), 1166, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1201, 50, true);
                WriteLiteral(" >Quem somos?</a></li>\r\n                    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 1251, "\'", 1290, 1);
#line 34 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1258, Url.Action("Index", "Contatos"), 1258, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1291, 47, true);
                WriteLiteral(" >Contatos</a></li>\r\n                    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 1338, "\'", 1380, 1);
#line 35 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1345, Url.Action("Index", "Comentarios"), 1345, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1381, 50, true);
                WriteLiteral(">Comentários</a></li> \r\n                    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 1431, "\'", 1465, 1);
#line 36 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1438, Url.Action("Index", "Sac"), 1438, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1466, 42, true);
                WriteLiteral(" >SAC</a></li>\r\n                    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 1508, "\'", 1547, 1);
#line 37 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 1515, Url.Action("Index", "Cadastro"), 1515, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1548, 219, true);
                WriteLiteral(" >Cadastro</a></li>\r\n                    <p onclick=\"document.getElementById(\'id01\').style.display=\'block\'\" style=\"width:auto;\">Login</p>\r\n                </ul>\r\n            </nav>\r\n        </div>\r\n    </header>\r\n\r\n    ");
                EndContext();
                BeginContext(1768, 12, false);
#line 44 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1780, 520, true);
                WriteLiteral(@"


    
    <footer>
        <div id=""rodape"">
            <div id=""contatos"">
                <p>Telefone: 94002-8922</p>
                <p>E-mail: pontodigital@gmail.com </p>
                <div>
                    <a href=""#""><img src=""img/icone-facebook.png"" alt=""Icone Facebook""> </a>
                    <a href=""#""><img src=""img/icone-gmail.png"" alt=""Icone Gmail""> </a>
                </div>
            </div>
            <nav id=""menu_pe"">
                <ul>
                        <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 2300, "\'", 2335, 1);
#line 60 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2307, Url.Action("Index", "Home"), 2307, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2336, 43, true);
                WriteLiteral(">Home</a></li> \r\n                    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 2379, "\'", 2416, 1);
#line 61 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2386, Url.Action("Index", "Planos"), 2386, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2417, 45, true);
                WriteLiteral(" >Planos</a></li>\r\n                    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 2462, "\'", 2503, 1);
#line 62 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2469, Url.Action("Index", "Quem-somos"), 2469, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2504, 50, true);
                WriteLiteral(" >Quem somos?</a></li>\r\n                    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 2554, "\'", 2593, 1);
#line 63 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2561, Url.Action("Index", "Contatos"), 2561, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2594, 47, true);
                WriteLiteral(" >Contatos</a></li>\r\n                    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 2641, "\'", 2683, 1);
#line 64 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2648, Url.Action("Index", "Comentarios"), 2648, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2684, 50, true);
                WriteLiteral(">Comentários</a></li> \r\n                    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 2734, "\'", 2768, 1);
#line 65 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2741, Url.Action("Index", "Sac"), 2741, 27, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2769, 42, true);
                WriteLiteral(" >SAC</a></li>\r\n                    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 2811, "\'", 2850, 1);
#line 66 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Shared\_Layout.cshtml"
WriteAttributeValue("", 2818, Url.Action("Index", "Cadastro"), 2818, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2851, 1518, true);
                WriteLiteral(@" >Cadastro</a></li>
                </ul>
            </nav>
      </div>
    </footer>

    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
    <script>
        $(function() {
            var nav = $('.menu');
            var botao = $('.botao_menu');
            botao.on('click',function(){
                nav.toggleClass('active');
            });
        });
    </script>

<div id=""id01"" class=""modal"">
  
    <form class=""modal-content animate"" method=""POST"" action="""">
        <div class=""imgcontainer"">
            <span onclick=""document.getElementById('id01').style.display='none'"" class=""close"" title=""Close Modal"">&times;</span>
            <img src=""img/logo/favicon.png"" alt=""Logo"" class=""avatar"">
        </div>
    
        <div class=""container"">
            <label for=""uname""><b>Email de Usuário</b></label> <br>
            <input type=""text"" placeholder=""Insira seu email"" name=""uname"" required>
            <br> <br>
            <");
                WriteLiteral(@"label for=""psw""><b>Senha</b></label> <br>
            <input type=""password"" placeholder=""Insira sua senha"" name=""psw"" required>
                
            <button type=""submit"">Acessar</button>
        </div>
    </form>
</div>
      
      <script>
        var modal = document.getElementById('id01');
        window.onclick = function(event) {
            if (event.target == modal) {
                modal.style.display = ""none"";
            }
        }
      </script>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4376, 9, true);
            WriteLiteral("\r\n</html>");
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
