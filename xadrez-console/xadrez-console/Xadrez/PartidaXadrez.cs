﻿using xadrez_console.Tabuleiro;
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

        public PartidaXadrez()
        {
            Tabuleiro = new Tab(8, 8);
            Turno = 1;
            Terminada = false;
            JogadorAtual = Cor.Branca;
            ColocarPecas(); 
        }

        public void ExecutaMovimento(Posicao origem, Posicao destino) //Método para mover uma peça, retirar ela onde ela esta e destinar ela para outro lugar
        {
            Peca peca = Tabuleiro.RetirarPeca(origem); //Retirando a peça da origem, com o método criado
            peca.IncrementarMovimentos();
            
            Peca pecaCapturada = Tabuleiro.RetirarPeca(destino); //Retirar a peça do destino SE HOUVER e armazenar, como se ela fosse comida

            Tabuleiro.InserirPeca(peca, destino); //Colocando a peça no destino

        }

        public void RealizarJogada(Posicao origem, Posicao destino)
        {
            ExecutaMovimento(origem, destino);
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

        private void ColocarPecas()
        {
            Tabuleiro.InserirPeca(new Torre(Tabuleiro, Cor.Branca), new PosicaoXadrez('c', 1).toPosicao());
            Tabuleiro.InserirPeca(new Torre(Tabuleiro, Cor.Branca), new PosicaoXadrez('c', 2).toPosicao());
            Tabuleiro.InserirPeca(new Torre(Tabuleiro, Cor.Branca), new PosicaoXadrez('d', 2).toPosicao());
            Tabuleiro.InserirPeca(new Torre(Tabuleiro, Cor.Branca), new PosicaoXadrez('e', 2).toPosicao());
            Tabuleiro.InserirPeca(new Torre(Tabuleiro, Cor.Branca), new PosicaoXadrez('e', 1).toPosicao());
            Tabuleiro.InserirPeca(new Rei(Tabuleiro, Cor.Branca), new PosicaoXadrez('d', 1).toPosicao());

            Tabuleiro.InserirPeca(new Torre(Tabuleiro, Cor.Preta), new PosicaoXadrez('c', 7).toPosicao());
            Tabuleiro.InserirPeca(new Torre(Tabuleiro, Cor.Preta), new PosicaoXadrez('c', 8).toPosicao());
            Tabuleiro.InserirPeca(new Torre(Tabuleiro, Cor.Preta), new PosicaoXadrez('d', 7).toPosicao());
            Tabuleiro.InserirPeca(new Torre(Tabuleiro, Cor.Preta), new PosicaoXadrez('e', 7).toPosicao());
            Tabuleiro.InserirPeca(new Torre(Tabuleiro, Cor.Preta), new PosicaoXadrez('e', 8).toPosicao());
            Tabuleiro.InserirPeca(new Rei(Tabuleiro, Cor.Preta), new PosicaoXadrez('d', 8).toPosicao());
        }
    }
}
