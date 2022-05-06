using BankSystemTest.Data.Data.DbContexts;
using BankSystemTest.Data.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemTest.Data.Repositories
{
  public class UnitOfWork : IUnitOfWork
  {
    private readonly BankSystemDbContext dbContext;

    public UnitOfWork(BankSystemDbContext dbContext)
    {
      this.dbContext = dbContext;

      Products = new ProductRepository(dbContext);
      Categories = new CategoryRepository(dbContext);
      Invoices = new InvoiceRepository(dbContext);
      Orders = new OrderRepository(dbContext);
      Details = new DetailRepository(dbContext);
      Customers = new CustomerRepository(dbContext);
      Payments = new PaymentRepository(dbContext);
    }

    public IProductRepository Products { get; }

    public ICategoryRepository Categories { get; }

    public IInvoiceRepository Invoices { get; }

    public IOrderRepository Orders { get; }

    public IDetailRepository Details { get; }

    public ICustomerRepository Customers { get; }

    public IPaymentRepository Payments { get; }

    public void Dispose()
    {
      GC.SuppressFinalize(this);
    }

    public async Task SaveChangesAsync()
    {
      await dbContext.SaveChangesAsync();
    }
  }
}
