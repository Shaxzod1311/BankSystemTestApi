using BankSystemTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemTest.Service.Interfaces
{
  public interface IProductService
  {
    public Task<IQueryable<Product>> GetAllAsync();
    public Task<Product> GetAsync(int id);
  }
}
