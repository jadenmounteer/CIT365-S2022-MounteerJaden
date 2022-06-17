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
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "17 Miracles",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Historical",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Joseph Smith, Prophet of the Restoration",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Historical",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "The Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Entertainment",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}