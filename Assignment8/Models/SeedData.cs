using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                // if any pending migrations then migrate
                context.Database.Migrate();
            }
            if(!context.Books.Any())
            {
                // if no pending migrations populate the database with these entries
                context.Books.AddRange(

                    new Book
                    {
                        BookTitle = "Les Miserables",
                        AuthorFirstName = "Victor",
                        AuthorLastName = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        Price = 9.95F,
                        Pages = 1488
                    },

                    new Book
                    {
                        BookTitle = "Team of Rivals",
                        AuthorFirstName = "Doris Kearns",
                        AuthorLastName = "Goodwin",
                        Publisher = "Simon and Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 14.58F,
                        Pages = 944
                    },

                    new Book
                    {
                        BookTitle = "The Snowball",
                        AuthorFirstName = "Alice",
                        AuthorLastName = "Schroeder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 21.54F,
                        Pages = 832
                    },

                    new Book
                    {
                        BookTitle = "American Ulysses",
                        AuthorFirstName = "Ronald C.",
                        AuthorLastName = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        Price = 11.61F,
                        Pages = 864
                    },

                    new Book
                    {
                        BookTitle = "Unbroken",
                        AuthorFirstName = "Laura Hillenbrand",
                        AuthorLastName = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        Price = 13.33F,
                        Pages = 528
                    },

                    new Book
                    {
                        BookTitle = "The Great Train Robbery",
                        AuthorFirstName = "Michael",
                        AuthorLastName = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804171281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        Price = 15.95F,
                        Pages = 288
                    },

                    new Book
                    {
                        BookTitle = "Deep Work",
                        AuthorFirstName = "Cal",
                        AuthorLastName = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 14.99F,
                        Pages = 304
                    },

                    new Book
                    {
                        BookTitle = "It's Your Ship",
                        AuthorFirstName = "Michael",
                        AuthorLastName = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 21.66F,
                        Pages = 240
                    },

                    new Book
                    {
                        BookTitle = "The Virgin Way",
                        AuthorFirstName = "Richard",
                        AuthorLastName = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        Price = 29.16F,
                        Pages = 400
                    },

                    new Book
                    {
                        BookTitle = "Sycamore Row",
                        AuthorFirstName = "John",
                        AuthorLastName = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-0553393613",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        Price = 15.03F,
                        Pages = 642
                    },

                    new Book
                    {
                        BookTitle = "The 7 Habits of Highly Effective People",
                        AuthorFirstName = "Stephen R.",
                        AuthorLastName = "Covey",
                        Publisher = "Simon and Schuster",
                        ISBN = "978-1476740058",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        Price = 13.99F,
                        Pages = 381
                    },

                    new Book
                    {
                        BookTitle = "Harry Potter and The Deathly Hallows",
                        AuthorFirstName = "J. K.",
                        AuthorLastName = "Rowling",
                        Publisher = "Bloomsbury",
                        ISBN = "978-0545010225",
                        Classification = "Fiction",
                        Category = "Fantasy",
                        Price = 10.99F,
                        Pages = 759
                    },

                    new Book
                    {
                        BookTitle = "The Book of Basketball",
                        AuthorFirstName = "Bill",
                        AuthorLastName = "Simmons",
                        Publisher = "ESPN Books",
                        ISBN = "978-0345511768",
                        Classification = "Fiction",
                        Category = "Sports",
                        Price = 11.99F,
                        Pages = 736
                    }
                );

                context.SaveChanges();
            }
        }
    }
}
