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
            ViewData["Css"] = "Admin";
            
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

        public IActionResult Comentarios(){
            ViewData["UserN"] = HttpContext.Session.GetString("USER_NOME");
            ViewData["UserE"] = HttpContext.Session.GetString("USER_EMAIL");
            ViewData["UserA"] = HttpContext.Session.GetString("USER_ADMIN");
            ViewData["Css"] = "Comentarios";
            
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
        public IActionResult Usuarios(){
            ViewData["UserN"] = HttpContext.Session.GetString("USER_NOME");
            ViewData["UserE"] = HttpContext.Session.GetString("USER_EMAIL");
            ViewData["UserA"] = HttpContext.Session.GetString("USER_ADMIN");
            ViewData["Css"] = "Usuarios";
            
            
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

        

        public IActionResult Aprovar(int id){
            ViewData["UserA"] = HttpContext.Session.GetString("USER_ADMIN");
            
            if (ViewData["UserA"] == null)
            {
                return RedirectToAction("Index","Home");
            }


            System.Console.WriteLine(id);
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
            ComentarioModel comentario = comentarioRepositorio.BuscarPorId(id);
                
            if (comentario.Aprovado){
                comentario.Aprovado = false;
            }else{
                comentario.Aprovado = true;
            }

            comentarioRepositorio.Editar(comentario);

            return RedirectToAction("Comentarios");
        }
        public IActionResult Deletar(int id){
            System.Console.WriteLine(id);
            ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
            ComentarioModel comentario = comentarioRepositorio.BuscarPorId(id);

            comentarioRepositorio.Deletar(comentario);

            return RedirectToAction("Comentarios");
        }

        public IActionResult DeletarUser(int id){
            UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
            UsuarioModel usuario = usuarioRepositorio.BuscarPorId(id);

            usuarioRepositorio.Deletar(usuario);

            return RedirectToAction("Usuarios");
        }

    }
}