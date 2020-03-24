namespace ContractManagement.Services
{
    class PaypalService : IOnlinePaymentService
    {
        private double _interestPercentage = 0.01;
        private double _paymentPercentage = 0.02;
        public double InterestFee(double amount, int months)
        {
            return amount * _interestPercentage * months;
        }
        public double PaymentFee(double amount)
        {
            return amount * _paymentPercentage;
        }
    }
}
