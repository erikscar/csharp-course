using xadrez_console.Tabuleiro;
using xadrez_console.Tabuleiro.Enum;
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
                //Chamando o método static da tela
                Tela.ImprimirTabuleiro(partidaXadrez.Tabuleiro);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
