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

        public void InserirPeca(Peca peca, Posicao posicao)
        {
            //Inserindo uma Peca, na matriz de Pecas
            Pecas[posicao.Linha, posicao.Coluna] = peca;
            peca.Posicao = posicao;
        }
    }
}
