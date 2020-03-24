namespace ContractManagement.Services
{
    interface IOnlinePaymentService
    {
        public double InterestFee(double amount, int months);
        public double PaymentFee(double amount);
    }
}
