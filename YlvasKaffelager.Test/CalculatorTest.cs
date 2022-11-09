using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YlvasKaffelager.Test
{
    public class CalculatorTest
    {
        Calculator _sut;

        public CalculatorTest()
        {
            _sut = new Calculator();
        }

        [Fact]

        public void Total_Should_Always_Be_Correct()
        {
            // Arrange
            decimal amount = 5;
            decimal price = 19m;
            var expected = 95;

            // Act
            var actual = _sut.Get(amount, price);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
