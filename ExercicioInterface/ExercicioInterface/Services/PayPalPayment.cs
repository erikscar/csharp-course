namespace ExercicioInterface.Services
{
    internal class PayPalPayment : IPaymentService
    {
        public double Payment(double installment, int installmentNumber)
        {
            double firstFee = installment + installment * 0.01 * installmentNumber;
            double allFee = firstFee + firstFee * 0.02;
            return allFee;
        }
    }
}
