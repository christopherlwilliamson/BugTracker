using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BugTracker.Data;
using System;
using System.Linq;

namespace BugTracker.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BugTrackerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BugTrackerContext>>()))
            {
                // Look for any bugs.
                if (context.Bug.Any())
                {
                    return;   // DB has been seeded
                }

                context.Bug.AddRange(
                    new Bug
                    {
                        Title = "Test Bug #01",
                        DateSubmitted = DateTime.Parse("3/24/2022"),
                        Category = "Other",
                        Description = "This is the first in a series of test bugs",
                        Severity = "A"
                    },

                    new Bug
                    {
                        Title = "Test Bug #02",
                        DateSubmitted = DateTime.Parse("3/23/2022"),
                        Category = "Other",
                        Description = "This is the second in a series of test bugs",
                        Severity = "B"
                    },

                    new Bug
                    {
                        Title = "Test Bug #03",
                        DateSubmitted = DateTime.Parse("3/22/2022"),
                        Category = "Other",
                        Description = "This is the third in a series of test bugs",
                        Severity = "A"                  
                    },

                    new Bug
                    {
                        Title = "Test Bug #04",
                        DateSubmitted = DateTime.Parse("3/24/2022"),
                        Category = "Bugs",
                        Description = "This is the fourth in a series of test bugs",
                        Severity = "F"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}


