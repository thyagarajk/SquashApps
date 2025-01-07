using BookManagementSystem.API.Controllers;
using BookManagementSystem.API.Models;
using BookManagementSystem.API.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Tests
{
    public class BookControllerTests
    {
        private readonly BookController _controller;
        private readonly Mock<IBookService> _serviceMock;

        public BookControllerTests()
        {
            _serviceMock = new Mock<IBookService>();
            _controller = new BookController(_serviceMock.Object);
        }

        [Fact]
        public async Task GetAllBooks_ReturnsOkResult_WithListOfBooks()
        {
            // Arrange
            var books = new List<Book>
        {
        new Book { Id = 1, Title = "Book 1", Author = "Author 1", Genre = "Fiction", PublishedYear = 2021, Price = 100, DiscountPercentage = 10, FinalPrice = 90, Rating = 4.5 },
        new Book { Id = 2, Title = "Book 2", Author = "Author 2", Genre = "Non-Fiction", PublishedYear = 2020, Price = 150, DiscountPercentage = 15, FinalPrice = 127.5, Rating = 4.8 }
    };
            _serviceMock.Setup(s => s.GetAllBooksAsync()).ReturnsAsync(books);

            // Act
            var result = await _controller.GetAllBooks();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnBooks = Assert.IsAssignableFrom<List<Book>>(okResult.Value);
            Assert.Equal(2, returnBooks.Count);
        }

        [Fact]
        public async Task GetBookById_ReturnsNotFound_WhenBookDoesNotExist()
        {
            // Arrange
            _serviceMock.Setup(s => s.GetBookByIdAsync(It.IsAny<int>())).ReturnsAsync((Book)null);

            // Act
            var result = await _controller.GetBookById(100);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task GetBookById_ReturnsOkResult_WithBook_WhenBookExists()
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


            _serviceMock.Setup(s => s.GetBookByIdAsync(1)).ReturnsAsync(book);

            // Act
            var result = await _controller.GetBookById(1);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnBook = Assert.IsType<Book>(okResult.Value);
            Assert.Equal(1, returnBook.Id);
            Assert.Equal("Book 1", returnBook.Title);
        }
    }

}
