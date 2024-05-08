namespace RestParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Passando 2 números para o método
            int s1 = Calculator.Sum(2, 3);
            Console.WriteLine(s1);

            //Passando um array de números para o método 
            int s2 = Calculator.Sum1(new int[] { 2, 3, 5 });
            Console.WriteLine(s2);

            //Passando somente números para o método, utilizando o Rest Params,
            //Tornando mais simples e podemos inserir qualquer quantidade de números
            int s3 = Calculator.Sum2(1, 2, 3, 41);
            Console.WriteLine(s3);
        }
    }
}
