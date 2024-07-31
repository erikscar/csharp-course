using xadrez_console.Tabuleiro;
using xadrez_console.Tabuleiro.Enum;
using xadrez_console.Xadrez;

namespace xadrez_console
{
    internal class Tela
    {
        public static void ImprimirPartida(PartidaXadrez partidaXadrez)
        {
            ImprimirTabuleiro(partidaXadrez.Tabuleiro);
            Console.WriteLine();
            ImprimirPecasCapturadas(partidaXadrez);
            Console.WriteLine();
            Console.WriteLine("Turno: " + partidaXadrez.Turno);
            Console.WriteLine("Aguardando Jogada da Peça: " + partidaXadrez.JogadorAtual);
        }

        public static void ImprimirPecasCapturadas(PartidaXadrez partidaXadrez)
        {
            Console.WriteLine("Peças Capturadas: ");

            Console.Write("Brancas: ");
            ImprimirConjunto(partidaXadrez.PecasCapturadas(Cor.Branca));
            Console.WriteLine();

            Console.Write("Pretas: ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            ImprimirConjunto(partidaXadrez.PecasCapturadas(Cor.Preta));
            Console.ForegroundColor = aux;
            Console.WriteLine();
        }

        public static void ImprimirConjunto(HashSet<Peca> conjunto)
        {
            Console.Write("[");
            foreach(Peca p in conjunto)
            {
                Console.Write(p + "");
            }
            Console.Write("]");
        }
        //Método Estático para poder chamar ele a qualquer momento
        //Ele Itera por todo o tabuleiro criado(Instanciado em PartidaXadrez)
        //Se não tiver Peça ele imprimi -
        public static void ImprimirTabuleiro(Tab tabuleiro)
        {
            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                Console.Write(8 - i + ") ");

                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    ImprimirPeca(tabuleiro.Peca(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("   A B C D E F G H");
        }

        public static void ImprimirTabuleiro(Tab tabuleiro, bool[,] posicoesPossiveis)
        {
            ConsoleColor fundoPadrao = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tabuleiro.Linhas; i++)
            {
                Console.Write(8 - i + ") ");

                for (int j = 0; j < tabuleiro.Colunas; j++)
                {
                    if (posicoesPossiveis[i, j] == true) //Se for verdadeiro a posição do for, irá mudar o fundo
                    {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else
                    {
                        Console.BackgroundColor = fundoPadrao;
                    }
                    ImprimirPeca(tabuleiro.Peca(i, j));
                    Console.BackgroundColor = fundoPadrao;
                }
                Console.WriteLine();
            }
            Console.WriteLine("   A B C D E F G H");
            Console.BackgroundColor = fundoPadrao;
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
            if (peca == null)
            {
                Console.Write("- ");
            }
            else
            {
                if (peca.Cor == Cor.Branca)
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
                Console.Write(" ");
            }

        }
    }
}
