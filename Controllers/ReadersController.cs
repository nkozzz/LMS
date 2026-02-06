namespace LMS.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class ReadersController : ControllerBase //gives you helper methods like Ok(), BadRequest(), etc.
    {
        // GET: /readers
        [HttpGet]
        public IActionResult GetAllReaders()
        {
            return Ok(new { message = "Returning all readers" });
        }

        // GET: /readers/5
        [HttpGet("{id}")]
        public IActionResult GetReaderById(int id)
        {
            return Ok($"Returning reader with ID {id}" );
        }

        // POST: /readers
        [HttpPost]
        public IActionResult CreateReader([FromBody] object reader)
        {
            return Ok("Reader created successfully" );
        }

        // PUT: /readers/5
        [HttpPut("{id}")]
        public IActionResult UpdateReader(int id, [FromBody] object reader)
        {
            return Ok($"Reader with ID {id} updated");
        }

        // DELETE: /readers/5
        [HttpDelete("{id}")]
        public IActionResult DeleteReader(int id)
        {
            return Ok($"Reader with ID {id} deleted" );
        }
    }
}
