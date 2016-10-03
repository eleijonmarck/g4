using System.Collections.Generic;
using System.Linq;
public class Order
{

    public int numberOfBooksOrdered;
    public int numberOfExtraBooksOrdered;
    public int distinctBooks;
    public Order(List<Book> books)
    {

        numberOfBooksOrdered = books.Count;

        distinctBooks = books.Select( x => x.title ).Distinct().Count();

        numberOfExtraBooksOrdered = numberOfBooksOrdered - distinctBooks;
    }

    public double Cost()
    {
        double cost = 0;
        if (distinctBooks > 1)
        {
            cost += discoutCostForBooks(distinctBooks);
        }
        else 
        {
            cost += originalPriceForBooks(numberOfBooksOrdered);
        }

        return cost;
    }

    private double discoutCostForBooks(int discountbooks)
    {
        switch (discountbooks)
        {
            case 2 :
                return originalPriceForBooks(discountbooks)*TwoBookDiscount;
            default :
                return originalPriceForBooks(discountbooks);
                break;

        }
    }
    private int originalPriceForBooks(int books)
    {
        return books*OneBookCost;
    }

    private static int OneBookCost = 8;
    private static double TwoBookDiscount = 0.05;
}