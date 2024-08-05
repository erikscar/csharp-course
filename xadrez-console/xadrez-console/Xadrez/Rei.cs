using xadrez_console.Tabuleiro;
using xadrez_console.Tabuleiro.Enum;

namespace xadrez_console.Xadrez
{
    internal class Rei : Peca
    {

        private PartidaXadrez PartidaXadrez;
        public Rei(Tab tabuleiro, Cor cor, PartidaXadrez partidaXadrez) : base(tabuleiro, cor)
        {
            PartidaXadrez = partidaXadrez;
        }

        private bool PodeMover(Posicao posicao)
        {
            Peca peca = Tabuleiro.Peca(posicao);

            //O rei pode mover ou quando estiver livre, ou quando a peça for do adversário
            return peca == null || peca.Cor != Cor;
        }

        private bool TesteTorreParaRoque(Posicao posicao)
        {
            Peca peca = Tabuleiro.Peca(posicao);
            return peca != null && peca is Torre && peca.Cor == Cor && peca.Movimentos == 0;
        }

        public override bool[,] MovimentosPossiveis() //Sobrescrevendo o método da superclasse
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas]; //Instanciando uma Matriz com a mesma quantidade do que o tabuleiro

            Posicao posicao = new Posicao(0, 0);

            //Verificando se é possível mover acima
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);

            if(Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //Verificando se é possível mover ao Nordeste
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);

            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //Verificando se é possível mover a Direita
            posicao.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);

            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //Verificando se é possível mover a Sudeste
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);

            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //Verificando se é possível mover abaixo
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);

            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //Verificando se é possível mover Sudoeste
            posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);

            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //Verificando se é possível mover Esquerda
            posicao.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);

            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //Verificando se é possível mover Noroeste
            posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);

            if (Tabuleiro.PosicaoValida(posicao) && PodeMover(posicao))
            {
                mat[posicao.Linha, posicao.Coluna] = true;
            }

            //Jogada Especial Roque

            //Jogada Especial Roque Pequeno
            if (Movimentos == 0 && !PartidaXadrez.Xeque)
            {
                Posicao posicaoTorre1 = new Posicao(Posicao.Linha, Posicao.Coluna + 3);

                if (TesteTorreParaRoque(posicaoTorre1))
                {
                    Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna + 1);
                    Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna + 2);

                    if(Tabuleiro.Peca(p1) == null && Tabuleiro.Peca(p2) == null)
                    {
                        mat[Posicao.Linha, Posicao.Coluna + 2] = true;
                    }
                }

                //Jogada Especial Roque Grande

                Posicao posicaoTorre2 = new Posicao(Posicao.Linha, Posicao.Coluna - 4);

                if (TesteTorreParaRoque(posicaoTorre2))
                {
                    Posicao p1 = new Posicao(Posicao.Linha, Posicao.Coluna - 1);
                    Posicao p2 = new Posicao(Posicao.Linha, Posicao.Coluna - 2);
                    Posicao p3 = new Posicao(Posicao.Linha, Posicao.Coluna - 3);

                    if (Tabuleiro.Peca(p1) == null && Tabuleiro.Peca(p2) == null && Tabuleiro.Peca(p3) == null)
                    {
                        mat[Posicao.Linha, Posicao.Coluna - 2] = true;
                    }
                }
            }

            return mat;
        }


        public override string ToString()
        {
            return "R";
        }

    }
}
