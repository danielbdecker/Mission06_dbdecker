using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_dbdecker.Models
{
    public class MoviesContext : DbContext
    {
        //constructor
        public MoviesContext (DbContextOptions<MoviesContext> options) : base (options)
        {

        }
        public DbSet<MovieResponse> responses { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId=1, CategoryName="Horror"},
                new Category { CategoryId=2, CategoryName="Action"},
                new Category { CategoryId = 3, CategoryName = "Science Fiction" },
                new Category { CategoryId = 4, CategoryName = "Thriller" },
                new Category { CategoryId = 5, CategoryName = "Chick flick" },
                new Category { CategoryId = 6, CategoryName = "Kids" }
            );
            mb.Entity<MovieResponse>().HasData(
                new MovieResponse
                {
                    MovieID = 1,
                    CategoryId = 1,
                    Title = "Air Bud",
                    Year = 1997,
                    Director = "Charles Martin Smith",
                    Rating = "PG",
                    Notes = "A masterpiece"
                },
                new MovieResponse
                {
                    MovieID = 2,
                    CategoryId = 1,
                    Title = "Air Bud: Golden Receiver",
                    Year = 1998,
                    Director = "Richard Martin",
                    Rating = "G",
                    Notes = "Another masterpiece"
                },
                new MovieResponse
                {
                    MovieID = 3,
                    CategoryId = 1,
                    Title = "Air Bud: World Pup",
                    Year = 2000,
                    Director = "Bill Bannerman",
                    Rating = "G",
                    Notes = "Yet another masterpiece"
                }
                );
        }
    }
}
