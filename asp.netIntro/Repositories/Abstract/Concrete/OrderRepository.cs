using System.Linq.Expressions;
using asp.netIntro.Data;
using asp.netIntro.Entities;

namespace asp.netIntro.Repositories.Abstract.Concrete
{
    public class OrderRepository : Repository<Order>,IOrderRepository
    {
        public OrderRepository(ECommerceDbContext context):base(context) { }
        
    }
}
