using System.Globalization;

namespace ExercicioClasseAtributoMetodo02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new Funcionario();
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           
            Console.WriteLine();
            Console.WriteLine("Funcionário: " + funcionario);

            Console.WriteLine();
            Console.Write("Digite a Porcentagem para Aumentar o Salário: ");
            double aumento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(aumento);

            Console.WriteLine();
            Console.WriteLine("Dados Atualizados: " + funcionario);

        }
    }
}
