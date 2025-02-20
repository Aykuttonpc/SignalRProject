using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            var value = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());
            return Ok(value);
        }

        [HttpGet("ProductListWithCategory")]
        public IActionResult ProductListWithCategory()
        {
            var context = new SignalRContext();
            var values = context.Products.Include(x=>x.Category).Select(y => new ResultProductWithCategoryDto()
            {
                ProductId = y.ProductId,
                Descripton = y.Descripton,
                ImageUrl = y.ImageUrl,
                Price = y.Price,
                ProductName = y.ProductName,
                ProductStatus = y.ProductStatus,
                CategoryName = y.Category.CategoryName

            });
            return Ok(values.ToList());

        }
        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            _productService.TAdd(new Product()
            {
                Descripton = createProductDto.Descripton,
                ImageUrl = createProductDto.ImageUrl,
                Price = createProductDto.Price,
                ProductName = createProductDto.ProductName,
                ProductStatus = createProductDto.ProductStatus,
                CategoryId = createProductDto.CategoryId


            });
            return Ok("Ürün Bilgisi Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetById(id);
            _productService.TDelete(value);
            return Ok("Ürün Bilgisi Silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            _productService.TUpdate(new Product()
            {
                CategoryId = updateProductDto.CategoryId,
                ProductId = updateProductDto.ProductId,
                Descripton = updateProductDto.Descripton,
                ImageUrl = updateProductDto.ImageUrl,
                Price = updateProductDto.Price,
                ProductName = updateProductDto.ProductName,
                ProductStatus = updateProductDto.ProductStatus

            });
            return Ok("Ürün Bilgisi Güncellendi");
        }

    }
}
