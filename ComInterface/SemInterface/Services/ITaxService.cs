namespace SemInterface.Services
{
    internal interface ITaxService
    {
        //Interface que fornece operações como se fossem um contrato para as classes implementarem

        public double Tax(double amount);
    }
}
