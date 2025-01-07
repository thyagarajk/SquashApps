using BookManagementSystem.API.Data;
using BookManagementSystem.API.Models;
using BookManagementSystem.API.Repositories;
using BookManagementSystem.API.Services;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Tests
{
    public class BookServiceTests
    {
        private readonly BookDbContext _context;
        private readonly BookService _service;
        private readonly Mock<IBookRepository> _repositoryMock;

        public BookServiceTests()
        {
            // Set up the in-memory database
            var options = new DbContextOptionsBuilder<BookDbContext>()
                .UseInMemoryDatabase("TestDatabase")
                .Options;

            _context = new BookDbContext(options);
            _repositoryMock = new Mock<IBookRepository>();
            _service = new BookService(_repositoryMock.Object);
        }

        [Fact]
        public async Task GetAllBooksAsync_ReturnsAllBooks_FromRepository()
        {
            // Arrange
            var books = new List<Book>
        {
        new Book { Id = 1, Title = "Book 1", Author = "Author 1", Genre = "Fiction", PublishedYear = 2021, Price = 100, DiscountPercentage = 10, FinalPrice = 90, Rating = 4.5 },
        new Book { Id = 2, Title = "Book 2", Author = "Author 2", Genre = "Non-Fiction", PublishedYear = 2020, Price = 150, DiscountPercentage = 15, FinalPrice = 127.5, Rating = 4.8 }
    };
            _repositoryMock.Setup(r => r.GetAllBooksAsync()).ReturnsAsync(books);

            // Act
            var result = await _service.GetAllBooksAsync();

            // Assert
            Assert.Equal(2, result.Count());
        }

        [Fact]
        public async Task GetBookByIdAsync_ReturnsNull_WhenBookNotFound()
        {
            // Arrange
            _repositoryMock.Setup(r => r.GetBookByIdAsync(It.IsAny<int>())).ReturnsAsync((Book)null);

            // Act
            var result = await _service.GetBookByIdAsync(100);

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public async Task AddBookAsync_CallsAdd_OnRepository()
        {
            // Arrange
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

            // Act
            await _service.AddBookAsync(book);

            // Assert
            _repositoryMock.Verify(r => r.AddBookAsync(book), Times.Once);
        }

        [Fact]
        public async Task UpdateBookAsync_CallsUpdate_OnRepository()
        {
            // Arrange
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

            // Act
            await _service.UpdateBookAsync(book);

            // Assert
            _repositoryMock.Verify(r => r.UpdateBookAsync(book), Times.Once);
        }

        [Fact]
        public async Task DeleteBookAsync_CallsDelete_OnRepository()
        {
            // Arrange
            int bookId = 1;

            // Act
            await _service.DeleteBookAsync(bookId);

            // Assert
            _repositoryMock.Verify(r => r.DeleteBookAsync(bookId), Times.Once);
        }
    }
}
