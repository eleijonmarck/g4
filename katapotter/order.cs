using System.Collections.Generic;
using System.Linq;
public class Order{

    public int numberOfBooksOrdered;
    public int numberOfExtraBooksOrdered;
    public Order(List<Book> books){

        numberOfBooksOrdered = books.Count;

        var count = 0;

        var distinctBooks = books.Select( x => x.title ).Distinct().Count();
    }

    public float Cost(){

        return 15.6F;
    }
}