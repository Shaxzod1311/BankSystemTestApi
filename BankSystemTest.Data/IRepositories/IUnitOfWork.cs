using BankSystemTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemTest.Data.IRepositories
{

  public interface IUnitOfWork : IDisposable
  {
    public IProductRepository Products { get; }
    public ICategoryRepository Categories { get; }
    public IInvoiceRepository Invoices { get; }
    public IOrderRepository Orders { get; }
    public IDetailRepository Details { get; }
    public ICustomerRepository Customers { get; }
    public IPaymentRepository Payments { get; }
    
    Task SaveChangesAsync();
    }

}
