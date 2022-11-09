using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YlvasKaffelager.Repositories;

namespace YlvasKaffelager.Test
{
    public class ProductRepositoryTests
    {
        Mock<IProductRepository> ProductRepository;
        IProductRepository _sut;
        
        public ProductRepositoryTests()
        {
            ProductRepository = new Mock<IProductRepository>();

            ProductRepository.SetupSequence(product => product.GetProduct(1)).Returns("Gevalia").Throws<Exception>();
            
            _sut = ProductRepository.Object;
        }
        

        [Fact]

        public void Return_Product_If_Exists()
        {
            var expected = _sut.GetProduct(1);

            var actual = _sut.GetProduct(5);

            Assert.DoesNotContain(expected, actual);
        }
    }
}
