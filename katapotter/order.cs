using System.Collections.Generic;
using System.Linq;
using Katapotter.Discounter;
using Katapotter.DiscountRules;
public class Order
{
    private static decimal OneBookCost = 8;
    private readonly List<Book> _books;
    public IEnumerable<Book> Books { get { return _books; }}

    private Discounter _discounter;
    public Order(IEnumerable<IDiscountRule> discountRules)
    {
        _books = new List<Book>();
        _discounter = new Discounter(discountRules);
    }

    public int numberOfBooksOrdered()
    {
        return _books.Count();
    }

    public int getDistinctBooks()
    {
        return _books.Select( x => x.title ).Distinct().Count();
    }

    public decimal Cost()
    {
        var distinctBooks = getDistinctBooks();
        decimal cost = 0;
        if (distinctBooks > 1)
        {
            cost += originalPriceForBooks(_books) - _discounter.CalculateDiscount(distinctBooks)*originalPriceForBooks(_books);
        }
        else 
        {
            cost += originalPriceForBooks(_books);
        }

        return cost;
    }

    private decimal originalPriceForBooks(List<Book> books)
    {
        return books.Count()*OneBookCost;
    }

    public void Add(Book book)
    {
        _books.Add(book);
    }

    public void Remove(Book book)
    {
        _books.Remove(book);
    }
}