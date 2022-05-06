using BankSystemTest.Data.Data.DbContexts;
using BankSystemTest.Data.IRepositories;
using BankSystemTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace BankSystemTest.Data.Repositories
{
  public class OrderRepository : GenericRepository<Order>, IOrderRepository
  { 
    public OrderRepository(BankSystemDbContext dbContext) : base(dbContext)
    {
      
    }

    public async Task<Invoice> GetOrderInvoice(int orderId)
    {
      var result = await dbContext.Orders.Include(p => p.Invoice).FirstOrDefaultAsync(p => p.Id == orderId);
      return result.Invoice;
    }
  }
}
