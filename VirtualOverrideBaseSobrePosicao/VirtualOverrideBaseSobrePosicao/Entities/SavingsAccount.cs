namespace VirtualOverrideBaseSobrePosicao.Entities
{
    internal class SavingsAccount : Account
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

        //Sobrescrevendo o método Withdraw, pra isso devemos colocar a palavra virtual na SuperClasse
        //E utilizar o override na SubClasse modificando o método
        public override void Withdraw(double amount)
        {
            //Reaproveitando a operação da Superclasse e depois alterando algo
            base.Withdraw(amount); //Palavra Base serve para Chamar o método da SuperClasse da forma que ele está implementado na SuperClasse
            Balance -= 2.0; //Descotando 2 depois de realizar o saque da Superclasse
        }
    }
}
