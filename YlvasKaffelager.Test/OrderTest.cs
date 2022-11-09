using Xunit;
using YlvasKaffelager.DataModels;
using YlvasKaffelager.Models;

namespace YlvasKaffelager.Test
{
    public class OrderTest
    {
        [Fact]

        public void Should_Return_Total_Value()
        {
            var _sut = new Order() { Total = 4};

            var expected = 4;

            var actual = _sut.Total;

            Assert.Equal(expected, actual);

        }
    }
}