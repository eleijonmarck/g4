namespace Katapotter.DiscountRules
{
    public class IDiscountRuleTwoBooks : IDiscountRule
    {
        public decimal Discount
        {
            get { return 0.05m;}
        }
        public bool Match(int numberOfDistinctBooks)
        {
            return numberOfDistinctBooks == 2;
        }
    }
}