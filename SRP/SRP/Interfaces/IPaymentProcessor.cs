using SRP.Model;

namespace SRP.Interfaces
{
    internal interface IPaymentProcessor
    {
        void ProcessCreditCard(PaymentDetails paymentDetails, decimal amount);
    }
}
