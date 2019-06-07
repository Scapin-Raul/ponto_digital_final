using System.Collections.Generic;
using ponto_digital_final.Models;
using ponto_digital_final.Repositorios;

namespace ponto_digital_final.ViewModels
{
    public class ComentariosViewModel
    {
        public List<ComentarioModel> listaDeComentarios = new List<ComentarioModel>();
        private ComentarioRepositorio comentarioRepositorio = new ComentarioRepositorio();
        public ComentariosViewModel(){
            listaDeComentarios = comentarioRepositorio.ListarAprovados();
        }
    }
}