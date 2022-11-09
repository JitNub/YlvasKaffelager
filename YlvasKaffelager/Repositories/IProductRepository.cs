using YlvasKaffelager.DataModels;

namespace YlvasKaffelager.Repositories
{
    public interface IProductRepository
    {
        List<Coffee> GetProducts();

        public string GetProduct(int id);
    }
}
