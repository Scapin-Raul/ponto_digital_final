using Microsoft.AspNetCore.Mvc;

namespace ponto_digital_final.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index(){
            ViewData["Css"] = "Home";
            return View();
        }
        
    }
}