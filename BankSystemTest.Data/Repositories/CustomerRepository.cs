using BankSystemTest.Data.Data.DbContexts;
using BankSystemTest.Data.IRepositories;
using BankSystemTest.Domain.Entities;

namespace BankSystemTest.Data.Repositories
{
  public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
  {
    public CustomerRepository(BankSystemDbContext dbContext) : base(dbContext)
    {
    }
  }
}
