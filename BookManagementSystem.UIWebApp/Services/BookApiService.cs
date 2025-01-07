using BookManagementSystem.UIWebApp.Models;

namespace BookManagementSystem.UIWebApp.Services
{
    public class BookApiService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiBaseUrl;

        public BookApiService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _apiBaseUrl = configuration.GetValue<string>("ApiSettings:BaseUrl");
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Book>>($"{_apiBaseUrl}/book");
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Book>($"{_apiBaseUrl}/book/{id}");
        }

        public async Task AddBookAsync(Book book)
        {
            await _httpClient.PostAsJsonAsync($"{_apiBaseUrl}/book", book);
        }

        public async Task UpdateBookAsync(Book book)
        {
            await _httpClient.PutAsJsonAsync($"{_apiBaseUrl}/book/{book.Id}", book);
        }

        public async Task DeleteBookAsync(int id)
        {
            await _httpClient.DeleteAsync($"{_apiBaseUrl}/book/{id}");
        }
    }
}
