using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.API.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100)]
        public string Title { get; set; }

        [Required(ErrorMessage = "Author is required")]
        [StringLength(100)]
        public string Author { get; set; }

        [Range(1000, 9999, ErrorMessage = "Year must be valid")] // Year should be within 1000-9999
        public int PublishedYear { get; set; }

        [Required(ErrorMessage = "Genre is required")] // Genre is required for API as well
        public string Genre { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = "Price must be greater than zero")]
        public decimal Price { get; set; }

        [Range(0, 100, ErrorMessage = "Discount percentage must be between 0 and 100")]
        public double DiscountPercentage { get; set; }

        [Range(0, 5, ErrorMessage = "Rating must be between 0 and 5")]
        public double Rating { get; set; }

        public double FinalPrice { get; set; } // Final price can be calculated in the API

    }
}
