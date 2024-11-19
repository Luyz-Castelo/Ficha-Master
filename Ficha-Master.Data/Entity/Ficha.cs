namespace Ficha_Master.Data.Entity
{
    public class Ficha
    {
        public Guid Id { get; set; }
        public Guid UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
        public Personagem Personagem { get; set; }

        /*Informações Principais*/
        public int Nivel_do_Personagem { get; set;}
        public string Nome_do_Personagem { get; set; }
        public string Raca { get; set; }
        public string Origem { get; set; }
        public string Classe { get; set; }
        public string Divindade { get; set; }
        /*Atributos*/
        public int Forca { get; set; }
        public int Destreza { get; set; }
        public int Inteligencia { get; set; }
        public int Constituicao { get; set; }
        public int Sabedoria { get; set; }
        public int Carisma { get; set; }
        /*Vida e Mana*/
        public int Pontos_de_Vida_Atual { get; set; }
        public int Pontos_de_Vida_Total { get; set; }
        public int Pontos_de_Mana_Atual { get; set; }
        public int Pontos_de_Mana_Total { get; set; }
        public int Pontos_de_Experiencia { get; set; }
        public string Tamanho { get; set; }
        public string Atributo_Chave { get; set; } 
        /*
            Tributo Chave para Lançar Magias --> Precisa Adicionar o Modificador do Atributo e o Valor do Teste de Resistência na tela da ficha
        */
        public string Proficiencias { get; set; }
        /*
            --> As porficiências devem ser separados por , (Virgua)
            --> Na hora de morstas as informações devemos utilizar o metodo .Split para separa as informações e mostralas separadamente na interface.
        */

        /*Perícias*/
        /* 
            Devem ser calculados na hora que os dados forem passados para a Interface
            Calculo: Bonus de Proficiência + Bonus do Atributo + Treinamente + Outros 
        */
        public bool Acrobacia { get; set; }
        public bool Adestramento { get; set; }
        public bool Atletismo { get; set; }
        public bool Atuacao { get; set; }
        public bool Cavalgar { get; set; }
        public bool Conhecimento { get; set; }
        public bool Cura { get; set; }
        public bool Diplomacia { get; set; }
        public bool Enganacao { get; set; }
        public bool Fortitude { get; set; }
        public bool Furtividade { get; set; }
        public bool Guerra { get; set; }
        public bool Iniciativa { get; set; }
        public bool Intimidacao { get; set; }
        public bool Intuicao { get; set; }
        public bool Investigacao { get; set; }
        public bool Jogatina { get; set; }
        public bool Ladinagem { get; set; }
        public bool Luta { get; set; }
        public bool Misticismo { get; set; }
        public bool Nobreza { get; set; }
        public bool Oficio_Opcao1 { get; set; }
        public string Oficio_Escolhido1 { get; set; }
        public bool Oficio_Opcao2 { get; set; }
        public string Oficio_Escolhido2 { get; set; }
        public bool Percepcao { get; set; }
        public bool Pilotagem { get; set; }
        public bool Pontaria { get; set; }
        public bool Reflexos { get; set; }
        public bool Religiao { get; set; }
        public bool Sobrevivencia { get; set; }
        public bool Vontade { get; set; }

        /*Habilidades e outras Informações*/
        public string Ataques_disponiveis { get; set; }
        public string Armadura_Equipada_Nome { get; set; }
        public int Armadura_Equipada_Valor { get; set; }
        public string Escudo_Equipado_Nome { get; set; }
        public int Escudo_Equipado_Valor { get; set; }

        public List<Itens> Mochila {get; set;} 
        public List<Magias> Magias {get; set;}
        public List<Habilidade> Habilidades {get; set;}
        public List<Habilidade> Poderes {get; set;}
        



    }
}
