using Ficha_Master.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Ficha_Master.Infra.Database
{
    public class Context(DbContextOptions<Context> options) : DbContext(options)
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Personagem> Personagem { get; set; }
        public DbSet<Ficha> Ficha { get; set; }
        public DbSet<Habilidade> Habilidade {get; set;}
        public DbSet<Magias> Magias { get; set; }
        public DbSet<Itens> Itens { get; set; }
        public DbSet<Mesa> Mesa { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>().HasMany(u => u.Fichas).WithOne(f => f.Usuario).HasForeignKey(f => f.UsuarioId).HasPrincipalKey(u => u.Id);
            modelBuilder.Entity<Personagem>().HasOne(p => p.Ficha).WithOne(f => f.Personagem);
            /* Não sei se está correto fiz com ajuda do ChatGPT */
            modelBuilder.Entity<Ficha>().HasMany(f => f.MochilaItens).WithOne().HasForeignKey("FichaId");
            modelBuilder.Entity<Ficha>().HasMany(f => f.Magias).WithOne().HasForeignKey("FichaId");
            modelBuilder.Entity<Ficha>().HasMany(f => f.HabilidadesPoderes).WithOne().HasForeignKey("FichaId");
            modelBuilder.Entity<Mesa>().HasMany(m => m.Jogador).WithOne().HasForeignKey("MesaId");
            modelBuilder.Entity<Mesa>().HasMany(m => m.Jogador).WithOne().HasForeignKey("MesaId");
        }
    }
}
