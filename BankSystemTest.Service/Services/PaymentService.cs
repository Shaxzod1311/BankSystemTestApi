using BankSystemTest.Data.IRepositories;
using BankSystemTest.Data.Repositories;
using BankSystemTest.Domain.Base;
using BankSystemTest.Domain.Entities;
using BankSystemTest.Service.DTOs;
using BankSystemTest.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemTest.Service.Services
{
  public class PaymentService : IPaymentService
  {
    private readonly IUnitOfWork unitOfWork;

    public PaymentService(IUnitOfWork unitOfWork)
    {
      this.unitOfWork = unitOfWork;
    }
    public async Task<BaseResponse<PaymentViewModel>> CreateAsync(int InvoiceId)
    {
      BaseResponse<PaymentViewModel> response = new BaseResponse<PaymentViewModel>();
      var invoice = await unitOfWork.Invoices.GetAsync(inv => inv.Id == InvoiceId);
      
      Payment payment = new Payment()
      {
        InvoiceId = InvoiceId,
        Amount = invoice.Amount,
        Time = DateTime.Now
      };

      var result = await unitOfWork.Payments.CreateAsync(payment);

      await unitOfWork.SaveChangesAsync();

      PaymentViewModel model = new PaymentViewModel()
      {
        Id = result.Id,
        InvoiceId = result.InvoiceId,
        Time = DateTime.Now,
        Amount = result.Amount
      };

      
      if (result != null)
      {
        response.Status = "Success";
        response.Data = model;
        return response;
      }

      response.Status = "Failed";
      return response;
    }

    public async Task<Payment> Get(int id)
    {
      return await unitOfWork.Payments.GetAsync(pay => pay.Id == id);
    }
  }
}
