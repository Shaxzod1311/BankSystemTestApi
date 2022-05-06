using BankSystemTest.Domain.Entities;
using System.Threading.Tasks;

namespace BankSystemTest.Data.IRepositories
{
  public interface IOrderRepository : IGenericRepository<Order>
  {
    public Task<Invoice> GetOrderInvoice(int orderId);
  }
}
