using System.Collections.Generic;
using ponto_digital_final.Models;
using ponto_digital_final.Repositorios;

namespace ponto_digital_final.ViewModels
{
    public class AdminViewModel
    {
        private UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        private ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
        public List<ComentarioModel> listaDeComentarios = new List<ComentarioModel>();
        public List<UsuarioModel> listaDeUsuarios = new List<UsuarioModel>();
        public List<ComentarioModel> listaDeReprovados = new List<ComentarioModel>();

        public int QuantidadeDeComentarios;
        public int QuantidadeDeAprovados;
        public int QuantidadeDeReprovados;
        public int QuantidadeDeUsuarios;
        
        public AdminViewModel(){
            listaDeComentarios = comentarioRepositorio.Listar(); 
            listaDeUsuarios = usuarioRepositorio.Listar();    
            QuantidadeDeComentarios = listaDeComentarios.Count;


            QuantidadeDeUsuarios = listaDeUsuarios.Count;
            List<ComentarioModel> listaDeAprovados = new List<ComentarioModel>();
            listaDeAprovados = comentarioRepositorio.ListarAprovados();
            QuantidadeDeAprovados = listaDeAprovados.Count;
            
            listaDeReprovados = comentarioRepositorio.ListarReprovados();
            QuantidadeDeReprovados = listaDeReprovados.Count;

            
        
        }


    }
}