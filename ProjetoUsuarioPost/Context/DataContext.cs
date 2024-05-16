using Microsoft.EntityFrameworkCore;
using ProjetoUsuarioPost.Model;

namespace ProjetoUsuarioPost.Context
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=PostDB;ConnectRetryCount=0");
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Post> Post {  get; set; }
    }
}
