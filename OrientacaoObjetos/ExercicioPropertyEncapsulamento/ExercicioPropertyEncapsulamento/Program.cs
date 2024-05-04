using System.Globalization;

namespace ExercicioPropertyEncapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Conta c = null;
            Console.Write("Entre com o Número da Conta: ");
            int numeroconta = int.Parse(Console.ReadLine());

            Console.Write("Entre com o Titular da Conta: ");
            string titular = Console.ReadLine();

            Console.Write("Hávera Depósito Inicial? (S/N): ");
            string depositoInicial = Console.ReadLine();

            if (depositoInicial.ToLower() == "s")
            {
                Console.Write("Entre o Valor de Depósito Inicial: ");
                double valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(numeroconta, titular, valorInicial);

            } else if(depositoInicial.ToLower() == "n" )
            {
                c = new Conta(numeroconta, titular);
            } else
            {
                Console.WriteLine("Opção Inválida Utilize (S/N)");
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta: " + c);

            Console.WriteLine();
            Console.Write("Entre um Valor para Depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Deposito(deposito);
            Console.WriteLine("Dados da Conta Atualizados: " + c);

            Console.WriteLine();
            Console.Write("Entre um Valor para Saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c.Saque(saque);
            Console.WriteLine("Dados da Conta Atualizados: " + c);



        }
    }
}
