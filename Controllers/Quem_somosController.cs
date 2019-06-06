using Microsoft.AspNetCore.Mvc;

namespace ponto_digital_final.Controllers
{
    public class Quem_somosController: Controller
    {
        public IActionResult Index(){
            ViewData["Css"] = "QuemSomos";
            return View();
        }
    }
}