using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var Order = new Order();

            Order.Add(new Book("first"));
            Order.Add(new Book("second"));
            Order.Add(new Book("third"));
            Order.Add(new Book("fourth"));
            Order.Add(new Book("fifth"));

            Console.WriteLine("Cost is : {0}, with discount counted as {1} with {2} unique books", Order.Cost(), Order.getDistinctBooks(), Order.numberOfBooksOrdered());
        }
    }
}
