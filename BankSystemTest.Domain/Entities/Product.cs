using BankSystemTest.Domain.Base;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankSystemTest.Domain.Entities
{
  public class Product : BaseEntity
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Photo { get; set; }

    [JsonIgnore]
    public int CategoryId { get; set; }


    [ForeignKey(nameof(CategoryId))]
    public virtual Category Category { get; set; }
  }
}
