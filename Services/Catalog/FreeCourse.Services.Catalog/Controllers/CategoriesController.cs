using FreeCourse.Services.Catalog.Dtos;
using FreeCourse.Services.Catalog.Services;
using FreeCourse.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FreeCourse.Services.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : CustomBaseController
    {
        private readonly ICategoryServices _categoryServices;

        public CategoriesController(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }

        public async Task<IActionResult> GetAll()
        {
            var response = await _categoryServices.GetAllAsync();

            return CreateActionResultInstance(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var response = await _categoryServices.GetByIdAsync(id);

            return CreateActionResultInstance(response);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryDto categoryDto)
        {
            var response = await _categoryServices.CreateAsync(categoryDto);

            return CreateActionResultInstance(response);
        }

    }
}
