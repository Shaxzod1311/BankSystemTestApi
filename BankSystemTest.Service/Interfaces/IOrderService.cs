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
  public interface IOrderService
  {
    public Task<BaseResponse<int>> Create(OrderViewModel order);
    public Task<Order> Get(int id);
  }
}
