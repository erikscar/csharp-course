using xadrez_console.Tabuleiro;
using xadrez_console.Tabuleiro.Enum;

namespace xadrez_console.Xadrez
{
    internal class Rei : Peca
    {
        public Rei(Tab tabuleiro, Cor cor) : base(tabuleiro, cor)
        {

        }

        private bool PodeMover(Posicao posicao)
        {
            Peca peca = Tabuleiro.Peca(posicao);

            //O rei pode mover ou quando estiver livre, ou quando a peça for do adversário
            return peca == null || peca.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveis() //Sobrescrevendo o método da superclasse
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas]; //Instanciando uma Matriz com a mesma quantidade do que o tabuleiro

            Posicao posicao = new Posicao(0, 0);

            //Verificando se é possível mover acima
            posicao.DefinirValores(posicao.Linha - 1, posicao.Coluna);

            if(Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //Verificando se é possível mover ao Nordeste
            posicao.DefinirValores(posicao.Linha - 1, posicao.Coluna + 1);

            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //Verificando se é possível mover a Direita
            posicao.DefinirValores(posicao.Linha, posicao.Coluna + 1);

            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //Verificando se é possível mover a Sudeste
            posicao.DefinirValores(posicao.Linha + 1, posicao.Coluna + 1);

            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //Verificando se é possível mover abaixo
            posicao.DefinirValores(posicao.Linha + 1, posicao.Coluna);

            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //Verificando se é possível mover Sudoeste
            posicao.DefinirValores(posicao.Linha + 1, posicao.Coluna - 1);

            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //Verificando se é possível mover Esquerda
            posicao.DefinirValores(posicao.Linha, posicao.Coluna - 1);

            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //Verificando se é possível mover Noroeste
            posicao.DefinirValores(posicao.Linha - 1, posicao.Coluna - 1);

            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            return mat;
        }
        public override string ToString()
        {
            return "R";
        }

    }
}
