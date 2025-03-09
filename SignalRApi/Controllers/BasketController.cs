using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DtoLayer.BasketDto;
using SignalR.EntityLayer.Entities;
using SignalRApi.Models;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _basketService;

        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [HttpGet]
        public IActionResult GetBasketByMenuTableId(int id)
        {
            var result = _basketService.TGetBasketByTableNumber(id);
            return Ok(result);
            
        }

        [HttpGet("BasketListByMenuTableWithProductName")]
        public IActionResult BasketListByMenuTableWithProductName(int id)
        {
            using var context = new SignalRContext();
            var values = context.Baskets
                .Include(x => x.Product) // Include the related Product navigation property
                .Where(y => y.MenuTableId == id) // Apply the filter
                .Select(z => new ResultBasketListWithProducts
                {
                    BasketId = z.BasketId,
                    Price = z.Price,
                    Count = z.Count,
                    TotalPrice = z.TotalPrice,
                    ProductId = z.ProductId,
                    MenuTableId = z.MenuTableId,
                    ProductName = z.Product.ProductName // Access the ProductName from the included Product
                })
                .ToList();

            return Ok(values);
        }
        [HttpPost]
        public IActionResult CreateBasket(CreateBasketDto createBasketDto)
        {
            using var context = new SignalRContext();
            _basketService.TAdd(new Basket()
            {

                ProductId = createBasketDto.ProductId,
                MenuTableId = 1,
                Count = 1,
                Price = context.Products.Where(x => x.ProductId == createBasketDto.ProductId).Select(x => x.Price).FirstOrDefault(),
                TotalPrice = 0,

            });
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteBasket(int id)
        {
            var value = _basketService.TGetById(id);
            _basketService.TDelete(value);
            return Ok("Ürün Başarılı Bir Şekilde Silindi");
        }
    }
}
