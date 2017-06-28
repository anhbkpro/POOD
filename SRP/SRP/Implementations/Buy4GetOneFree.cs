using SRP.Interfaces;
using SRP.Model;

namespace SRP.Implementations
{
    public class Buy4GetOneFree : IPriceRule
    {
        public decimal CalculatePrice(OrderItem item)
        {
            decimal total = 0m;
            total += item.Quatity * 1m;
            int setOfFive = item.Quatity / 5;
            total -= setOfFive * 1m;
            return total;
        }

        public bool IsMatch(OrderItem item)
        {
            return item.Sku.StartsWith("B4G1");
        }
    }
}
