using asp.netIntro.Entities;

namespace asp.netIntro.Repositories.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {
        Task<List<Product>> GetHigherPricedProducts(int count);
        Task<List<Product>> GetMostDiscountedProducts(int count);
    }
}
