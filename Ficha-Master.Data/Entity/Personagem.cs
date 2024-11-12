namespace Ficha_Master.Data.Entity
{
    public class Personagem
    {
        public Guid Id { get; set; }
        public Guid FichaId { get; set; }
        public string Nome { get; set; }

        public Ficha Ficha { get; set; }
    }
}
