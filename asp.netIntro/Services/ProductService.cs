using asp.netIntro.Entities;
using asp.netIntro.Repositories.Abstract;

namespace asp.netIntro.Services
{
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<List<Product>> GetMostDiscountedProducts(int count)
        {
            return await _productRepository.GetMostDiscountedProducts(count); 
        }
        public async Task<List<Product>> GetHigherPricedProducts(int count)
        {
            return await _productRepository.GetHigherPricedProducts(count);
        }
    }
}
