namespace BookManagementSystem.UIBlazor.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public int PublishedYear { get; set; }
        public decimal Price { get; set; }
        public float DiscountPercentage { get; set; }

        // Computed property for the final price after applying the discount
        public decimal FinalPrice => Price - (Price * (decimal)DiscountPercentage / 100);
    }
}
