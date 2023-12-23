using ETradeAPI.Application.Repositories;
using ETradeAPI.Domain.Entities;
using ETradeAPI.Persistence.Contexts;

namespace ETradeAPI.Persistence.Repositories
{
    public class CustomerReadyRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadyRepository(ETradeAPIDbContext context) : base(context)
        {
        }
    }
}
