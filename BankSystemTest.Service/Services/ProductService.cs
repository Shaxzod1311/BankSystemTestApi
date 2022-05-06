using BankSystemTest.Data.IRepositories;
using BankSystemTest.Domain.Entities;
using BankSystemTest.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemTest.Service.Services
{
  public class ProductService : IProductService
  {
    private readonly IUnitOfWork unitOfWork;

    public ProductService(IUnitOfWork unitOfWork)
    {
      this.unitOfWork = unitOfWork;
    }
    public async Task<IQueryable<Product>> GetAllAsync()
    {
      return await unitOfWork.Products.GetAllAsync();
    }

    public Task<Product> GetAsync(int id)
    {
      return unitOfWork.Products.GetAsync(p => p.Id == id);
    }
  }
}
