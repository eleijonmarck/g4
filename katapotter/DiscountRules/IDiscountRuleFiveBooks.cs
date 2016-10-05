namespace Katapotter.DiscountRules
{
    public class IDiscountRuleFiveBooks : IDiscountRule
    {
        public decimal Discount
        {
            get {return 25;}
        }

        public bool Match(int numberOfDistinctBooks)
        {
            return numberOfDistinctBooks == 5;
        }
    }
}