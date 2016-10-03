using Xunit;
using System.Collections.Generic;

namespace KataPotterTests
{
    public class BookRulesTests
    {
        [Fact]
        public void One_book_should_cost_8_euros()
        {
        //Given
        var title = "first";
        var book = new Book(title);
        book.cost = 8;
        
        //When
        //Then
        Assert.Equal(8,book.cost);
        }

        [Fact]
        public void Two_same_books_should_cost_16_euros(string title1, string title2)
        {
            var book1 = new Book(title1);
            var book2 = new Book(title2);

            var books = new List<Book>(){
                book1,
                book2
            };
            var order = new Order(books);

            Assert.Equal(16,order.Cost());
        }

        [Fact]
        public void Two_different_books_should_cost_16_euros()
        {

        }
    }

}