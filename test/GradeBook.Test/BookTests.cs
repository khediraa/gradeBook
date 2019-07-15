using System;
using Xunit;

namespace GradeBook.Test
{
    public class BookTest
    {
        [Fact]
        public void BookCalculatesStats()
        {
            // arrange
            var book = new InMemoryBook("");
            book.AddGrade(89.2);
            book.AddGrade(15.3);
            book.AddGrade(34.7);

            // act
            var result = book.GetStats();

            // assert
            Assert.Equal(46.4, result.Average, 1);
            Assert.Equal(89.2, result.High, 1);
            Assert.Equal(15.3, result.Low, 1);
            Assert.Equal('F', result.Letter);
        }
    }
}
