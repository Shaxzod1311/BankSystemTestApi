using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemTest.Service.DTOs
{
  public class PaymentViewModel
  {
    public int Id { get; set; }
    public DateTime Time { get; set; } = DateTime.Now;
    
    public decimal Amount { get; set; }
    
    public int InvoiceId { get; set; }
  }
}
