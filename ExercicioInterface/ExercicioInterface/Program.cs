using ExercicioInterface.Entities;
using ExercicioInterface.Services;
using System.Globalization;

namespace ExercicioInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Contract Data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.Write("Contract Value: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract contract = new Contract(number, date, value);

            Console.Write("Enter the Number of Installments: ");
            int installmentNumber = int.Parse(Console.ReadLine());


            ContractService contractService = new ContractService(new PayPalPayment());
            contractService.Installments(contract, installmentNumber);
            

            foreach(Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
