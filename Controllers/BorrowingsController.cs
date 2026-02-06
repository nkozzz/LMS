namespace LMS.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class BorrowingsController : ControllerBase //gives you helper methods like Ok(), BadRequest(), etc.
    {
        // GET: /borrowings
        [HttpGet]
        public IActionResult /*Return Type*/ GetAllBorrowings()
        {
            //Sending 200 success with the string
            return Ok("Returning all borrowings" );
        }

        // GET: /borrowings/5
        [HttpGet("{id}")]
        public IActionResult GetBorrowingById(int id)
        {
            return Ok($"Returning borrowing with ID {id}");
        }

        // POST: /borrowings
        [HttpPost]
        public IActionResult CreateBorrowing([FromBody] object borrowing) //Tells the program to take the JSON and map it into this parameter, so we can easily access it in the function
        {
            return Ok("Borrowing created successfully" );
        }

        // PUT: /borrowings/5
        [HttpPut("{id}")]
        public IActionResult UpdateBorrowing(int id, [FromBody] object borrowing)
        {
            return Ok($"Borrowing with ID {id} updated");
        }

        // DELETE: /borrowings/5
        [HttpDelete("{id}")]
        public IActionResult DeleteBorrowing(int id)
        {
            return Ok($"Borrowing with ID {id} deleted");
        }
    }
}
