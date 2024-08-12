namespace Generics1.Entities
{
    internal class PrintService
    {
        //REÚSO, se precisamos de um vetor de Strings não poderemos utilizar essa propriedade
        //Iremos ter que criar outra classe contendo as mesmas coisas porém com strings

        //TYPE SAFETY
        //Se por acaso utilizarmos um vetor de object, poderemos misturar os tipos
        //e se houver uma conversão como de string para int irá ocorrer ERROS EM TEMPO DE EXECUÇÃO
        //O compilador não irá acusar no código pq é um tipo genérico o object
        public int[] Numbers = new int[10];
        public int Count = 0;
        public void AddValue(int number)
        {
            if(Count == 10)
            {
                throw new InvalidOperationException("Print Service is Full");
            }

            Numbers[Count] = number;
            Count++;
        }
        public int First()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Print Service is Empty");
            }

            return Numbers[0];
        }

        public void Print()
        {
            Console.Write("[");

            for(int i = 0; i < Count - 1; i++) //Imprimindo até a penúltima posição
            {
                Console.Write(Numbers[i] + ", ");
            }

            if(Count > 0)
            {
                Console.Write(Numbers[Count - 1]); //Imprimindo o último valor
            }
            Console.WriteLine("]");
        }
    }
}
