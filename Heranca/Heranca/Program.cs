using Heranca.Entities;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.00, 500.00);

            Console.WriteLine(account.Balance) ;

            //Atributo n acessível é protected apenas pela HERANCA
            //account.Balance = 200; 
        }
    }
}
