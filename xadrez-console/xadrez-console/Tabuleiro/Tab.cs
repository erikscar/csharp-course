using xadrez_console.Tabuleiro.Exceptions;

namespace xadrez_console.Tabuleiro
{
    internal class Tab
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        //Propriedade Privada para que não possamos alterar em outra classe, então para acessar a propriedade temos que ter um método
        private Peca[,] Pecas;

        public Tab(int linhas, int colunas)
        {
            Linhas = linhas;
            Colunas = colunas;
            Pecas = new Peca[Linhas, Colunas];
        }

        public Peca Peca(int linha, int coluna)
        {
            //Retornando uma Peça porque a Propriedade esta privada!
            return Pecas[linha, coluna];
        }

        //Mesmo método de cima porém agora recebendo uma instancia de posição
        public Peca Peca(Posicao posicao)
        {
            return Pecas[posicao.Linha, posicao.Coluna];
        }

        //Verificando se a peça existe, mas antes verificando se é uma posição válida
        public bool ExistePeca(Posicao posicao)
        {
            ValidarPosicao(posicao);
            return Peca(posicao) != null;
        }

        public void InserirPeca(Peca peca, Posicao posicao)
        {
            if(ExistePeca(posicao))
            {
                throw new TabuleiroException("Já Existe uma Peça Nessa Posição!");
            }

            //Inserindo uma Peca, na matriz de Pecas
            Pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.Posicao = posicao;
        }

        public bool PosicaoValida(Posicao posicao)
        {
            //Testando se uma posição é válida dentro do array bidimensional
            if(posicao.Linha < 0 || posicao.Linha >= Linhas || posicao.Coluna < 0 || posicao.Coluna >= Colunas  )
            {
                return false;
            }
            return true;
        }

        //Método para lançar uma exceção
        public void ValidarPosicao(Posicao posicao)
        {
            if(!PosicaoValida(posicao))
            {
                throw new TabuleiroException("Posição Inválida!");
            }
        }
    }
}
