using ETradeAPI.Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ETradeAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async void Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new(){ Id= Guid.NewGuid(),Name = "Product 5", Price = 500, CreatedDate= DateTime.Now, Stock = 10},
                new(){ Id= Guid.NewGuid(),Name = "Product 6", Price = 600, CreatedDate= DateTime.Now, Stock = 20},
                new(){ Id= Guid.NewGuid(),Name = "Product 7", Price = 700, CreatedDate= DateTime.Now, Stock = 30},

            });
            await _productWriteRepository.SaveAsync();
        }
    }
}
