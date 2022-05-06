using BankSystemTest.Domain.Base;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankSystemTest.Domain.Entities
{
  public class Detail : BaseEntity
  {
    public int OrderId { get; set; }
    [ForeignKey(nameof(OrderId))]
    public virtual Order Order { get; set; }

    [JsonIgnore]
    public int ProductId { get; set; }
    [ForeignKey(nameof(ProductId))]
    public virtual Product Product { get; set; }
    public int Quantity { get; set; }
  }
}
