using BankSystemTest.Domain.Base;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankSystemTest.Domain.Entities
{
  public class Order : BaseEntity
  {
    public DateTime Date { get; set; }

    [JsonIgnore]
    public int CustomerId { get; set; }

    [ForeignKey(nameof(CustomerId))]
    public virtual Customer Customer { get; set; }
    public virtual Invoice Invoice { get; set; }
    public virtual Detail Detail { get; set; }
  }
}
