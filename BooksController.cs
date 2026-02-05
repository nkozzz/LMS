namespace LMS
{
    using Microsoft.AspNetCore.Mvc;

    //This tells ASP.NET: This class handles API requests
    [ApiController]
    [Route("/[controller]")]
    public class BooksController : ControllerBase //gives you helper methods like Ok(), BadRequest(), etc.
    {
        // GET: /books
        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok("Returning all books" );
        }

        // GET: /books/5
        [HttpGet("{id}")]
        public IActionResult GetBookById(int id)
        {
            return Ok($"Returning book with ID {id}");
        }

        // POST: /books
        [HttpPost]
        public IActionResult CreateBook([FromBody] object book)
        {
            return Ok("Book created successfully");
        }

        // PUT: /books/5
        [HttpPut("{id}")]
        public IActionResult UpdateBook(int id, [FromBody] object book)
        {
            return Ok($"Book with ID {id} updated" );
        }

        // DELETE: /books/5
        [HttpDelete("{id}")]
        public IActionResult DeleteBook(int id)
        {
            return Ok($"Book with ID {id} deleted" );
        }
    }
}
