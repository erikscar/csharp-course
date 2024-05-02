using System.Globalization;

namespace ExerciciosMembrosEstaticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Qual é a Cotação do Dólar? ");
            ConversorDeMoeda.Dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos Dólares Você vai Comprar? ");
            double quantidade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Valor a ser Pago em Reais: " + ConversorDeMoeda.Conversor(quantidade).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
