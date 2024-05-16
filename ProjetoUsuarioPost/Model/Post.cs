using System.ComponentModel.DataAnnotations;

namespace ProjetoUsuarioPost.Model
{   
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public Post(string titulo, int usuarioId)
        {
            Titulo = titulo;
            UsuarioId = usuarioId;
        }
    }
}
