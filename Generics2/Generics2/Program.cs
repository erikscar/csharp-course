namespace Generics2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Passando o tipo agora para a classe
            PrintService<string> printService = new PrintService<string>();

            Console.Write("How Many Values? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++) 
            {
                string x = Console.ReadLine();
                printService.AddValue(x);
            }

            //Agora ele irá dar erro em tempo de compilação, porque foi criado um vetor de string!
            //Type Safety agora funciona!
            //int a = (int)printService.First();
            //int b = a + 2;
            //Console.WriteLine(b);

            printService.Print();
            Console.WriteLine("First: " + printService.First());
        }
    }
}
