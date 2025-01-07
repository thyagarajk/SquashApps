using BookManagementSystem.API.Data;
using BookManagementSystem.API.Models;
using BookManagementSystem.API.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookManagementSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _service;

        public BookController(IBookService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBooks() => Ok(await _service.GetAllBooksAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookById(int id)
        {
            var book = await _service.GetBookByIdAsync(id);
            return book != null ? Ok(book) : NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> CreateBook([FromBody] Book bk)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var book = new Book
            {
                Title = bk.Title,
                Author = bk.Author,
                Genre = bk.Genre,
                PublishedYear = bk.PublishedYear,
                Price = bk.Price,
                DiscountPercentage = bk.DiscountPercentage,
                Rating = bk.Rating,
                FinalPrice = (double)(bk.Price - (bk.Price * Convert.ToDecimal((bk.DiscountPercentage / 100)))),
                
            };

            try
            {
                await _service.AddBookAsync(book);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
                return StatusCode(500, "Internal server error.");
            }

            return CreatedAtAction(nameof(GetBookById), new { id = book.Id }, book);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBook(int id, [FromBody] Book book)
        {
            if (id != book.Id) return BadRequest();
            book.FinalPrice = (double)(book.Price - (book.Price * Convert.ToDecimal((book.DiscountPercentage / 100))));
            await _service.UpdateBookAsync(book);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            await _service.DeleteBookAsync(id);
            return NoContent();
        }
    }
}
