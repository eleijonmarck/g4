
using System.Collections.Generic;
using System.Linq;
using Katapotter.DiscountRules;
namespace Katapotter.Discounter
{
    public class Discounter : IDiscounter
    {
        private readonly IEnumerable<IDiscountRule> _discountRules;
        public Discounter(IEnumerable<IDiscountRule> discountRules)
        {
            _discountRules = discountRules;
        }
        public decimal CalculateDiscount(int numberOfDistinctBooks)
        {
            // matches the rule with the correspodning number of distuntbooks
            var lol = _discountRules.First( dr => dr.Match(numberOfDistinctBooks) ).Discount;
            return lol;
        }
    }
}