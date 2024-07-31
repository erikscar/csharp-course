using xadrez_console.Tabuleiro;
using xadrez_console.Tabuleiro.Enum;
using xadrez_console.Xadrez;

namespace xadrez_console
{
    internal class Tela
    {
        //Método Estático para poder chamar ele a qualquer momento
        //Ele Itera por todo o tabuleiro criado(Instanciado em PartidaXadrez)
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
                        ImprimirPeca(tabuleiro.Peca(i, j));
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine("   A B C D E F G H");
        }

        public static PosicaoXadrez LerPosicaoXadrez() //Método para ler uma determinada posição via teclado
        {
            string s = Console.ReadLine(); //LEndo a String do teclado
            char coluna = s[0]; //PEgando o char da string, se for c2, estaremos pegando o 'c'
            int linha = int.Parse(s[1] + ""); //Pegando o número da string, forçando a ser uma string o s[1]
            return new PosicaoXadrez(coluna, linha);
        }
        public static void ImprimirPeca(Peca peca)
        {
            if(peca.Cor == Cor.Branca)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
