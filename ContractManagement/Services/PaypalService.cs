namespace ContractManagement.Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double InterestFee(double amount, int months)
        {
            return amount + (amount * 0.01) * months;
        }
        public double PaymentFee(double amount)
        {
            return amount + amount * 0.02;
        }
    }
}
