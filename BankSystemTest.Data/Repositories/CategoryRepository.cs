using BankSystemTest.Data.Data.DbContexts;
using BankSystemTest.Data.IRepositories;
using BankSystemTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BankSystemTest.Data.Repositories
{
  public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
  {
   
    public CategoryRepository(BankSystemDbContext dbContext) : base(dbContext)
    {
    }

    public async Task<Category> GetAsync(int id)
    {
      var result = await dbContext.Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);

      return result.Category;
    }
  }
  }

