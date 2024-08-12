using Generics1.Entities;

namespace Generics1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintService p = new PrintService();

            Console.Write("How Many Values? ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                p.AddValue(value);
            }

            p.Print();

            Console.WriteLine("First: " + p.First());
        }
    }
}
