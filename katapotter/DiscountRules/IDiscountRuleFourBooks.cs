namespace Katapotter.DiscountRules
{
    public class IDiscountRuleFourBooks : IDiscountRule
    {
        public decimal Discount
        {
            get { return 15;}
        }

        public bool Match(int numberOfDistinctBooks)
        {
            return numberOfDistinctBooks == 4;
        }
    }

}
