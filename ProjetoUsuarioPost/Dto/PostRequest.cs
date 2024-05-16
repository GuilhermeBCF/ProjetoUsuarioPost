using ProjetoUsuarioPost.Model;
using System.ComponentModel.DataAnnotations;

namespace ProjetoUsuarioPost.Dto
{
    public class PostRequest
    {
        [MinLength(10)]
        public string Titulo { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        public Post toModel()
            => new Post(Titulo, UsuarioId);
    }
}
