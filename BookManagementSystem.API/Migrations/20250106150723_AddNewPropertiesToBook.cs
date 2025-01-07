using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookManagementSystem.API.Migrations
{
    /// <inheritdoc />
    public partial class AddNewPropertiesToBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "DiscountPercentage",
                table: "Books",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "FinalPrice",
                table: "Books",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Books",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "PublishedYear",
                table: "Books",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Rating",
                table: "Books",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DiscountPercentage", "FinalPrice", "Price", "PublishedYear", "Rating" },
                values: new object[] { 10.0, 9.8900000000000006, 10.99m, 0, 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DiscountPercentage", "FinalPrice", "Price", "PublishedYear", "Rating" },
                values: new object[] { 15.0, 11.039999999999999, 12.99m, 0, 4.9000000000000004 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DiscountPercentage", "FinalPrice", "Price", "PublishedYear", "Rating" },
                values: new object[] { 20.0, 11.99, 14.99m, 0, 4.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DiscountPercentage", "FinalPrice", "Price", "PublishedYear", "Rating" },
                values: new object[] { 5.0, 8.5399999999999991, 8.99m, 0, 4.5999999999999996 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DiscountPercentage", "FinalPrice", "Price", "PublishedYear", "Rating" },
                values: new object[] { 10.0, 8.9900000000000002, 9.99m, 0, 4.5 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DiscountPercentage", "FinalPrice", "Price", "PublishedYear", "Rating" },
                values: new object[] { 0.0, 11.99, 11.99m, 0, 4.2999999999999998 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DiscountPercentage", "FinalPrice", "Price", "PublishedYear", "Rating" },
                values: new object[] { 10.0, 14.390000000000001, 15.99m, 0, 4.9000000000000004 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DiscountPercentage", "FinalPrice", "Price", "PublishedYear", "Rating" },
                values: new object[] { 25.0, 14.99, 19.99m, 0, 4.7999999999999998 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DiscountPercentage", "FinalPrice", "Price", "PublishedYear", "Rating" },
                values: new object[] { 30.0, 16.09, 22.99m, 0, 4.7000000000000002 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DiscountPercentage", "FinalPrice", "Price", "PublishedYear", "Rating" },
                values: new object[] { 20.0, 19.989999999999998, 24.99m, 0, 4.9000000000000004 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountPercentage",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "FinalPrice",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "PublishedYear",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Books");
        }
    }
}
