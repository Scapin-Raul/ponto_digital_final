using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ponto_digital_final.Models;
using ponto_digital_final.Repositorios;
using ponto_digital_final.ViewModels;

namespace ponto_digital_final.Controllers
{
    public class AdminController: Controller
    {
        public IActionResult Index(){
            ViewData["UserN"] = HttpContext.Session.GetString("USER_NOME");
            ViewData["UserE"] = HttpContext.Session.GetString("USER_EMAIL");
            ViewData["UserA"] = HttpContext.Session.GetString("USER_ADMIN");
            
            if (ViewData["UserA"] != null)
            {
                if (bool.Parse((string)ViewData["UserA"]))
                {
                    AdminViewModel adminViewModel = new AdminViewModel();
                    
                    return View(adminViewModel);
                }
            }

            return RedirectToAction("Index","Home");      
        }

        public IActionResult Aprovacao(){
            AdminViewModel adminViewModel = new AdminViewModel();
            
            return View(adminViewModel);
        }

        public IActionResult Aprovar(int id){
            System.Console.WriteLine(id);
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
            ComentarioModel comentario = comentarioRepositorio.BuscarPorId(id);
            System.Console.WriteLine($"ACHOUKKKJ\n\n\n\n {comentario.Texto}");
            comentario.Aprovado = true;

            comentarioRepositorio.Editar(comentario);

            return RedirectToAction("Index");
        }
    }
}