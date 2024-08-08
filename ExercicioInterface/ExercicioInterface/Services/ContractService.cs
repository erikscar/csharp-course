using ExercicioInterface.Entities;

namespace ExercicioInterface.Services
{
    internal class ContractService
    {
        private IPaymentService _paymentService;

        public ContractService(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void Installments(Contract contract, int installmentsNumber)
        {
            double value = contract.TotalValue / installmentsNumber;

            for (int i = 1; i <= installmentsNumber; i++)
            {
               double installmentValue =  _paymentService.Payment(value, i);
               var installment = new Installment(contract.Date.AddMonths(i), installmentValue);
               contract.AddInstallment(installment);
            }

           
        }
    }
}
