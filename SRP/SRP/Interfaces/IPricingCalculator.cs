using SRP.Model;

namespace SRP.Interfaces
{
    public interface IPricingCalculator
    {
        decimal CalculatePrice(OrderItem item);
    }
}
