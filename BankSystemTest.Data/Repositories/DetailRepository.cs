using BankSystemTest.Data.Data.DbContexts;
using BankSystemTest.Data.IRepositories;
using BankSystemTest.Domain.Entities;

namespace BankSystemTest.Data.Repositories
{
  public class DetailRepository : GenericRepository<Detail>, IDetailRepository
  {
    public DetailRepository(BankSystemDbContext dbContext) : base(dbContext)
    {
    }
  }
}
