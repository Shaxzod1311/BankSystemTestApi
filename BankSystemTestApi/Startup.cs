using BankSystemTest.Data.Data.DbContexts;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using BankSystemTest.Data.IRepositories;
using BankSystemTest.Data.Repositories;
using BankSystemTest.Service.Interfaces;
using BankSystemTest.Service.Services;
using BankSystemTest.Domain.Entities;
using BankSystemTest.Domain.Base;

namespace BankSystemTestApi
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddDbContext<BankSystemDbContext>(options
        => options.UseNpgsql(Configuration.GetConnectionString("BankSystConnectionString")));

      services.AddControllers();
      services.AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "BankSystemTestApi", Version = "v1" });
      });
      services.AddMvc().AddNewtonsoftJson();

      services.AddScoped<IUnitOfWork, UnitOfWork>();
      services.AddScoped<ICategoryService, CategoryService>();
      services.AddScoped<IProductService, ProductService>();
      services.AddScoped<IPaymentService, PaymentService>();
      services.AddScoped<IOrderService, OrderService>();
      services.AddScoped<BaseResponse<Invoice>>();
      services.AddScoped<BaseResponse<Payment>>();
      
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
        app.UseSwagger();
        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BankSystemTestApi v1"));
      }

      app.UseHttpsRedirection();

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
    }
  }
}
