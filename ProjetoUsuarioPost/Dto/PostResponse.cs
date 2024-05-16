using ProjetoUsuarioPost.Model;

namespace ProjetoUsuarioPost.Dto
{
    public class PostResponse
    {
        public string Titulo { get; set; }
        public Usuario Usuario { get; set; }

        public PostResponse(Post post)
        {
            Titulo = post.Titulo;
            Usuario = post.Usuario;
        }
    }
}
