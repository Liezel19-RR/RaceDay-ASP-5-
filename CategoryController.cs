using Microsoft.AspNetCore.Mvc;

namespace RaceDay.API.Controllers
{
    [Route("api")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        [HttpGet("events/{eventId}/categories")]
        public IActionResult GetEventCategories(int eventId) => Ok();

        [HttpPost("events/{eventId}/categories")]
        public IActionResult CreateCategory(int eventId) => Ok();

        [HttpPut("categories/{id}")]
        public IActionResult UpdateCategory(int id) => Ok();

        [HttpDelete("categories/{id}")]
        public IActionResult DeleteCategory(int id) => Ok();
    }
}