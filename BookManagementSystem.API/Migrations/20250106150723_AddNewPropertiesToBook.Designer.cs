﻿// <auto-generated />
using BookManagementSystem.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookManagementSystem.API.Migrations
{
    [DbContext(typeof(BookDbContext))]
    [Migration("20250106150723_AddNewPropertiesToBook")]
    partial class AddNewPropertiesToBook
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("BookManagementSystem.API.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("DiscountPercentage")
                        .HasColumnType("REAL");

                    b.Property<double>("FinalPrice")
                        .HasColumnType("REAL");

                    b.Property<string>("Genre")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("PublishedYear")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Rating")
                        .HasColumnType("REAL");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "F. Scott Fitzgerald",
                            DiscountPercentage = 10.0,
                            FinalPrice = 9.8900000000000006,
                            Genre = "Fiction",
                            Price = 10.99m,
                            PublishedYear = 0,
                            Rating = 4.7000000000000002,
                            Title = "The Great Gatsby",
                            Year = 1925
                        },
                        new
                        {
                            Id = 2,
                            Author = "Harper Lee",
                            DiscountPercentage = 15.0,
                            FinalPrice = 11.039999999999999,
                            Genre = "Fiction",
                            Price = 12.99m,
                            PublishedYear = 0,
                            Rating = 4.9000000000000004,
                            Title = "To Kill a Mockingbird",
                            Year = 1960
                        },
                        new
                        {
                            Id = 3,
                            Author = "George Orwell",
                            DiscountPercentage = 20.0,
                            FinalPrice = 11.99,
                            Genre = "Dystopian",
                            Price = 14.99m,
                            PublishedYear = 0,
                            Rating = 4.7999999999999998,
                            Title = "1984",
                            Year = 1949
                        },
                        new
                        {
                            Id = 4,
                            Author = "Jane Austen",
                            DiscountPercentage = 5.0,
                            FinalPrice = 8.5399999999999991,
                            Genre = "Romance",
                            Price = 8.99m,
                            PublishedYear = 0,
                            Rating = 4.5999999999999996,
                            Title = "Pride and Prejudice",
                            Year = 1813
                        },
                        new
                        {
                            Id = 5,
                            Author = "J.D. Salinger",
                            DiscountPercentage = 10.0,
                            FinalPrice = 8.9900000000000002,
                            Genre = "Fiction",
                            Price = 9.99m,
                            PublishedYear = 0,
                            Rating = 4.5,
                            Title = "The Catcher in the Rye",
                            Year = 1951
                        },
                        new
                        {
                            Id = 6,
                            Author = "Herman Melville",
                            DiscountPercentage = 0.0,
                            FinalPrice = 11.99,
                            Genre = "Adventure",
                            Price = 11.99m,
                            PublishedYear = 0,
                            Rating = 4.2999999999999998,
                            Title = "Moby-Dick",
                            Year = 1851
                        },
                        new
                        {
                            Id = 7,
                            Author = "J.R.R. Tolkien",
                            DiscountPercentage = 10.0,
                            FinalPrice = 14.390000000000001,
                            Genre = "Fantasy",
                            Price = 15.99m,
                            PublishedYear = 0,
                            Rating = 4.9000000000000004,
                            Title = "The Hobbit",
                            Year = 1937
                        },
                        new
                        {
                            Id = 8,
                            Author = "Eric Ries",
                            DiscountPercentage = 25.0,
                            FinalPrice = 14.99,
                            Genre = "Business",
                            Price = 19.99m,
                            PublishedYear = 0,
                            Rating = 4.7999999999999998,
                            Title = "The Lean Startup",
                            Year = 2011
                        },
                        new
                        {
                            Id = 9,
                            Author = "Yuval Noah Harari",
                            DiscountPercentage = 30.0,
                            FinalPrice = 16.09,
                            Genre = "Non-Fiction",
                            Price = 22.99m,
                            PublishedYear = 0,
                            Rating = 4.7000000000000002,
                            Title = "Sapiens: A Brief History of Humankind",
                            Year = 2011
                        },
                        new
                        {
                            Id = 10,
                            Author = "Michelle Obama",
                            DiscountPercentage = 20.0,
                            FinalPrice = 19.989999999999998,
                            Genre = "Biography",
                            Price = 24.99m,
                            PublishedYear = 0,
                            Rating = 4.9000000000000004,
                            Title = "Becoming",
                            Year = 2018
                        });
                });
#pragma warning restore 612, 618
        }
    }
}