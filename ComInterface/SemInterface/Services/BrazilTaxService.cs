namespace SemInterface.Services
{
    internal class BrazilTaxService : ITaxService
        //TEMOS QUE IMPLEMENTAR A INTERFACE
    {
        //Implementando a operação provida da Interface
        public double Tax(double amount) //Como tem o mesmo nome do método da  interface irá automaticamente
        {
            if (amount <= 100.00) 
            {
                return amount * 0.2;
            }
            else
            {   
                return amount * 0.15;
            }
        }
    }
}
