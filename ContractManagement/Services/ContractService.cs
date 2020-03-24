using System;
using ContractManagement.Entities;

namespace ContractManagement.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ContractProcess(Contract contract, int months)
        {
            double payment = contract.ContractValue / months;

            for (int nMonths = 1; nMonths <= months; nMonths++)
            {
                DateTime dueDate = contract.Date.AddMonths(nMonths);
                double totalToPay = payment + _onlinePaymentService.InterestFee(payment, nMonths);
                totalToPay += _onlinePaymentService.PaymentFee(totalToPay);
                contract.AddInstallments(new Installment(dueDate, totalToPay));
            }
        }
    }
}
