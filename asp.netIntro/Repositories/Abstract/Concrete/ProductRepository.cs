using System.Linq.Expressions;
using asp.netIntro.Data;
using asp.netIntro.Entities;
using Microsoft.EntityFrameworkCore;

namespace asp.netIntro.Repositories.Abstract.Concrete
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(ECommerceDbContext context):base(context) { }
        public async Task<List<Product>> GetHigherPricedProducts(int count)
        {
            return await _dbSet.OrderByDescending(p => p.Price).Take(count).ToListAsync();
        }

        public async Task<List<Product>> GetMostDiscountedProducts(int count)
        {
            return await _dbSet.OrderByDescending(p => p.Discount).Take(count).ToListAsync();
        }
    }
}
