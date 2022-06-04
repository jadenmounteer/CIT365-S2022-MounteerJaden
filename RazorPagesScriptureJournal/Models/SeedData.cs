using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesScriptureJournal.Data;
using System;
using System.Linq;

namespace RazorPagesScriptureJournal.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesScriptureJournalContext>>()))
            {
                // Look for any scriptures.
                if (context.Scripture.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scripture.AddRange(
                    new Scripture
                    {
                        Reference = "Ether 12:27",
                        Note = "The Lord will help me turn my weaknesses into strengths.",
                        EntryDate = DateTime.Parse("2022-6-12")
                    },

                    new Scripture
                    {
                        Reference = "D&C 46:11",
                        Note = "Everyone has different gifts.",
                        EntryDate = DateTime.Parse("2022-6-13")
                    },

                    new Scripture
                    {
                        Reference = "John 10:28",
                        Note = "The Lord will take care of you if you trust him.",
                        EntryDate = DateTime.Parse("2022-6-14")
                    },

                    new Scripture
                    {
                        Reference = "D&C 41:5",
                        Note = "To be a true desciple, keep the commandments.",
                        EntryDate = DateTime.Parse("2021-4-15")
                    }
                );
                context.SaveChanges();
            }
        }
    }
}