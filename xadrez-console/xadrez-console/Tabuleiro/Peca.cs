using xadrez_console.Tabuleiro.Enum;

namespace xadrez_console.Tabuleiro
{
    abstract class Peca //Como a classe possui um método abstrato ela vira abstrata também
    {   
        //Classe Genérica!
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public Tab Tabuleiro { get; protected set; }
        public int Movimentos { get; protected set; }

        public Peca(Tab tabuleiro, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            Tabuleiro = tabuleiro;
            Movimentos = 0;
        }

        public abstract bool[,] MovimentosPossiveis()
            //Método que retorna uma matriz booleana para indicar onde são movimentos possiveis 
            //Método abstrato porque a Classe é muito genérica!
            //Vai ser implementado nas subclasses
            
        {

        }
        public void IncrementarMovimentos()
        {
            Movimentos++;
        }
    }
}
