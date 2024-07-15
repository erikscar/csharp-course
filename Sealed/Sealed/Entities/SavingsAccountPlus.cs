namespace Sealed.Entities
{
    internal class SavingsAccountPlus : SavingsAccount //Erro, não podemos herdar uma classe SEALED
    {
        public override void WithDraw(double amount) //ERRO, não podemos sobreescrever um método selado
        {
            base.WithDraw(amount);
        }
    }
}
