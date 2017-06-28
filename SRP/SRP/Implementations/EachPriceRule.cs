using SRP.Interfaces;
using System;
using SRP.Model;

namespace SRP.Implementations
{
    public class EachPriceRule : IPriceRule
    {
        public decimal CalculatePrice(OrderItem item)
        {
            return item.Quatity * 5m;
        }

        public bool IsMatch(OrderItem item)
        {
            return item.Sku.StartsWith("EACH");
        }
    }
}
