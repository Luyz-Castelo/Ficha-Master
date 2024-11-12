namespace Ficha_Master.Data.Entity
{
    public class Ficha
    {
        public Guid Id { get; set; }
        public Guid UsuarioId { get; set; }

        public Usuario Usuario { get; set; }
        public Personagem Personagem { get; set; }
    }
}
