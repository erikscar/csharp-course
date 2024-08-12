

using RestricoesGenerics.Entities;

namespace RestricoesGenerics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter N: " );
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] x = Console.ReadLine().Split(',');
                list.Add(new Product(x[0], double.Parse(x[1])));
            }
        }
    }
}
