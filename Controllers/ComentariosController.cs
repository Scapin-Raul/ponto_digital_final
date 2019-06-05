using Microsoft.AspNetCore.Mvc;

namespace ponto_digital_final.Controllers
{
    public class ComentariosController: Controller
    {
        public IActionResult Index(){
            ViewData["Css"] = "Comentarios";
            return View();
        }
        
    }
}   