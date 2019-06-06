#pragma checksum "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Planos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81d81f6bfa6d0509c4f138d2e8cd068f3da523c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Planos_Index), @"mvc.1.0.view", @"/Views/Planos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Planos/Index.cshtml", typeof(AspNetCore.Views_Planos_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81d81f6bfa6d0509c4f138d2e8cd068f3da523c8", @"/Views/Planos/Index.cshtml")]
    public class Views_Planos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\46791749865\Desktop\ponto_digital_final\Views\Planos\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(29, 8750, true);
            WriteLiteral(@"
    <section id=""banner"">
        <img src=""img/logo/logo.png"" alt=""Logo Ponto Digital!"">
        <h2>Planos!</h2>
    </section>

    <section id=""plano"">
        <h3>Escolha o plano para a sua empresa!</h3>
        <div id=""busca"">
            <div class=""plano_indiv"">
                <h4>Ponto Trial</h4>
                <div>
                    <img src=""img/logo/favicon.png"" alt="""">
                    <p>1 Funcionário</p>
                </div>
                <p><span> Grátis</span> por 1 mês.</p>
            </div>

            <div class=""plano_indiv"">
                <h4>Ponto Simple</h4>
                <div>
                    <img src=""img/logo/favicon.png"" alt="""">
                    <p>5 Funcionários</p>
                </div>
                <p><span> R$29,90 </span>por 1 mês.</p>
            </div>
          
            <div class=""plano_indiv"">
                <h4>Ponto Medium</h4>
                <div>
                    <img src=""img/logo/favicon.png"" alt="""">
                    <p>50 ");
            WriteLiteral(@"Funcionários</p>
                </div>
                <p><span> R$149,90 </span>por 1 mês.</p>
            </div>

            <div class=""plano_indiv"">
                <h4>Ponto Premium</h4>
                <div>
                    <img src=""img/logo/favicon.png"" alt="""">
                    <p>300 Funcionários</p>
                </div>
                <p><span> R$299,90 </span>por 1 mês.</p>
            </div>

            <div class=""plano_indiv"">
                <h4>Ponto Custom</h4>
                <div>
                    <img src=""img/logo/favicon.png"" alt="""">
                </div>
                <p>Entrar em contato para negociação.</p>
            </div>
        </div>    
        <button class=""trigger"">Clique para conferir os detalhes!</button>
    </section>

    <div id=""id01"" class=""modal"">
  
        <form class=""modal-content animate"" action=""/action_page.php"">
          <div class=""imgcontainer"">
            <span onclick=""document.getElementById('id01').style.display='none'"" class=""clo");
            WriteLiteral(@"se"" title=""Close Modal"">&times;</span>
            <img src=""img/logo/favicon.png"" alt=""Logo"" class=""avatar"">
          </div>
      
          <div class=""container"">
            <label for=""uname""><b>Nome de Usuário</b></label> <br>
            <input type=""text"" placeholder=""Coloque seu nome de usuário"" name=""uname"" required>
      <br>
            <label for=""psw""><b>Senha</b></label> <br>
            <input type=""password"" placeholder=""Coloque sua senha"" name=""psw"" required>
              
            <button type=""submit"">Acessar</button>
          </div>
      
          <div class=""container"" style=""background-color:#f1f1f1"">
            <button type=""button"" onclick=""document.getElementById('id01').style.display='none'"" class=""cancelbtn"">Cancelar</button>
          </div>
        </form>
      </div>
      
      <script>
      // Get the modal
      var modal = document.getElementById('id01');
      
      // When the user clicks anywhere outside of the modal, close it
      window.onclick = functio");
            WriteLiteral(@"n(event) {
          if (event.target == modal) {
              modal.style.display = ""none"";
          }
      }
    </script>
      <div class=""modal1"">
        <div class=""modal1-content"">
            <span class=""close-button"">&times;</span>
            <h3>Planos da Ponto Digital</h1>

            <div id=""flex"">

                <div class=""c_plano"">
                        <h4>Ponto Trial</h4>
                            <img src=""img/logo/favicon.png"" alt=""Logo"">
                            <p><span>Gestione 1 funcionário.</span></p> <br>
                            <ul>
                                    <li>Software otimizado, completo e de fácil uso;</li>
                                    <li>Localização do funcionário;</li>
                                    <li>Tempo de trabalho.</li>
                                </ul>
                            <p><span>Grátis por 1 mês!</span></p>
                </div>

                <div class=""c_plano"">
                        <h4>Ponto Simple</h4>");
            WriteLiteral(@"
                            <img src=""img/logo/favicon.png"" alt="""">
                            <p><span> Gestione até 5 funcionários. </span></p> <br>
                            <ul>
                                <li>Software otimizado, completo e de fácil uso;</li>
                                <li>Tenha acesso ao seu historico;</li>
                                <li>Localização do funcionário;</li>
                                <li>Tempo de trabalho;</li>
                                <li>Controle de banco de horas e horas extras;</li>
                                <li>Controle de atrasos e faltas;</li>
                                <li>Cancele quando quiser.</li>
                            </ul>
                            <p><span>Por apenas R$29,90 por mês!</span></p>
                </div>

                <div class=""c_plano"">
                        <h4>Ponto Medium</h4>
                            <img src=""img/logo/favicon.png"" alt="""">
                            <p><span>Gestione ");
            WriteLiteral(@"até 50 funcionários. </span> </p> <br>
                            <ul>
                                <li>Software otimizado, completo e de fácil uso;</li>
                                <li>Tenha acesso ao seu historico;</li>
                                <li>Localização do funcionário;</li>
                                <li>Tempo de trabalho;</li>
                                <li>Controle de banco de horas e horas extras;</li>
                                <li>Controle de atrasos e faltas;</li>
                                <li>Cancele quando quiser;</li>
                                <li>Associação com Folha de Pagamento.</li>
                            </ul>
                            <p><span>Por apenas R$149,90 por mês!</span></p>
                </div>

                <div class=""c_plano"">
                        <h4>Ponto Premium</h4>
                            <img src=""img/logo/favicon.png"" alt="""">
                            <p><span>Gestione até 300 funcionários. </span> </p> <");
            WriteLiteral(@"br>
                            <ul>
                                <li>Software otimizado, completo e de fácil uso;</li>
                                <li>Tenha acesso ao seu historico;</li>
                                <li>Localização do funcionário;</li>
                                <li>Tempo de trabalho;</li>
                                <li>Controle de banco de horas e horas extras;</li>
                                <li>Controle de atrasos e faltas;</li>
                                <li>Cancele quando quiser;</li>
                                <li>Associação com Folha de Pagamento.</li>
                            </ul>
                            <p><span>Por apenas R$299,90 por mês!</span></p>
                </div>  

                <div class=""c_plano"">
                        <h4>Ponto Custom</h4>
                            <img src=""img/logo/favicon.png"" alt="""">
                            <p><span>Gestione mais de 300 funcionários. </span> </p> <br>
                          ");
            WriteLiteral(@"  <ul>
                                <li>Software otimizado, completo e de fácil uso;</li>
                                <li>Tenha acesso ao seu historico;</li>
                                <li>Localização do funcionário;</li>
                                <li>Tempo de trabalho;</li>
                                <li>Controle de banco de horas e horas extras;</li>
                                <li>Controle de atrasos e faltas;</li>
                                <li>Cancele quando quiser;</li>
                                <li>Integração com Folha de Pagamento.</li>
                            </ul>
                            <p>Caso sua empresa tenha mais que 300 funcionários,contate-nos para que possamos negociar o preço.</p>
                </div>
                

           </div>
           <p><span> Pagamentos podem ser feitos por:</span></p>
                <p>Boleto Bancário, Paypal e Depósito. <br>
                Basta entrar em contato conosco.</p>
        </div>
    </div>

    
");
            WriteLiteral(@"      <script>
    var modal1 = document.querySelector("".modal1"");
    var trigger = document.querySelector("".trigger"");
    var closeButton = document.querySelector("".close-button"");

    function toggleModal() {
        modal1.classList.toggle(""show-modal1"");
    }

    function windowOnClick(event) {
        if (event.target === modal1) {
            toggleModal();
        }
    }

    trigger.addEventListener(""click"", toggleModal);
    closeButton.addEventListener(""click"", toggleModal);
    window.addEventListener(""click"", windowOnClick);
</script>");
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