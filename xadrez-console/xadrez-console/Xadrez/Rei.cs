using xadrez_console.Tabuleiro;
using xadrez_console.Tabuleiro.Enum;

namespace xadrez_console.Xadrez
{
    internal class Rei : Peca
    {
        public Rei(Tab tabuleiro, Cor cor) : base(tabuleiro, cor)
        {

        }
        public override string ToString()
        {
            return "R";
        }
    }
}
