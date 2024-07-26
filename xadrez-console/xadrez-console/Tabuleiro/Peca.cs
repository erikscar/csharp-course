using xadrez_console.Tabuleiro.Enum;

namespace xadrez_console.Tabuleiro
{
    internal class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public Tab Tabuleiro { get; protected set; }
        public int Movimentos { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tab tabuleiro)
        {
            Posicao = posicao;
            Cor = cor;
            Tabuleiro = tabuleiro;
            Movimentos = 0;
        }
    }
}
