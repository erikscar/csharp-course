using xadrez_console.Tabuleiro;
using xadrez_console.Tabuleiro.Enum;
using xadrez_console.Xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tab tabuleiro = new Tab(8, 8);


            tabuleiro.InserirPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(0, 0));
            tabuleiro.InserirPeca(new Torre(tabuleiro, Cor.Preta), new Posicao(1, 3));
            tabuleiro.InserirPeca(new Rei(tabuleiro, Cor.Preta), new Posicao(2, 4));

            //Chamando o método static da tela
            Tela.ImprimirTabuleiro(tabuleiro);
        }
    }
}
