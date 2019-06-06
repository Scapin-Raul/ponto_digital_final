using System;
using System.Collections.Generic;
using System.IO;
using ponto_digital_final.Models;

namespace ponto_digital_final.Repositorios
{
    public class UsuarioRepositorio
    {
        private const string PATH = "Database/Usuario.csv";
        private List<UsuarioModel> listaDeUsuarios = new List<UsuarioModel>();
        public UsuarioModel Inserir(UsuarioModel usuario){
            if (!File.Exists(PATH)){
                usuario.ID = 1;
                File.Create(PATH).Close();
            }else{
                usuario.ID= File.ReadAllLines(PATH).Length + 1;
            }
            
            StreamWriter sw = new StreamWriter(PATH, true);
            sw.WriteLine($"{usuario.ID};{usuario.Nome};{usuario.Email};{usuario.Senha};{usuario.DataNascimento.ToShortDateString()};{usuario.Admin}");
            sw.Close();

            return usuario;
        }

        public List<UsuarioModel> Listar(){
            List<UsuarioModel> listaDeUsuarios = new List<UsuarioModel>();

            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas){
                if (item != null){
                    string[] dados = item.Split(";");

                    var usuario = new UsuarioModel();
                    usuario.ID = int.Parse(dados[0]);
                    usuario.Nome = dados[1];
                    usuario.Email = dados[2];
                    usuario.Senha = dados[3];
                    usuario.DataNascimento = DateTime.Parse(dados[4]);
                    usuario.Admin = bool.Parse(dados[5]);

                    listaDeUsuarios.Add(usuario);
                }
            }



            return listaDeUsuarios;
        }
    }
}