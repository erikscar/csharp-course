using xadrez_console.Tabuleiro;
using xadrez_console.Tabuleiro.Enum;

namespace xadrez_console.Xadrez
{
    internal class Bispo : Peca
    {
        public Bispo(Tab tabuleiro, Cor cor) : base(tabuleiro, cor) { }

        private bool PodeMover(Posicao posicao)
        {
            Peca peca = Tabuleiro.Peca(posicao);

            //O Bispo pode mover ou quando estiver livre, ou quando a peça for do adversário
            return peca == null || peca.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis() //Sobrescrevendo o método da superclasse
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas]; //Instanciando uma Matriz com a mesma quantidade do que o tabuleiro

            Posicao posicao = new Posicao(0, 0);

            //Noroeste
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao)) //Enquanto tiver uma posicao valida ou livre ou adversária
            {
                mat[posicao.Linha, posicao.Coluna] = true; //Pode mover
                if (Tabuleiro.Peca(posicao) != null && Tabuleiro.Peca(posicao).Cor != Cor)
                //Se a posição for diferente de null, ou seja há uma peça naquele lugar E a peça for de cor diferente parar a execução
                {
                    break;
                }
                posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            }

            //Nordeste
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao)) //Enquanto tiver uma posicao valida ou livre ou adversária
            {
                mat[posicao.Linha, posicao.Coluna] = true; //Pode mover
                if (Tabuleiro.Peca(posicao) != null && Tabuleiro.Peca(posicao).Cor != Cor)
                //Se a posição for diferente de null, ou seja há uma peça naquele lugar E a peça for de cor diferente parar a execução
                {
                    break;
                }
                posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            }

            //Sudeste
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao)) //Enquanto tiver uma posicao valida ou livre ou adversária
            {
                mat[posicao.Linha, posicao.Coluna] = true; //Pode mover
                if (Tabuleiro.Peca(posicao) != null && Tabuleiro.Peca(posicao).Cor != Cor)
                //Se a posição for diferente de null, ou seja há uma peça naquele lugar E a peça for de cor diferente parar a execução
                {
                    break;
                }
                posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            }

            //Sudoeste
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            while (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao)) //Enquanto tiver uma posicao valida ou livre ou adversária
            {
                mat[posicao.Linha, posicao.Coluna] = true; //Pode mover
                if (Tabuleiro.Peca(posicao) != null && Tabuleiro.Peca(posicao).Cor != Cor)
                //Se a posição for diferente de null, ou seja há uma peça naquele lugar E a peça for de cor diferente parar a execução
                {
                    break;
                }
                posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            }

            return mat;
        }

        public override string ToString()
        {
            return "B";
        }
    }
}
