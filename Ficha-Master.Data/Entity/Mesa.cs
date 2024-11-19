namespace Ficha_Master.Data.Entity
{
    public class Mesa 
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public List<Usuario> Jogador { get; set; }
        public List<Usuario> Mestre { get; set; }
        public string Descricao { get; set; }
    }
}