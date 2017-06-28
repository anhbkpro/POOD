using SRP.Interfaces;
using System.Linq;
using SRP.Model;
using System.Collections.Generic;

namespace SRP.Implementations
{
    public class PricingCalculator : IPricingCalculator
    {
        private readonly IList<IPriceRule> _rules;

        public PricingCalculator()
        {
            _rules = new List<IPriceRule>
            {
                new EachPriceRule(),
                new PerGramPriceRule(),
                new SpecialPriceRule(),
                new Buy4GetOneFree()
            };
        }

        public decimal CalculatePrice(OrderItem item)
        {
            return _rules.First(i => i.IsMatch(item)).CalculatePrice(item);
        }
    }
}
