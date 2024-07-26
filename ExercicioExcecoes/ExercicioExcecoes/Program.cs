using ExercicioExcecoes.Entities;
using ExercicioExcecoes.Entities.Exceptions;
using System.Globalization;

namespace ExercicioExcecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Enter Account Data: ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                string holder = Console.ReadLine();

                Console.Write("Initial Balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Withdraw Limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(number, holder, initialBalance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter Amount for Withdraw: ");
                double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                acc.Withdraw(amount);
                Console.WriteLine("New Balance: " + acc.Balance.ToString("C"));
            }
            catch(DomainException e)
            {
                Console.WriteLine("Withdraw Error: " + e.Message);
            }

        }
    }
}
