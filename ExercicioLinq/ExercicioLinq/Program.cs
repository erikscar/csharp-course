using ExercicioLinq.Entities;
using System.Globalization;

namespace ExercicioLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Product> products = new List<Product>();

                //C:\Users\eriks\Desktop\in.csv
                Console.Write("Enter File Full Path: ");
                string path = Console.ReadLine();

                using(StreamReader sr = File.OpenText(path))
                {
                    while(!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        double price = double.Parse(line[1], CultureInfo.InvariantCulture);
                        products.Add(new Product(name, price));
                        
                    }

                    var average = products.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
                    Console.WriteLine("Average Price: " + average.ToString("F2", CultureInfo.InvariantCulture));

                    var result = products.Where(p => p.Price < average).OrderByDescending(p => p.Name).Select(p => p.Name);
                    foreach(string name in result)
                    {
                        Console.WriteLine(name);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An Error Ocurred: " + e.Message);
            }
        }
    }
}
