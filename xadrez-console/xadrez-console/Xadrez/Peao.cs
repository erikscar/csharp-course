using xadrez_console.Tabuleiro.Enum;
using xadrez_console.Tabuleiro;

namespace xadrez_console.Xadrez
{
    internal class Peao : Peca
    {
        public Peao(Tab tabuleiro, Cor cor) : base(tabuleiro, cor) { }

        private bool PodeMover(Posicao posicao)
        {
            Peca peca = Tabuleiro.Peca(posicao);

            //O Peao pode mover ou quando estiver livre, ou quando a peça for do adversário
            return peca == null || peca.Cor != Cor;
        }

        private bool ExisteInimigo(Posicao posicao)
        {
            Peca peca = Tabuleiro.Peca(posicao);
            return peca != null && peca.Cor != Cor;
        }

        private bool Livre(Posicao posicao)
            {
            return Tabuleiro.Peca(posicao)== null;
        }

        public override bool[,] MovimentosPossiveis() //Sobrescrevendo o método da superclasse
        {
            bool[,] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas]; //Instanciando uma Matriz com a mesma quantidade do que o tabuleiro

            Posicao posicao = new Posicao(0, 0);

            if (Cor == Cor.Branca)
            {
                posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
                if(Tabuleiro.PosicaoValida(posicao) && Livre(posicao))
                {
                    mat[Posicao.Linha, Posicao.Coluna] = true;
                }

                posicao.DefinirValores(Posicao.Linha - 2, Posicao.Coluna);
                if (Tabuleiro.PosicaoValida(posicao) && Livre(posicao) && Movimentos == 0)
                {
                    mat[Posicao.Linha, Posicao.Coluna] = true;
                }

                posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
                if (Tabuleiro.PosicaoValida(posicao) && ExisteInimigo(posicao))
                {
                    mat[Posicao.Linha, Posicao.Coluna] = true;
                }

                posicao.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
                if (Tabuleiro.PosicaoValida(posicao) && ExisteInimigo(posicao))
                {
                    mat[Posicao.Linha, Posicao.Coluna] = true;
                }
            }
            else
            {
                posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
                if (Tabuleiro.PosicaoValida(posicao) && Livre(posicao))
                {
                    mat[Posicao.Linha, Posicao.Coluna] = true;
                }

                posicao.DefinirValores(Posicao.Linha + 2, Posicao.Coluna);
                if (Tabuleiro.PosicaoValida(posicao) && Livre(posicao) && Movimentos == 0)
                {
                    mat[Posicao.Linha, Posicao.Coluna] = true;
                }

                posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
                if (Tabuleiro.PosicaoValida(posicao) && ExisteInimigo(posicao))
                {
                    mat[Posicao.Linha, Posicao.Coluna] = true;
                }

                posicao.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
                if (Tabuleiro.PosicaoValida(posicao) && ExisteInimigo(posicao))
                {
                    mat[Posicao.Linha, Posicao.Coluna] = true;
                }
            }

            return mat;
        }

        public override string ToString()
        {
            return "P";
        }
    }
}
