using Ficha_Master.Data.Enum;

namespace Ficha_Master.Data.Entity
{
    public class Habilidade
    {
        public Guid Id { get; set; }
        public string Nome { get; set;}
        public TipoHabilidades TipoHabilidade {get; set;} /* Define se a habilidade é de Classe / Raça / Origem / Poderes - Combate - Destino - Magia - Concedidos - Tormenta  */
        public string Descricao { get; set;}
    }
}