using xadrez_console.Tabuleiro;
using xadrez_console.Tabuleiro.Exceptions;
using xadrez_console.Xadrez;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaXadrez partidaXadrez = new PartidaXadrez();

                while (!partidaXadrez.Terminada)
                {
                    try
                    {
                        Console.Clear();
                        //Chamando o método static da tela
                        Tela.ImprimirPartida(partidaXadrez);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.LerPosicaoXadrez().toPosicao();
                        partidaXadrez.ValidarPosicaoDeOrigem(origem);
                        //Quando digitar a origem o tabuleiro irá mostrar os movimentos possíveis, limpando o console
                        //e mostrando ele de novo com as possibilidades

                        bool[,] posicoesPossiveis = partidaXadrez.Tabuleiro.Peca(origem).MovimentosPossiveis();

                        Console.Clear();
                        Tela.ImprimirTabuleiro(partidaXadrez.Tabuleiro, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.LerPosicaoXadrez().toPosicao();
                        partidaXadrez.ValidarPosicaoDeDestino(origem, destino);

                        partidaXadrez.RealizarJogada(origem, destino);
                    }
                    catch(TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                Console.Clear();
                Tela.ImprimirPartida(partidaXadrez);

            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
