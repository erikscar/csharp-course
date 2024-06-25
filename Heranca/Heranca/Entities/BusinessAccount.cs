namespace Heranca.Entities
{
    //Agora BusinessAccount terá tudo que Account TEM!
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        //Inicializando o Construtor usar o base para evitar repetir o mesmo código da classe Account
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if(amount <= LoanLimit) 
            {
                Balance += amount;
            }
        }
    }
}
