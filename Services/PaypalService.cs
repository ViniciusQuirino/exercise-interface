namespace Services
{
    class PaypalService : IOnlinePaymentService
    {
        public double Interest(double value, int month) //juros simples mensais
        {
            return ((value * 0.01) * month) + value;
        }

        public double PaymentFee(double value) //taxa de pagamento
        {
            return (value * 0.02) + value;
        }

    }
}