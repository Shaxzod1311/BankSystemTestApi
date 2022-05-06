using BankSystemTest.Domain.Base;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankSystemTest.Domain.Entities
{
  public class Payment : BaseEntity
  {
    public DateTime Time { get; set; }
    public decimal Amount { get; set; }
    
    [JsonIgnore]
    public int InvoiceId { get; set; }

    [ForeignKey(nameof(InvoiceId))]
    [JsonIgnore]
    public virtual Invoice Invoice { get; set; }
  }
}
