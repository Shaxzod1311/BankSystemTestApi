using BankSystemTest.Domain.Base;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankSystemTest.Domain.Entities
{
  public class Invoice : BaseEntity
  {
    public Invoice() => Payments = new HashSet<Payment>();

    [JsonIgnore]
    public int OrderId { get; set; }

    [ForeignKey(nameof(OrderId))]
    [JsonIgnore]
    public virtual Order Order { get; set; }
    
    public decimal Amount { get; set; }
    public DateTime Issued { get; set; }
    public DateTime Due { get; set; }

    [JsonIgnore]
    public virtual ICollection<Payment> Payments { get; set; }
  }
}
