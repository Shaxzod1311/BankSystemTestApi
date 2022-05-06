using BankSystemTest.Domain.Base;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BankSystemTest.Domain.Entities
{
  public class Category : BaseEntity
  {
    public Category() => Products = new HashSet<Product>();
    public string Name { get; set; }

    [JsonIgnore]
    public virtual ICollection<Product> Products { get; }
  }
}
