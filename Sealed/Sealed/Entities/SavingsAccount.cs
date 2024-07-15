namespace Sealed.Entities
{
     class SavingsAccount : Account //Selando a Classe ela não poderá mais participar da Herança
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void WithDraw(double amount)
            //Selando o método, agora esse método não pode mais ser sobrescrito de nenhuma forma por uma subclasse
        {
            base.WithDraw(amount);
            Balance -= 2.0;
        }
    }
}
