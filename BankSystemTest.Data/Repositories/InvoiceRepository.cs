using BankSystemTest.Data.Data.DbContexts;
using BankSystemTest.Data.IRepositories;
using BankSystemTest.Domain.Entities;

namespace BankSystemTest.Data.Repositories
{
  public class InvoiceRepository : GenericRepository<Invoice>, IInvoiceRepository
  {
    public InvoiceRepository(BankSystemDbContext dbContext) : base(dbContext)
    {
    }
  }
}
