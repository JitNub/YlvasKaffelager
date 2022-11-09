using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YlvasKaffelager.DataModels;
using YlvasKaffelager.Repositories;

namespace YlvasKaffelager.Test
{
    public class ProductRepositoryTests
    {
        public UnitTest()
        {
            IList<Product> products = new List<Product>
            {
                new Product { Id = 1, Brand = "Arvid", Type = "Mellanrost", Price = 50 }
            };


            Mock<IProductRepository> mockProductRepository = new Mock<IProductRepository>();

            mockProductRepository.Setup(x => x.GetProducts()).Returns((List<Coffee>)products);

        }
        
        //IProductRepository _sut;
        
        //public ProductRepositoryTests()
        //{
        //    ProductRepository = new Mock<IProductRepository>();

        //    ProductRepository.SetupSequence(product => product.GetProduct(1)).Returns("Gevalia").Throws<Exception>();
            
        //    _sut = ProductRepository.Object;
        //}
        

        [Fact]

        public void Return_Product_If_Exists()
        {
            var expected = _sut.GetProduct(1);

            var actual = _sut.GetProduct(5);

            Assert.DoesNotContain(expected, actual);
        }
    }
}
