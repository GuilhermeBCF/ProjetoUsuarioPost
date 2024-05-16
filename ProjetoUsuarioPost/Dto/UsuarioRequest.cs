using ProjetoUsuarioPost.Model;
using System.ComponentModel.DataAnnotations;

namespace ProjetoUsuarioPost.Dto
{
    public class UsuarioRequest
    {
        [MinLength(5)]
        public string Nome { get; set; }

        public Usuario toModel()
            => new Usuario(Nome);
    }
}
