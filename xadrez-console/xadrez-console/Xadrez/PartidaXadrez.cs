using xadrez_console.Tabuleiro;
using xadrez_console.Tabuleiro.Enum;
using xadrez_console.Tabuleiro.Exceptions;

namespace xadrez_console.Xadrez
{
    internal class PartidaXadrez
    {
        public Tab Tabuleiro { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
        public bool Terminada { get; private set; }
        private HashSet<Peca> Pecas; //Conjunto para guardar todas as peças da partida
        private HashSet<Peca> Capturadas; //Conjunto para guardar todas as peças da partida CAPTURADAS
        public bool Xeque { get; private set; }
        public PartidaXadrez()
        {
            Tabuleiro = new Tab(8, 8);
            Turno = 1;
            Terminada = false;
            Xeque = false;
            JogadorAtual = Cor.Branca;
            Pecas = new HashSet<Peca>();
            Capturadas = new HashSet<Peca>();
            InserirPecas(); 
        }

        public Peca ExecutaMovimento(Posicao origem, Posicao destino) //Método para mover uma peça, retirar ela onde ela esta e destinar ela para outro lugar
        {
            Peca peca = Tabuleiro.RetirarPeca(origem); //Retirando a peça da origem, com o método criado
            peca.IncrementarMovimentos();
            
            Peca pecaCapturada = Tabuleiro.RetirarPeca(destino); //Retirar a peça do destino SE HOUVER e armazenar, como se ela fosse comida

            Tabuleiro.InserirPeca(peca, destino); //Colocando a peça no destino

            if(pecaCapturada != null) //Se houver alguma peça capturada guardar no CONJUNTO
            {
                Capturadas.Add(pecaCapturada);
            }
            return pecaCapturada;
        }

        public void DesfazerMovimento(Posicao origem, Posicao destino, Peca pecaCapturada)
        {
            Peca peca = Tabuleiro.RetirarPeca(destino);
            peca.DecrementarMovimentos();
            if(pecaCapturada != null)
            {
                Tabuleiro.InserirPeca(pecaCapturada, destino);
                Capturadas.Remove(pecaCapturada);
            }
            Tabuleiro.InserirPeca(peca, origem);
        }

        public void RealizarJogada(Posicao origem, Posicao destino)
        {
            Peca pecaCapturada = ExecutaMovimento(origem, destino);

            if(EstaEmXeque(JogadorAtual))
            {
                DesfazerMovimento(origem, destino, pecaCapturada);
                throw new TabuleiroException("Você Não pode se Colocar em Xeque");
            }

            if(EstaEmXeque(Adversaria(JogadorAtual)))
            {
                Xeque = true;
            }
            else
            {
                Xeque = false;
            }
            Turno++;
            AlterarJogador();
        }

        public void ValidarPosicaoDeOrigem(Posicao posicao)
        {
            if (Tabuleiro.Peca(posicao) == null)
            {
                throw new TabuleiroException("Não Existe Peça na Posição Inserida");
            }

            if(JogadorAtual != Tabuleiro.Peca(posicao).Cor)
            {
                throw new TabuleiroException("A Peça de Origem Escolhida Não é Sua");
            }

            if(!Tabuleiro.Peca(posicao).PecaLivre())
            {
                throw new TabuleiroException("Não Há Movimentos Possíveis para essa Peça");
            }
        }

        public void ValidarPosicaoDeDestino(Posicao origem, Posicao destino)
        {
            //Se a peça de origem nao pode mover para o destino lançar uma exceção
            if(!Tabuleiro.Peca(origem).PossivelDescolamentoDestino(destino))
            {
                throw new TabuleiroException("Posição de Destino Inválida");
            }
        }

        private void AlterarJogador()
        {
            if(JogadorAtual == Cor.Branca)
            {
                JogadorAtual = Cor.Preta;
            }
            else
            {
                JogadorAtual = Cor.Branca;
            }
        }

        public HashSet<Peca> PecasCapturadas(Cor cor) //Descobrir quais peças são brancas e quais são pretas
        {
            HashSet<Peca> aux = new HashSet<Peca>();

            foreach(Peca p in Capturadas )
                {
                if(p.Cor == cor)
                    {
                    aux.Add(p);
                }
            }
            return aux;
        }

        public HashSet<Peca> PecasEmJogo(Cor cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();

            foreach (Peca p in Pecas)
            {
                if (p.Cor == cor)
                {
                    aux.Add(p);
                }
            }
            //Retirando todas as peças com exceção das capturadas, para descobrir as peças em jogo de uma cor
            aux.ExceptWith(PecasCapturadas(cor));
            return aux;

        }

        private Cor Adversaria(Cor cor)
        {
            if(cor == Cor.Branca)
            {
                return Cor.Preta;
            }
            else
            {
                return Cor.Branca;
            }
        }

        private Peca Rei(Cor cor) //Descobrir quem é o rei de uma cor especifica
        {
            foreach(Peca p in PecasEmJogo(cor))
            {
                if (p is Rei)
                {
                    return p;
                }
            }
            return null;
        }

        public bool EstaEmXeque(Cor cor)
        {
            Peca rei = Rei(cor);

            if(rei == null)
            {
                throw new TabuleiroException("Não Há Rei da Cor " + cor + " no Tabuleiro");
            }

            foreach(Peca p in PecasEmJogo(Adversaria(cor)))
            {
                bool[,] mat = p.MovimentosPossiveis();
                if (mat[rei.Posicao.Linha, rei.Posicao.Coluna])
                {
                    return true;
                }
            }
            return false;
        }
        public void InserirNovaPeca(char coluna, int linha, Peca peca)
        {
            Tabuleiro.InserirPeca(peca, new PosicaoXadrez(coluna, linha).toPosicao());
            Pecas.Add(peca); //Inserindo as peças no CONJUNTO e também irá instanciar todas as peças

        }
        private void InserirPecas()
        {
            InserirNovaPeca('c', 1, new Torre(Tabuleiro, Cor.Branca));
            InserirNovaPeca('c', 2, new Torre(Tabuleiro, Cor.Branca));
            InserirNovaPeca('d', 2, new Torre(Tabuleiro, Cor.Branca));
            InserirNovaPeca('e', 2, new Torre(Tabuleiro, Cor.Branca));
            InserirNovaPeca('e', 1, new Torre(Tabuleiro, Cor.Branca));
            InserirNovaPeca('d', 1, new Rei(Tabuleiro, Cor.Branca));

            InserirNovaPeca('c', 7, new Torre(Tabuleiro, Cor.Preta));
            InserirNovaPeca('c', 8, new Torre(Tabuleiro, Cor.Preta));
            InserirNovaPeca('d', 7, new Torre(Tabuleiro, Cor.Preta));
            InserirNovaPeca('e', 7, new Torre(Tabuleiro, Cor.Preta));
            InserirNovaPeca('e', 8, new Torre(Tabuleiro, Cor.Preta));
            InserirNovaPeca('d', 8, new Rei(Tabuleiro, Cor.Preta));
        }
    }
}
