using BankSystemTest.Data.Data.DbContexts;
using BankSystemTest.Data.IRepositories;
using BankSystemTest.Domain.Entities;

namespace BankSystemTest.Data.Repositories
{
  public class ProductRepository : GenericRepository<Product>, IProductRepository
  {
    public ProductRepository(BankSystemDbContext context) : base(context)
    {
    }

  }
}
