using SRP.Model;

namespace SRP.Interfaces
{
    internal interface INotificationService
    {
        void NotifyCustomerOrderCreated(Cart cart);
    }
}
