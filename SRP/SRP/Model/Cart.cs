using SRP.Implementations;
using SRP.Interfaces;
using System.Collections.Generic;

namespace SRP.Model
{
    public abstract class Cart
    {
        private readonly List<OrderItem> _items;
        private readonly IPricingCalculator _pricingCalculator;
        public IEnumerable<OrderItem> Items { get { return _items; } }
        public string CustomerEmail { get; set; }
        
        // Poor man's IOC
        public Cart() : this(new PricingCalculator())
        {
        }

        public Cart(IPricingCalculator pricingCalculator)
        {
            _items = new List<OrderItem>();
            _pricingCalculator = pricingCalculator;
        }

        public void Add(OrderItem item)
        {
            _items.Add(item);
        }

        public decimal TotalAmount()
        {
            decimal total = 0m;
            foreach (var item in Items)
            {
                total += _pricingCalculator.CalculatePrice(item);
            }

            return total;
        }

    }

    public class OrderItem
    {
        public string Sku { get; set; }
        public int Quatity { get; set; }
    }
}
