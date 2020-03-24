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
            double payment = _onlinePaymentService.InterestFee(contract.ContractValue, months);
            payment = _onlinePaymentService.PaymentFee(payment);

            DateTime dueDate = contract.Date.AddMonths(months);

            contract.Installments = new Installment(dueDate, payment);
        }
    }
}
