using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YlvasKaffelager.DataModels;

namespace YlvasKaffelager.Test
{
    public class DbTest
    {
        public Mock<Coffee> OrderDb { get; set; }

        public Coffee _sut { get; set; }

        public DbTest()
        {
            var testId = 1;

            OrderDb = new Mock<Coffee>();

            OrderDb.Setup(x => x.Id == 1);

            _sut = OrderDb.Object;
        }

        [Fact]

        public void Should_Check_Db()
        {
            var expected = 0;

            var actual = 0;

            Assert.Equal(expected, actual);
        }
    }
}
