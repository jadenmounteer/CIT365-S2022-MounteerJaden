using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Ephraim's Rescue",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Historical",
                        Price = 7.99M,
                        Rating = "PG",
                        ImageName = "ephraims rescue.jpg"
                    },

                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Historical",
                        Price = 8.99M,
                        Rating = "PG",
                        ImageName = "17 miracles.jpg"

                    },

                    new Movie
                    {
                        Title = "Joseph Smith, Prophet of the Restoration",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Historical",
                        Price = 9.99M,
                        Rating = "PG",
                        ImageName = "Joseph smith.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}