using BankSystemTest.Domain.Base;
using System.Collections.Generic;

namespace BankSystemTest.Domain.Entities
{
  public class Customer : BaseEntity
  {
    public Customer() => Orders = new HashSet<Order>();

    public string Name { get; set; }
    public string Country { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }

    public virtual ICollection<Order> Orders { get; set; }
  }
}
