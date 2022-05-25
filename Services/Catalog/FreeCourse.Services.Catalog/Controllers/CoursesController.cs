using FreeCourse.Services.Catalog.Models;
using FreeCourse.Services.Catalog.Services;
using FreeCourse.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FreeCourse.Services.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : CustomBaseController
    {
        private readonly ICourseServices _courseServices;

        public CoursesController(ICourseServices courseServices)
        {
            _courseServices = courseServices;
        }

        public async Task<IActionResult> GetAll()
        {
            var response = await _courseServices.GetAllAsync();

            return CreateActionResultInstance(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var response = await _courseServices.GetByIdAsync(id);

            return CreateActionResultInstance(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAllByUserId(string userId)
        {
            var response = await _courseServices.GetAllByUserId(userId);

            return CreateActionResultInstance(response);
        }

    }
}
