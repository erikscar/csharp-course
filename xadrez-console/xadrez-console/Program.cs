using xadrez_console.Tabuleiro;

namespace xadrez_console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tab tab = new Tab(8, 8);

            //Chamando o método static da tela
            Tela.ImprimirTabuleiro(tab);
        }
    }
}
