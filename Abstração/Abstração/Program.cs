using Abstração.Entities;
using System.Globalization;

namespace Abstração
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Account acc1 = new Account(1001, "Erik", 500.0); Erro, não é possível instanciar uma classe abstrata

            List<Account> list = new List<Account>();
            // Porém podemos instanciar listas com o tipo de classe                                         
            //E Ainda juntar 2 tipos dentro dessa Lista, a BusinessAccount e a SavingsAccount por causa  da Herança!!

            list.Add(new SavingsAccount(1001, "Alex", 500.00, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1004, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1005, "Anna", 500.0, 500.0));

            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach (Account acc in list)
            {
                acc.WithDraw(10.0);
            }
            foreach (Account acc in list)
            {
                Console.WriteLine("Updated balance for account "
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
