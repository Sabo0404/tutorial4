using Microsoft.EntityFrameworkCore;
using popytka2.Models.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace popytka2.Data
{
    public class MoviesContext : DbContext
    {
        public MoviesContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                Id = -1,
                Author = "Todd Phillips",
                Genre = "Crime , Drama , Thriller",
                Name = "Joker",
                Poster = "https://upload.wikimedia.org/wikipedia/en/e/e1/Joker_%282019_film%29_poster.jpg",
                CreatedAt = new DateTime(2019, 10, 3)
            },
            new Movie
            {
                Id = -2,
                Author = "David Leitch",
                Genre = "Action , Adventure",
                Name = "Fast & Furious Presents: Hobbs & Shaw",
                Poster = "https://upload.wikimedia.org/wikipedia/en/0/00/Fast_%26_Furious_Presents_Hobbs_%26_Shaw_-_theatrical_poster.jpg",
                CreatedAt = new DateTime(2019, 8, 2)
            },
            new Movie
            {
                Id = -3,
                Author = "Jon Favreau",
                Genre = "Adventure , Animation , Drama , Family , Musical",
                Name = "The Lion King",
                Poster = "https://www.joblo.com/movie-posters/2019/the-lion-king/image-35365#image-35365",
                CreatedAt = new DateTime(2019, 7, 19)
            },
            new Movie
            {
                Id = -4,
                Author = "Joachim Rønning",
                Genre = "Adventure , Family , Fantasy",
                Name = "Maleficent: Mistress of Evil",
                Poster = "https://upload.wikimedia.org/wikipedia/ru/b/b0/Maleficent_-_Mistress_of_Evil_%28poster%29.jpg",
                CreatedAt = new DateTime(2019, 10, 18)
            });
        }
    }


}
