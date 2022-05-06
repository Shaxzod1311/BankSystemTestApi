using BankSystemTest.Data.IRepositories;
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
  public class OrderService : IOrderService
  {
    private readonly IUnitOfWork unitOfWork;

    public OrderService(IUnitOfWork unitOfWork)
    {
      this.unitOfWork = unitOfWork;
    }
    
    public async Task<BaseResponse<int>> Create(OrderViewModel orderViewModel)
    {
      BaseResponse<int> response = new BaseResponse<int>();

      Order order = new Order()
      {
        CustomerId = orderViewModel.CustomerId,
        Date = DateTime.Now
      };

      var OrderResult = await unitOfWork.Orders.CreateAsync(order);

      await unitOfWork.SaveChangesAsync();

      Detail detail = new Detail() 
      {
        OrderId = OrderResult.Id,
        ProductId = orderViewModel.ProductId,
        Quantity = orderViewModel.Quantity
      };

      var detailResult = await unitOfWork.Details.CreateAsync(detail);
      await unitOfWork.SaveChangesAsync();
      var product = await unitOfWork.Products.GetAsync(p => p.Id == orderViewModel.ProductId);
      decimal tem = new decimal(orderViewModel.Quantity);
      Invoice invoice = new Invoice()
      {
        OrderId = OrderResult.Id,
        Amount = tem * product.Price,
        Due = DateTime.Now.AddDays(7),
        Issued = DateTime.Now
      };
      await unitOfWork.Invoices.CreateAsync(invoice);
      await unitOfWork.SaveChangesAsync();
      
      var invoiceResult = await unitOfWork.Orders.GetOrderInvoice(OrderResult.Id);

      if (invoiceResult != null)
      {
        response.Data = invoiceResult.Id;
        response.Status = "Success";
        return response;
      }

      response.Status = "Failed";
      return response;
    }


      public Task<Order> Get(int id)
    {
      return unitOfWork.Orders.GetAsync(ord => ord.Id == id);
    }
  }
}
