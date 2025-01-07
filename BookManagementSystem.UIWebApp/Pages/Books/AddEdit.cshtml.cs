using BookManagementSystem.UIWebApp.Models;
using BookManagementSystem.UIWebApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookManagementSystem.UIWebApp.Pages.Books
{
    public class AddEditModel : PageModel
    {
        private readonly BookApiService _bookApiService;

        [BindProperty]
        public Book Book { get; set; } = new();

        public string PageTitle { get; private set; } = "Add/Edit Book";

        public AddEditModel(BookApiService bookApiService)
        {
            _bookApiService = bookApiService;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id.HasValue)
            {
                Book = await _bookApiService.GetBookByIdAsync(id.Value);
                if (Book == null)
                {
                    return NotFound();
                }
                PageTitle = "Edit Book";
            }
            else
            {
                PageTitle = "Add New Book";
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Book.Id > 0)
            {
                // Update existing book
                await _bookApiService.UpdateBookAsync(Book);
            }
            else
            {
                // Add new book
                await _bookApiService.AddBookAsync(Book);
            }

            return RedirectToPage("/Books/Index");
        }
    }
}
