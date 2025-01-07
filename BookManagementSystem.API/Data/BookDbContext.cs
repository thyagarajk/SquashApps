using BookManagementSystem.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BookManagementSystem.API.Data
{
    public class BookDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
    new Book { Id = 1, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", PublishedYear = 1925, Genre = "Fiction", Price = 10.99m, DiscountPercentage = 10, FinalPrice = 9.89, Rating = 4.7 },
    new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", PublishedYear = 1960, Genre = "Fiction", Price = 12.99m, DiscountPercentage = 15, FinalPrice = 11.04, Rating = 4.9 },
    new Book { Id = 3, Title = "1984", Author = "George Orwell", PublishedYear = 1949, Genre = "Dystopian", Price = 14.99m, DiscountPercentage = 20, FinalPrice = 11.99, Rating = 4.8 },
    new Book { Id = 4, Title = "Pride and Prejudice", Author = "Jane Austen", PublishedYear = 1813, Genre = "Romance", Price = 8.99m, DiscountPercentage = 5, FinalPrice = 8.54, Rating = 4.6 },
    new Book { Id = 5, Title = "The Catcher in the Rye", Author = "J.D. Salinger", PublishedYear = 1951, Genre = "Fiction", Price = 9.99m, DiscountPercentage = 10, FinalPrice = 8.99, Rating = 4.5 },
    new Book { Id = 6, Title = "Moby-Dick", Author = "Herman Melville", PublishedYear = 1851, Genre = "Adventure", Price = 11.99m, DiscountPercentage = 0, FinalPrice = 11.99, Rating = 4.3 },
    new Book { Id = 7, Title = "The Hobbit", Author = "J.R.R. Tolkien", PublishedYear = 1937, Genre = "Fantasy", Price = 15.99m, DiscountPercentage = 10, FinalPrice = 14.39, Rating = 4.9 },
    new Book { Id = 8, Title = "The Lean Startup", Author = "Eric Ries", PublishedYear = 2011, Genre = "Business", Price = 19.99m, DiscountPercentage = 25, FinalPrice = 14.99, Rating = 4.8 },
    new Book { Id = 9, Title = "Sapiens: A Brief History of Humankind", Author = "Yuval Noah Harari", PublishedYear = 2011, Genre = "Non-Fiction", Price = 22.99m, DiscountPercentage = 30, FinalPrice = 16.09, Rating = 4.7 },
    new Book { Id = 10, Title = "Becoming", Author = "Michelle Obama", PublishedYear = 2018, Genre = "Biography", Price = 24.99m, DiscountPercentage = 20, FinalPrice = 19.99, Rating = 4.9 }
);


        }

        public BookDbContext(DbContextOptions<BookDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
