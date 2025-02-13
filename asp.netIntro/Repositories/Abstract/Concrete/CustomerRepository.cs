using System.Linq.Expressions;
using asp.netIntro.Data;
using asp.netIntro.Entities;

namespace asp.netIntro.Repositories.Abstract.Concrete
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(ECommerceDbContext context):base(context) { }
    }
}
