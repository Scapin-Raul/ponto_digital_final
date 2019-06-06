using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ponto_digital_final.Models;
using ponto_digital_final.Repositorios;

namespace ponto_digital_final.Controllers
{
    public class CadastroController: Controller
    {
        private UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        public IActionResult Index(){
            ViewData["Css"] = "Cadastro";
            return View();
        }

        public IActionResult Cadastrar(IFormCollection form){
            // UsuarioModel usuario = new UsuarioModel(form["nome"],
            //                                         form["email"],
            //                                         form["senha"],
            //                                         DateTime.Parse(form["dataNascimento"])
            //                                     );
            UsuarioModel user = new UsuarioModel();
            user.Nome = form["nome"];
            user.Email = form["email"];
            user.Senha = form["senha"];
            user.DataNascimento = DateTime.Parse(form["dataNascimento"]);

            user = usuarioRepositorio.Inserir(user);
            System.Console.WriteLine($"\n{user.Nome}\n{user.Email}\n{user.Senha}\n{form["dataNascimento"]}\n{user.DataNascimento}");

            return RedirectToAction("Index");
        }
    }
}