using SRP.Model;
using System.Collections.Generic;

namespace SRP.Interfaces
{
    internal interface IReservationService
    {
        void ReserveInventory(IEnumerable<OrderItem> items);
    }
}
