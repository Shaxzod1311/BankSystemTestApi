using BankSystemTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemTest.Service.Interfaces
{
  public interface ICategoryService
  {
    public Task<IEnumerable<Category>> GetAllAsync();
    public Task<Category> GetAsync(int productId);
  }
}
