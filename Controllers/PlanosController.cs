using Microsoft.AspNetCore.Mvc;

namespace ponto_digital_final.Controllers
{
    public class PlanosController: Controller
    {
        public IActionResult Index(){
            ViewData["Css"] = "Planos";
            return View();
        }
    }
}