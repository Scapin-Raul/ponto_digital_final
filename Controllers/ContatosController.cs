using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ponto_digital_final.Controllers
{
    public class ContatosController: Controller
    {
        public IActionResult Index(){
            ViewData["UserN"] = HttpContext.Session.GetString("USER_NOME");
            ViewData["UserE"] = HttpContext.Session.GetString("USER_EMAIL");
            ViewData["Css"] = "Contatos";
            return View();
        }
    }
}