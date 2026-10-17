using Microsoft.AspNetCore.Mvc;

namespace RaceDay.API.Controllers
{
    [Route("api")]
    [ApiController]
    public class EnrolmentsController : ControllerBase
    {
        [HttpPost("events/{eventId}/enrol")]
        public IActionResult Enrol(int eventId) => Ok();

        [HttpGet("users/me/enrolments")]
        public IActionResult GetMyEnrolments() => Ok();
    }
}