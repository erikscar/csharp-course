using System;
using xadrez_console.Tabuleiro;

namespace xadrez_console.Xadrez
{
    //As Peças do Xadres são posicionados com LETRA+NUMERO, ao contrario dos arrays em programação
    //Para converter criamos uma classe
    internal class PosicaoXadrez
    {
        public char Coluna { get; set; } //Letra da coluna respectiva 
        public int Linha { get; set; } //Número da linha respectiva

        //Construtor Padrão
        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }


        public Posicao toPosicao() //Método para transformar a posição do xadrez em uma posição de array assim A8 = 0,0 em termos de posição do array
        {
            //A posição vai ser sempre 8 - a linha em questão, e a na parte da coluna, os char de letra possuem internamente um número assim irá se transformas no número necessário
            return new Posicao(8 - Linha, Coluna - 'a'); //o a é 1, o b é 2, assim b - a = 1, convertendo assim a coluna para uma posição do array
        }

        public override string ToString()
        {
            return "" + Coluna + Linha; //"" para forçar tudo a ser string
        }
    }
}
