using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookManagementSystem.API.Migrations
{
    /// <inheritdoc />
    public partial class AddGenreColumnToBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Books",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Genre", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "F. Scott Fitzgerald", "Fiction", "The Great Gatsby", 1925 },
                    { 2, "Harper Lee", "Fiction", "To Kill a Mockingbird", 1960 },
                    { 3, "George Orwell", "Dystopian", "1984", 1949 },
                    { 4, "Jane Austen", "Romance", "Pride and Prejudice", 1813 },
                    { 5, "J.D. Salinger", "Fiction", "The Catcher in the Rye", 1951 },
                    { 6, "Herman Melville", "Adventure", "Moby-Dick", 1851 },
                    { 7, "J.R.R. Tolkien", "Fantasy", "The Hobbit", 1937 },
                    { 8, "Eric Ries", "Business", "The Lean Startup", 2011 },
                    { 9, "Yuval Noah Harari", "Non-Fiction", "Sapiens: A Brief History of Humankind", 2011 },
                    { 10, "Michelle Obama", "Biography", "Becoming", 2018 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Books");
        }
    }
}
