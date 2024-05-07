using System.Globalization;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando um vetor com n posições
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                
            }

            //Somando todos os valores do Vetor
            double sum = 0.0;

            for (int i = 0;i < n; i++)
            {
                sum += vect[i];
            }

            double avg = sum / n;
            Console.WriteLine("ALTURA MÉDIA = " + avg.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
