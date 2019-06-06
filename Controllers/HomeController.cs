using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ponto_digital_final.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index(){
            ViewData["User"] = HttpContext.Session.GetString("USER_EMAIL");
            ViewData["Css"] = "Home";
            return View();
        }
        
    }
}