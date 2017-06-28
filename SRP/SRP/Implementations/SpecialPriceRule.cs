using SRP.Interfaces;
using SRP.Model;

namespace SRP.Implementations
{
    public class SpecialPriceRule : IPriceRule
    {
        public decimal CalculatePrice(OrderItem item)
        {
            decimal total = 0m;
            // $0.40 each; 3 for a $1.00
            total += item.Quatity * .4m;
            int setOfThree = item.Quatity / 3;
            total -= setOfThree * .2m;
            return total;
        }

        public bool IsMatch(OrderItem item)
        {
            return item.Sku.StartsWith("SPECIAL");
        }
    }
}
