namespace Katapotter.DiscountRules
{
    public interface IDiscountRule
    {
        decimal Discount { get; }
        bool Match (int numberOfDistinctBooks);
    }
}