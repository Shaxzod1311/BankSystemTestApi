
using BankSystemTest.Domain.Base;
using BankSystemTest.Domain.Entities;
using BankSystemTest.Service.DTOs;
using BankSystemTest.Service.Interfaces;
using BankSystemTest.Service.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace BankSystemTestApi.Controllers
{
  [ApiController]
  [Route("Api[controller]")]
  public class PaymentController : ControllerBase
  {
    private readonly IPaymentService paymentService;

    public PaymentController(IPaymentService paymentService)
    {
      this.paymentService = paymentService;
    }

    [HttpPost("InvoiceId")]
    public async Task<ActionResult<BaseResponse<PaymentViewModel>>> Create(int InvoiceId)
    {
      return await paymentService.CreateAsync(InvoiceId);
    }
    
    [HttpGet("Id")]
    public async Task<IActionResult> Get(int id)
    {
      return Ok(await paymentService.Get(id));
    }
  }
}
