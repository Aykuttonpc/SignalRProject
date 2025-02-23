using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalR.BusinessLayer.Abstract;
using SignalR.DtoLayer.CategoryDto;
using SignalR.EntityLayer.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult CategoryList()
        {
            var value = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            _categoryService.TAdd(new Category()
            {
                CategoryName = createCategoryDto.CategoryName,
                Status = createCategoryDto.Status
            });
            return Ok("Kategori Eklendi");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var value = _categoryService.TGetById(id);
            _categoryService.TDelete(value);
            return Ok("Kategori Silindi");
        }
        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var value  = _categoryService.TGetById(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            _categoryService.TUpdate(new Category()
            {
                CategoryId = updateCategoryDto.CategoryId,
                CategoryName = updateCategoryDto.CategoryName,
                Status = updateCategoryDto.Status
            });
            return Ok("Kategori Güncellendi");
        }
        [HttpGet("CategoryCount")]
        public IActionResult CategoryCount()
        {
            return Ok(_categoryService.TCategoryCount());
        }

        [HttpGet("ActiveCategoryCount")]
        public IActionResult ActiveCategoryCount()
        {
            return Ok(_categoryService.TActiveCategoryCount());
        }
        [HttpGet("PassiveCategoryCount")]
        public IActionResult PassiveCategoryCount()
        {
            return Ok(_categoryService.TPassiveCategoryCount());
        }

    }
}
