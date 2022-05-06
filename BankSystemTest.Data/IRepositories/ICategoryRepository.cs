using BankSystemTest.Domain.Entities;
using System.Threading.Tasks;

namespace BankSystemTest.Data.IRepositories
{
  public interface ICategoryRepository : IGenericRepository<Category>
  {
    public Task<Category> GetAsync(int id);
  }
}
