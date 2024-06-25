namespace Heranca.Entities
{
    internal class Account
    {
        //Com o private só podemos modificar os atributos dentro da propria classe
        //Porém com o PROTECTED podemos modificar os atributos na HERANÇA
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
