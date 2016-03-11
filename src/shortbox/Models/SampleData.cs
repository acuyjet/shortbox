using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.Extensions.DependencyInjection;

namespace shortbox.Models
{
    public static class SampleData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Issue.Any())
            {
                var sampleSeries1 = context.Series.Add(
                    new Series { Title = "Sample Series 1", Publisher = "Sample Publisher 1" }).Entity;
                var sampleSeries2 = context.Series.Add(
                     new Series { Title = "Sample Series 2", Publisher = "Sample Publisher 2" }).Entity;
                var sampleSeries3 = context.Series.Add(
                    new Series { Title = "Sample Series 3", Publisher = "Sample Publisher 3" }).Entity;

                context.Issue.AddRange(
                    new Issue()
                    {
                        Series = sampleSeries1,
                        SeriesName = "Sample Series 1",
                        IssueNumber = "1",
                        StoryArc = "Sample Story Arc",
                        Writer = "Sample Writer",
                        Penciller = "Sample Artist",
                        Colorist = "Sample Colorist",
                        Letterer = "Sample Letterer",
                    },
                    new Issue()
                    {
                        Series = sampleSeries2,
                        SeriesName = "Sample Series 2",
                        IssueNumber = "1",
                        StoryArc = "Sample Story Arc",
                        Writer = "Sample Writer",
                        Penciller = "Sample Artist",
                        Colorist = "Sample Colorist",
                        Letterer = "Sample Letterer",
                    },
                    new Issue()
                    {
                        Series = sampleSeries3,
                        SeriesName = "Sample Series 3",
                        IssueNumber = "1",
                        StoryArc = "Sample Story Arc",
                        Writer = "Sample Writer",
                        Penciller = "Sample Artist",
                        Colorist = "Sample Colorist",
                        Letterer = "Sample Letterer",
                    },
                    new Issue()
                    {
                        Series = sampleSeries1,
                        SeriesName = "Sample Series 1",
                        IssueNumber = "2",
                        StoryArc = "Sample Story Arc",
                        Writer = "Sample Writer",
                        Penciller = "Sample Artist",
                        Colorist = "Sample Colorist",
                        Letterer = "Sample Letterer",
                    },
                    new Issue()
                    {
                        Series = sampleSeries2,
                        SeriesName = "Sample Series 2",
                        IssueNumber = "2",
                        StoryArc = "Sample Story Arc",
                        Writer = "Sample Writer",
                        Penciller = "Sample Artist",
                        Colorist = "Sample Colorist",
                        Letterer = "Sample Letterer",
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
