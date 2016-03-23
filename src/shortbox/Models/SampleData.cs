using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shortbox.Models
{
    public static class SampleData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ApplicationDbContext>();

            if (context.Database == null)
            {
                throw new Exception("DB is null");
            }

            if (context.Issue.Any())
            {
                return; //DB has been seeded
            }

            context.Issue.AddRange(
                new Issue
                {
                    SeriesName = "Sample Series 1",
                    IssueNumber = "1",
                    Date = DateTime.Parse("February 2016"),
                    StoryArc = "Sample Story Arc 1",
                    Writer = "Sample Writer 1",
                    Penciller = "Sample Penciller 1",
                    CoverArtist = "Sample Cover Artist 1",
                    Inker = "Sample Inker 1",
                    Colorist = "Sample Colorist 1",
                    Letterer = "Sample Letterer 1",
                },

                new Issue
                {
                    SeriesName = "Sample Series 2",
                    IssueNumber = "1",
                    Date = DateTime.Parse("March 2016"),
                    StoryArc = "Sample Story Arc 2",
                    Writer = "Sample Writer 2",
                    Penciller = "Sample Penciller 2",
                    CoverArtist = "Sample Cover Artist 2",
                    Inker = "Sample Inker 2",
                    Colorist = "Sample Colorist 2",
                    Letterer = "Sample Letterer 2",
                },

                new Issue
                {
                    SeriesName = "Sample Series 3",
                    IssueNumber = "1",
                    Date = DateTime.Parse("January 2016"),
                    StoryArc = "Sample Story Arc 3",
                    Writer = "Sample Writer 3",
                    Penciller = "Sample Penciller 3",
                    CoverArtist = "Sample Cover Artist 3",
                    Inker = "Sample Inker 3",
                    Colorist = "Sample Colorist 3",
                    Letterer = "Sample Letterer 3",
                });
            context.SaveChanges();
        }
    }
}
