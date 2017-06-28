using SRP.Implementations;
using SRP.Interfaces;

namespace SRP.Model
{
    public class CreditOrder : Order
    {
        private readonly PaymentDetails _paymentDetails;
        private readonly IPaymentProcessor _paymentProcessor;

        public CreditOrder(Cart cart, PaymentDetails paymentDetails) : base(cart)
        {
            _paymentDetails = paymentDetails;
            _paymentProcessor = new PaymentProcessor();
        }

        public override void Checkout()
        {
            _paymentProcessor.ProcessCreditCard(_paymentDetails, _cart.TotalAmount());

            base.Checkout();
        }
    }
}
