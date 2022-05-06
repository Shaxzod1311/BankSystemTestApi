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
  public class CategoryService : ICategoryService
  {
    private readonly IUnitOfWork unitOfWork;

    public CategoryService(IUnitOfWork unitOfWork)
    {
      this.unitOfWork = unitOfWork;
    }
    
    public async Task<IEnumerable<Category>> GetAllAsync()
    {
      return await unitOfWork.Categories.GetAllAsync();
    }

    public async Task<Category> GetAsync(int productId)
    {
      var result = await unitOfWork.Categories.GetAsync(productId);
      return result;
    }
  }
}
