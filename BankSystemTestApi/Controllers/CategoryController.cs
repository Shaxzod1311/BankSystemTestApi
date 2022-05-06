using BankSystemTest.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;

namespace BankSystemTestApi.Controllers
{
  [ApiController]
  [Route("Api/[controller]")]
  public class CategoryController : ControllerBase
  {
    private readonly ICategoryService categoryService;

    public CategoryController(ICategoryService categoryService)
    {
      this.categoryService = categoryService;
    }
    
    [HttpGet]
    public async Task<IActionResult> Get()
    {
      return Ok(await categoryService.GetAllAsync());
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
      var result = await categoryService.GetAsync(id);
      
      return Ok(result);
    }
  }
}
