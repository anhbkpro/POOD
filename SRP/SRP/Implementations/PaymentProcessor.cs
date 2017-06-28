using SRP.Interfaces;
using System;
using SRP.Model;

namespace SRP.Implementations
{
    internal class PaymentProcessor : IPaymentProcessor
    {
        public void ProcessCreditCard(PaymentDetails paymentDetails, decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
