using xadrez_console.Tabuleiro.Enum;

namespace xadrez_console.Tabuleiro
{
    abstract class Peca //Como a classe possui um método abstrato ela vira abstrata também
    {   
        //Classe Genérica!
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public Tab Tabuleiro { get; protected set; }
        public int Movimentos { get; protected set; }

        public Peca(Tab tabuleiro, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            Tabuleiro = tabuleiro;
            Movimentos = 0;
        }

        public abstract bool[,] MovimentosPossiveis();
            //Método que retorna uma matriz booleana para indicar onde são movimentos possiveis 
            //Método abstrato porque a Classe é muito genérica!
            //Vai ser implementado nas subclasses
            
        public bool PecaLivre()
        {
            bool[,] mat = MovimentosPossiveis(); //Percorrer a matriz inteira 
            // e se tiver um TRUE marcado na matriz de movimento possível retornar true

            for(int i = 0; i < Tabuleiro.Linhas; i++)
            {
                for(int j = 0; j < Tabuleiro.Colunas; j++)
                {
                    if (mat[i, j] == true)
                    {
                        return true;
                    }
                    
                }
            }
            return false;
        }
        public bool PossivelDescolamentoDestino(Posicao posicao)
        {
            return MovimentosPossiveis()[posicao.Linha, posicao.Coluna];
        }

        public void IncrementarMovimentos()
        {
            Movimentos++;
        }
    }
}
