using BankSystemTest.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BankSystemTestApi.Controllers
{
  [ApiController]
  [Route("Api[controller]")]
  public class ProductController : ControllerBase
  {
    private readonly IProductService productService;

    public ProductController(IProductService productService)
    {
      this.productService = productService;
    }
    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
      return Ok(await productService.GetAllAsync());
    }

    [HttpGet("Id")]
    public async Task<IActionResult> Get(int id)
    {
      return Ok(await productService.GetAsync(id));
    }
  }
}
