using BookManagementSystem.UIWebApp.Models;
using BookManagementSystem.UIWebApp.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookManagementSystem.UIWebApp.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly BookApiService _bookApiService;

        public List<Book> Books { get; set; } = new();

        public IndexModel(BookApiService bookApiService)
        {
            _bookApiService = bookApiService;
        }

        public async Task OnGetAsync()
        {
            Books = await _bookApiService.GetAllBooksAsync();
        }
    }
}
