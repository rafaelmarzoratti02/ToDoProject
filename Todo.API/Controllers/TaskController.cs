using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers;

    [ApiController]
    [Route("task")]
    public class TaskController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { message = "Task endpoint is working." });
        }
    }
