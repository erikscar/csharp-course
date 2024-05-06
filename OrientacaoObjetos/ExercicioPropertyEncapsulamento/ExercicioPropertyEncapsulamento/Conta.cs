using System.Globalization;

namespace ExercicioPropertyEncapsulamento
{
    internal class Conta
    {
        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string titular)
        {
            NumeroConta = numero;
            Titular = titular;
        }
        public Conta (int numero, string titular, double deposito) : this (numero, titular)
        {
            Deposito(deposito); //Usar a Função Deposito já que ela funciona para os depósitos
        }

        public void Deposito (double deposito)
        {
            Saldo += deposito;
        }
        public void Saque (double saque)
        {
            Saldo -= (saque + 5.00);
        }
        public override string ToString()
        {
            return 
                "Conta " 
                + NumeroConta
                + ", " + "Titular: " 
                + Titular + ", " 
                + "Saldo: R$" 
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
