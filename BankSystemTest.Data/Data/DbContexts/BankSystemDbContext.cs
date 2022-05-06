using BankSystemTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BankSystemTest.Data.Data.DbContexts
{
  public class BankSystemDbContext : DbContext
  {
    public BankSystemDbContext(DbContextOptions<BankSystemDbContext> options)
      : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<Invoice> Invoices { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Detail> Details { get; set; }
  }
}
