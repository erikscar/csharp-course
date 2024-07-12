using UpcastingDownCasting.Entities;

namespace UpcastingDownCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //Upcasting - Convertendo a SubClasse para a SuperClasse

            Account acc1 = bacc; //Totalmente possível porque uma BusinessAccount é uma Account, porém agr ela não vai ter as propriedades de BusinessAccount
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);


            //DownCasting - Convertendo a SuperClasse para um Subclasse - Não é Seguro 

            //BusinessAccount acc4 = acc2;
            //Não é possível armazenar dessa forma, mesmo que o acc2 seja uma Instância de BusinessAccount
            //porque esta armazenado em uma variável Account

            BusinessAccount acc4 = (BusinessAccount)acc2; //Account para BusinessAccount
            acc4.Loan(100.0); //Agora é possível utilizar o método da BusinessAccount

            if(acc3 is BusinessAccount) // Se acc3 tiver armazzenado uma instância de BusinessAccount fazer a conversão, porque acc3 é uma Account
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3; As duas formas de conversão FUNCIONAM!!!
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if(acc3 is SavingsAccount)
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Updated");

            }

            //Caso tentarmos converter uma Instância de SavingsAccount armazenada em uma  Account em  BusinessAccount
            //ocorrerá um erro em tempo de execução, devemos sempre testar antes para que a conversão seja válida.


        }
    }
}
