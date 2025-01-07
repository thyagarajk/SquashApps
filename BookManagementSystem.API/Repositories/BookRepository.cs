using BookManagementSystem.API.Data;
using BookManagementSystem.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BookManagementSystem.API.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookDbContext _context;

        public BookRepository(BookDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync() => await _context.Books.ToListAsync();

        public async Task<Book> GetBookByIdAsync(int id) => await _context.Books.FindAsync(id);

        public async Task AddBookAsync(Book book)
        {
            Console.WriteLine($"Adding book: {book.Title}, {book.Author}, {book.PublishedYear}");
            _context.Books.Add(book);
            // await _context.SaveChangesAsync();
            var changes = await _context.SaveChangesAsync();
            Console.WriteLine($"{changes} changes saved to the database.");
        }

        public async Task UpdateBookAsync(Book book)
        {
            _context.Books.Update(book);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBookAsync(int id)
        {
            var book = await _context.Books.FindAsync(id);
            if (book != null)
            {
                _context.Books.Remove(book);
                await _context.SaveChangesAsync();
            }
        }
    }
}
