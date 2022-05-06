using BankSystemTest.Data.Data.DbContexts;
using BankSystemTest.Data.IRepositories;
using BankSystemTest.Domain.Entities;

namespace BankSystemTest.Data.Repositories
{
  public class PaymentRepository : GenericRepository<Payment>, IPaymentRepository
  {
    public PaymentRepository(BankSystemDbContext dbContext) : base(dbContext)
    {
    }
  }
}
