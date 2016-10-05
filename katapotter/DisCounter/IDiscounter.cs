namespace Katapotter.Discounter
{
    public interface IDiscounter
    {
        decimal CalculateDiscount(int numberOfDistinctBooks);
    }
}