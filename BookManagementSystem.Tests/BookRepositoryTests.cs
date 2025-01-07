using BookManagementSystem.API.Data;
using BookManagementSystem.API.Models;
using BookManagementSystem.API.Repositories;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BookManagementSystem.Tests
{
    public class BookRepositoryTests
    {
        private readonly BookRepository _repository;

        public BookRepositoryTests()
        {
            // Initialize the in-memory database for each test
            var options = new DbContextOptionsBuilder<BookDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()) // Unique database name for each test
                .Options;

            using (var context = new BookDbContext(options))
            {
                // Initialize the repository with the in-memory context
                _repository = new BookRepository(context);
            }
        }

        [Fact]
        public async Task GetAllBooksAsync_ReturnsBooks_FromDbContext()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<BookDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()) // Unique database name for each test
                .Options;

            using (var context = new BookDbContext(options))
            {
                var books = new List<Book>
                 {
        new Book { Id = 1, Title = "Book 1", Author = "Author 1", Genre = "Fiction", PublishedYear = 2021, Price = 100, DiscountPercentage = 10, FinalPrice = 90, Rating = 4.5 },
        new Book { Id = 2, Title = "Book 2", Author = "Author 2", Genre = "Non-Fiction", PublishedYear = 2020, Price = 150, DiscountPercentage = 15, FinalPrice = 127.5, Rating = 4.8 }
    };

                context.Books.AddRange(books);
                await context.SaveChangesAsync();

                var repository = new BookRepository(context);

                // Act
                var result = await repository.GetAllBooksAsync();

                // Assert
                Assert.Equal(2, result.Count());
            }
        }

        [Fact]
        public async Task GetBookByIdAsync_ReturnsNull_WhenBookNotFound()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<BookDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()) // Unique database name for each test
                .Options;

            using (var context = new BookDbContext(options))
            {
                var repository = new BookRepository(context);

                // Act
                var result = await repository.GetBookByIdAsync(100);

                // Assert
                Assert.Null(result);
            }
        }

        [Fact]
        public async Task AddBookAsync_AddsBook_ToDbContext()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<BookDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()) // Unique database name for each test
                .Options;

            using (var context = new BookDbContext(options))
            {
                var book = new Book
                {
                    Id = 1,
                    Title = "Book 1",
                    Author = "Author 1",
                    Genre = "Fiction",
                    PublishedYear = 2021,
                    Price = 100,
                    DiscountPercentage = 10,
                    FinalPrice = 90,
                    Rating = 4.5
                };
      

                var repository = new BookRepository(context);

                // Act
                await repository.AddBookAsync(book);

                // Assert
                var addedBook = await context.Books.FindAsync(1);
                Assert.NotNull(addedBook);
                Assert.Equal("Book 1", addedBook.Title);
            }
        }

        [Fact]
        public async Task UpdateBookAsync_UpdatesBook_InDbContext()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<BookDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()) // Unique database name for each test
                .Options;

            using (var context = new BookDbContext(options))
            {
                var book = new Book
                {
                    Id = 1,
                    Title = "Book 1",
                    Author = "Author 1",
                    Genre = "Fiction",
                    PublishedYear = 2021,
                    Price = 100,
                    DiscountPercentage = 10,
                    FinalPrice = 90,
                    Rating = 4.5
                };
                context.Books.Add(book);
                await context.SaveChangesAsync();

                var repository = new BookRepository(context);

                // Modify book details
                book.Title = "Updated Title";

                // Act
                await repository.UpdateBookAsync(book);

                // Assert
                var updatedBook = await context.Books.FindAsync(1);
                Assert.Equal("Updated Title", updatedBook.Title);
            }
        }

        [Fact]
        public async Task DeleteBookAsync_DeletesBook_FromDbContext()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<BookDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString()) // Unique database name for each test
                .Options;

            using (var context = new BookDbContext(options))
            {
                var book = new Book
                {
                    Id = 1,
                    Title = "Book 1",
                    Author = "Author 1",
                    Genre = "Fiction",
                    PublishedYear = 2021,
                    Price = 100,
                    DiscountPercentage = 10,
                    FinalPrice = 90,
                    Rating = 4.5
                };
                context.Books.Add(book);
                await context.SaveChangesAsync();

                var repository = new BookRepository(context);

                // Act
                await repository.DeleteBookAsync(1);

                // Assert
                var deletedBook = await context.Books.FindAsync(1);
                Assert.Null(deletedBook); // Ensure the book was deleted
            }
        }
    }
}
