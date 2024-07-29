using xadrez_console.Tabuleiro.Enum;

namespace xadrez_console.Tabuleiro
{
    internal class Peca
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
    }
}
