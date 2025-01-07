using BookManagementSystem.API.Models;
using BookManagementSystem.API.Repositories;

namespace BookManagementSystem.API.Services
{
    public class BookService:IBookService
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync() => await _repository.GetAllBooksAsync();

        public async Task<Book> GetBookByIdAsync(int id) => await _repository.GetBookByIdAsync(id);

        public async Task AddBookAsync(Book book) => await _repository.AddBookAsync(book);

        public async Task UpdateBookAsync(Book book) => await _repository.UpdateBookAsync(book);

        public async Task DeleteBookAsync(int id) => await _repository.DeleteBookAsync(id);

    }
}
