namespace LMS.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Welcome to the Library Management System. Go to /swagger to test the endpoints."
            );
        }
    }
}
