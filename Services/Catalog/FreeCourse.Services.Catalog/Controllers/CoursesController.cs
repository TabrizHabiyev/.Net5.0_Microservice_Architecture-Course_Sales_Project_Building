using FreeCourse.Services.Catalog.Dtos;
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

        [Route("/api/[controller]GetAllByUserId/{userId}")]
        public async Task<IActionResult> GetAllByUserId(string userId)
        {
            var response = await _courseServices.GetAllByUserIdAsync(userId);

            return CreateActionResultInstance(response);
        }


        [HttpPost]
        public async Task<IActionResult> Create(CourseCreateDto courseCreateDto)
        {
            var response = await _courseServices.CreateAsync(courseCreateDto);

            return CreateActionResultInstance(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update(CourseUpdateDto courseCreateDto)
        {
            var response = await _courseServices.UpdateAsync(courseCreateDto);

            return CreateActionResultInstance(response);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var response = await _courseServices.DeleteAsync(id);

            return CreateActionResultInstance(response);
        }


    }
}
