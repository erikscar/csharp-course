using ExercicioPolimorfismo.Entities;
using System.Globalization;

namespace ExercicioPolimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the Number of Profucts: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} Data: ");

                Console.Write("Common, Used or Imported? (c / u / i) ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

                if(ch == 'i') 
                {
                    Console.Write("Customs Fee: ");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(name, price, customFee));
                }
                else if(ch == 'u') 
                {
                    Console.Write("Manufacture Date: (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    products.Add(new Product(name, price));
                }
                Console.WriteLine();
            }
            Console.WriteLine("Price Tags: ");

            foreach(var product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
