using Ficha_Master.Data.Enum;

namespace Ficha_Master.Data.Entity
{
    public class Itens 
    {
        public Guid Id {get; set;}
        public string Nome {get; set;}
        public TipoItens tipoItens {get; set;} 
        public int Valor {get; set;}
        public int Espaco {get; set;}
        public string Critico { get; set; }
        public string Alcance { get; set; }
        public string Tipo { get; set; }
        public string Dano { get; set; }
        public int Defesa {get; set;}
        public int Penalidade {get; set;}
        public string Descricao {get; set;}
        public int Quantidade { get; set; }
    }
}