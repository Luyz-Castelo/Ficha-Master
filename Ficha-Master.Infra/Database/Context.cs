using Ficha_Master.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Ficha_Master.Infra.Database
{
    public class Context(DbContextOptions<Context> options) : DbContext(options)
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Personagem> Personagem { get; set; }
        public DbSet<Ficha> Ficha { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>().HasMany(u => u.Fichas).WithOne(f => f.Usuario).HasForeignKey(f => f.UsuarioId).HasPrincipalKey(u => u.Id);
            modelBuilder.Entity<Personagem>().HasOne(p => p.Ficha).WithOne(f => f.Personagem);
        }
    }
}
