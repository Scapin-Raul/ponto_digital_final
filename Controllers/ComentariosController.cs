using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ponto_digital_final.Models;
using ponto_digital_final.Repositorios;
using ponto_digital_final.ViewModels;

namespace ponto_digital_final.Controllers
{
    public class ComentariosController: Controller
    {
        private ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
        public IActionResult Index(){
            ViewData["UserN"] = HttpContext.Session.GetString("USER_NOME");
            ViewData["UserA"] = HttpContext.Session.GetString("USER_ADMIN");
            ViewData["UserE"] = HttpContext.Session.GetString("USER_EMAIL");
            ViewData["Css"] = "Comentarios";
            ViewData["Title"] = "Comentarios";
            ComentariosViewModel comentarioViewModel = new ComentariosViewModel();

            return View(comentarioViewModel);
        }

        public IActionResult Comentar(IFormCollection form){
            var username = HttpContext.Session.GetString("USER_NOME");
            var useremail = HttpContext.Session.GetString("USER_EMAIL");
            var text = form["msg"];

            System.Console.WriteLine($"{username}\n{useremail}\n{text}\n\n\n");
            ComentarioModel comentario = new ComentarioModel(username,useremail,text);

            comentarioRepositorio.Inserir(comentario);

            return RedirectToAction("Index");
        }
        
    }
}   