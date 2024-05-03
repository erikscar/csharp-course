using System.Globalization;

namespace ExercicioFixacao02Basico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario a = new Funcionario();
            Funcionario b = new Funcionario();

            Console.WriteLine("Dados do Primeiro Funcionário");
            Console.Write("Nome: ");
            a.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            a.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do Segundo Funcionário");
            Console.Write("Nome: ");
            b.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            b.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = (a.Salario + b.Salario) / 2.0;
            Console.WriteLine("Salário Médio: {0}", salarioMedio.ToString("C"));

        }
    }
}
