
using SRP.Implementations;
using SRP.Interfaces;

namespace SRP.Model
{
    public class OnlineOrder : Order
    {
        private PaymentDetails _paymentDetails;
        private readonly IPaymentProcessor _paymentProcessor;
        private readonly IReservationService _reservationService;
        private readonly INotificationService _notificationService;

        public OnlineOrder(Cart cart, PaymentDetails paymentDetails) : base(cart)
        {
            _paymentDetails = paymentDetails;
            // use DI in here
            _paymentProcessor = new PaymentProcessor();
            _reservationService = new ReservationService();
            _notificationService = new NotificationService();
        }

        public override void Checkout()
        {
            _paymentProcessor.ProcessCreditCard(_paymentDetails, _cart.TotalAmount());

            _reservationService.ReserveInventory(_cart.Items);

            _notificationService.NotifyCustomerOrderCreated(_cart);

            base.Checkout();
        }
    }
}
