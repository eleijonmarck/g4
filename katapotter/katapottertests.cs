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
        var order = new Order();
        order.Add(book);
        
        //When
        //Then
        Assert.Equal(8,order.Cost());
        }

        [Theory]
        [InlineData("first","first")]
        public void Two_same_books_should_cost_16_euros(string title1, string title2)
        {
            var book1 = new Book(title1);
            var book2 = new Book(title2);

            var order = new Order();
            order.Add(book1);
            order.Add(book2);

            Assert.Equal(16,order.Cost());
        }

        [Theory]
        [InlineData("first","second")]
        public void Two_different_books_should_get_discount(string title1, string title2)
        {
            var book1 = new Book(title1);
            var book2 = new Book(title2);

            var order = new Order();
            order.Add(book1);
            order.Add(book2);

            Assert.Equal(15.2m,order.Cost());
        }

        [Theory]
        [InlineData("first","second","third")]
        public void Three_different_books_should_give_3_book_discount(string title1, string title2, string title3)
        {
            var book1 = new Book(title1);
            var book2 = new Book(title2);
            var book3 = new Book(title3);

            var order = new Order();
            order.Add(book1);
            order.Add(book2);
            order.Add(book3);

            Assert.Equal(21,6m,order.Cost());
        }
    }

}