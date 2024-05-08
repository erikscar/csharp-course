namespace RestParams
{
    internal class Calculator
    {
        //Uma Opção para Realizar uma Soma, porém ela deve ser de 2 números
        //Caso Seja Necessário Realizar uma Soma de 3 número deveremos criar outro método
        //NÃO RECOMENDADO
        public static int Sum(int n1, int n2)
        {
            return n1 + n2;
        }

        //Dessa forma estamos esperando um array de números que serão somados,
        //podemos adicionar quantos números quisermos porém ainda NÃO É MAIS RECOMENDADO
        public static int Sum1(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }

        //Utilizando a palavra reservado params, podemos fornecer quaiquer números para o método
        //de uma forma simples que irá ser realizado a soma de todos eles.
        public static int Sum2(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
