using BankSystemTest.Data.Data.DbContexts;
using BankSystemTest.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BankSystemTest.Data.Repositories
{
#pragma warning disable
  public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
  {
    private protected readonly BankSystemDbContext dbContext;
    private DbSet<T> dbSet;

    public GenericRepository(BankSystemDbContext dbContext)
    {
      this.dbContext = dbContext;
      dbSet = this.dbContext.Set<T>();
    }

    public async Task<T> CreateAsync(T entity) => (await dbSet.AddAsync(entity)).Entity;

    public async Task<T> DeleteAsync(T entity) => dbSet.Remove(entity).Entity;
    
    public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> exression = null) => exression == null ? dbSet : dbSet.Where(exression);

    public async Task<T> GetAsync(Expression<Func<T, bool>> expression) => await dbSet.FirstOrDefaultAsync(expression);
    
    public async Task<T> UpdateAsync(T entity) => dbSet.Update(entity).Entity;
 

  }
}
