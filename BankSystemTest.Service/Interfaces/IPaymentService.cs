using BankSystemTest.Domain.Base;
using BankSystemTest.Domain.Entities;
using BankSystemTest.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemTest.Service.Interfaces
{
  public interface IPaymentService
  {
    public Task<BaseResponse<PaymentViewModel>> CreateAsync(int InvoiceId);
    public Task<Payment> Get(int id);
  }
}
