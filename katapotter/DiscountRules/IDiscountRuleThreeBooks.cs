namespace Katapotter.DiscountRules
{
public class IDiscountRuleThreeBooks : IDiscountRule
{
    public decimal Discount
    {
        get { return 10;}
    }
    public bool Match(int numberOfDistinctBooks)
    {
        return numberOfDistinctBooks == 3;
    }
}
}