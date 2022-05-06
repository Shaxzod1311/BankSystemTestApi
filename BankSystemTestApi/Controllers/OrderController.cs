using BankSystemTest.Domain.Base;
using BankSystemTest.Domain.Entities;
using BankSystemTest.Service.DTOs;
using BankSystemTest.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BankSystemTestApi.Controllers
{

  [ApiController]
  [Route("Api[controller]")]
  public class OrderController : ControllerBase
  {
    private readonly IOrderService orderService;

    public OrderController(IOrderService orderService)
    {
      this.orderService = orderService;
    }

    [HttpPost]
    public async Task<ActionResult<BaseResponse<int>>> Create(OrderViewModel orderViewModel)
    {
      return await orderService.Create(orderViewModel);
    }

    [HttpGet("id")]
    public async Task<IActionResult> Get(int id)
    {
      var result = await orderService.Get(id);
      return Ok(result);
    }
  }
}
