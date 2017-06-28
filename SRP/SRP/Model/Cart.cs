using System.Collections.Generic;

namespace SRP.Model
{
    public abstract class Cart
    {
        public decimal TotalAmount { get; set; }
        public IEnumerable<OrderItem> Items { get; set; }
        public string CustomerEmail { get; set; }
    }

    public class OrderItem
    {
        public string Sku { get; set; }
        public int Quatity { get; set; }
    }
}
