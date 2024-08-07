using ExercicioArquivos.Entities;
using System.Globalization;

namespace ExercicioArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\eriks\Desktop\ExercicioArquivos\source.txt";
            string targetPath = @"C:\Users\eriks\Desktop\ExercicioArquivos\out\summary.csv";

            string[] lines = File.ReadAllLines(sourcePath);

            try
            {
                Directory.CreateDirectory(@"C:\Users\eriks\Desktop\ExercicioArquivos\out");

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(",");
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Product product = new Product(name, price, quantity);

                        sw.WriteLine(product);
                    }
                }
            }
            catch (IOException e )
            {
                Console.WriteLine("An Error Ocurred: " + e.Message);
            }
           
        }
    }
}
