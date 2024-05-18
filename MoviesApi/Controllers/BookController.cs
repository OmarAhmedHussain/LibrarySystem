using LibrarySystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace LibrarySystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private ApplicationDbContext _context;

        public BookController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("GetAllBooks")]
        public async Task<IActionResult> GetAllBooks()
        {
            var b = await _context.Books.ToListAsync();
            return Ok(b);
        }

        [HttpGet("GetBookByID/{id}")]
        public async Task<IActionResult> GetBookByID(int id)
        {
            var b = await _context.Books.FirstOrDefaultAsync(g => g.ID == id);
            if (b == null)
                return NotFound("No book with this ID");

            return Ok(b);
        }

        [HttpPost("AddNewBook")]
        public async Task<IActionResult> AddNewBook(Book n)
        {
            Book b = new Book();
            b.Title = n.Title;
            b.Author = n.Author;
            b.PublishYear = n.PublishYear;
            b.ISBN = n.ISBN;
            
            _context.Books.Add(b);
            _context.SaveChanges();

            return Ok(b);
        }

        [HttpPut("UpdateBook/{id}")]
        public async Task<IActionResult> EditBook(int id, [FromBody] Book n)
        {
            var b = _context.Books.FirstOrDefault(g => g.ID == id);
            
            if (b == null)
                return Ok("No book with this ID");

            b.Title = n.Title;
            b.Author = n.Author;
            b.PublishYear = n.PublishYear;
            b.ISBN = n.ISBN;

            _context.SaveChanges();
            return Ok(b);
        }

        [HttpDelete("DeleteBook/{id}")]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var b = _context.Books.FirstOrDefault(g => g.ID == id);

            if (b == null)
                return Ok("No book with this ID");

            _context.Books.Remove(b);
            _context.SaveChanges();
            return Ok(b);
        }
    }
}
