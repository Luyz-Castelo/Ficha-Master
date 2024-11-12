using Ficha_Master.Data.Enum;

namespace Ficha_Master.Data.Entity
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public TipoUsuario TipoUsuario { get; set; }

        public ICollection<Ficha> Fichas { get; set; } = new List<Ficha>();
    }
}
