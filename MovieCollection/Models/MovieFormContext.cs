using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollection.Models
{
    public class MovieFormContext : DbContext
    {
        public MovieFormContext (DbContextOptions<MovieFormContext> options) : base (options)
        {

        }
        public DbSet<Movie> Responses { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Rating> Rating { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Movie>().HasData(

                new Movie
                {
                    MovieId = 1,
                    CategoryId = 3,
                    Title = "Remember the Titans",
                    Year = 2000,
                    Director = "Boaz Yakin",
                    RatingId = 2,
                    Edited = false,
                    LentTo = "",
                    Notes = "Conner's Favs #1"
                },
                new Movie
                {
                    MovieId = 2,
                    CategoryId = 6,
                    Title = "Greatest Showman, The",
                    Year = 2017,
                    Director = "Michael Gracey",
                    RatingId = 2,
                    Edited = false,
                    LentTo = "",
                    Notes = "Conner's Favs #2"
                },
                new Movie
                {
                    MovieId = 3,
                    CategoryId = 4,
                    Title = "Onward",
                    Year = 2000,
                    Director = "Dan Scanlon",
                    RatingId = 2,
                    Edited = false,
                    LentTo = "",
                    Notes = "Conner's Favs #3"
                }
            );

            mb.Entity<Category>().HasData(

                new Category { CategoryId = 1, CategoryName = "Action/Adventure"},
                new Category { CategoryId = 2, CategoryName = "Comedy" },
                new Category { CategoryId = 3, CategoryName = "Drama" },
                new Category { CategoryId = 4, CategoryName = "Family" },
                new Category { CategoryId = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryId = 7, CategoryName = "Television" },
                new Category { CategoryId = 8, CategoryName = "VHS" }
            );

            mb.Entity<Rating>().HasData(

                new Rating { RatingId = 1, RatingName = "G" },
                new Rating { RatingId = 2, RatingName = "PG" },
                new Rating { RatingId = 3, RatingName = "PG-13" },
                new Rating { RatingId = 4, RatingName = "R" },
                new Rating { RatingId = 5, RatingName = "UR" },
                new Rating { RatingId = 6, RatingName = "NR" },
                new Rating { RatingId = 7, RatingName = "TV-14" },
                new Rating { RatingId = 8, RatingName = "TV-PG" },
                new Rating { RatingId = 9, RatingName = "TV-Y7" }

            );
        }
    }
}
