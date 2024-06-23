using Entities;
using System.Globalization;

namespace Services
{
    class ContractService
    {

        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            this._onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double division = contract.totalValue / months;

            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.date.AddMonths(i);

                double value = _onlinePaymentService.Interest(division, i);

                double result = _onlinePaymentService.PaymentFee(value);

                contract.AddInstalmment(new Installment(date, result));
            }
        }
    }
}