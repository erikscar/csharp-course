using xadrez_console.Tabuleiro;

namespace xadrez_console
{
    internal class Tela
    {
        //Método Estático para poder chamar ele a qualquer momento
        //Ele Itera por todo o tabuleiro criado(Instanciado em Program.CS)
        //Se não tiver Peça ele imprimi -
        public static void ImprimirTabuleiro(Tab tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                Console.Write(8 - i + ") ");

                for(int j= 0; j < tabuleiro.Colunas; j++)
                {
                    if(tabuleiro.Peca(i, j) == null)
                        {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tabuleiro.Peca(i, j) + " ");
                    }
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("   A B C D E F G H");
        }
    }
}
