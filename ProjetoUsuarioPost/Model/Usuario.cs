using System.ComponentModel.DataAnnotations;

namespace ProjetoUsuarioPost.Model
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }

        public Usuario(string nome)
        {
            Nome = nome;
        }
    }
}
