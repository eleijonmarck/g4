namespace Katapotter.DiscountRules
{
    public class DiscountRuleFiveBooks : IDiscountRule
    {
        public decimal Discount => 0.25m;

        public bool Match(int numberOfDistinctBooks)
        {
            return numberOfDistinctBooks == 5;
        }
    }
}