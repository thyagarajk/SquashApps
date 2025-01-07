using System.ComponentModel.DataAnnotations;

namespace BookManagementSystem.UIWebApp.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string Author { get; set; }

        [Range(1000, 9999)] // Ensure the range for year is consistent
        public int PublishedYear { get; set; }

        [Range(1, double.MaxValue)] // Price must be positive
        public decimal Price { get; set; }

        [Range(0, 100)] // Discount should be between 0 and 100
        public int DiscountPercentage { get; set; }

        [Range(0, 5)] // Rating should be between 0 and 5
        public double Rating { get; set; }

        [Required] // Genre is required for the Web App
        public string Genre { get; set; }

        public double FinalPrice { get; set; } // This could be calculated in the UI
    }
}
