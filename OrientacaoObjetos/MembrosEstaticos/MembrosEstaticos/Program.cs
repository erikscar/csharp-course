using System.Globalization;

namespace MembrosEstaticos
{
    internal class Program
    {
        static double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Entre com  o Valor do Raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double cir = Circunferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferência: " + cir.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
        //Para Chamar uma Função dentro de uma Função Estática NA MESMA CLASSE, é necessário que ambas sejam ESTÁTICA

        static double Circunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        static double Volume(double raio)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(raio, 3);
        }
    }
}
