//using Microsoft.Extensions.DependencyInjection;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace shortbox.Models
//{
//    public static class SampleData
//    {
//        public static void Initialize(IServiceProvider serviceProvider)
//        {
//            var context = serviceProvider.GetService<ApplicationDbContext>();

//            if (context.Database == null)
//            {
//                throw new Exception("DB is null");
//            }

//            if (context.Issue.Any())
//            {
//                return; //DB has been seeded
//            }

//            context.Issue.AddRange(
//                new Issue
//                {
//                    SeriesName = "Mind the Gap",
//                    IssueNumber = "1",
//                    Date = DateTime.Parse("June 2012"),
//                    StoryArc = "Intimate Strangers",
//                    Publisher = "Image",
//                    Writer = "Jim McCann",
//                    Penciller = "Rodin Esquejo",
//                    CoverArtist = "Rodin Esquejo",
//                    Inker = "Rodin Esquejo",
//                    Colorist = "Sonia Oback",
//                    Letterer = "Dave Lanphear"
//                },

//                new Issue
//                {
//                    SeriesName = "Morning Glories",
//                    IssueNumber = "10",
//                    Date = DateTime.Parse("June 2011"),
//                    StoryArc = "All Will Be Free",
//                    Publisher = "Image",
//                    Writer = "Nick Spencer",
//                    Penciller = "Joe Eisma",
//                    CoverArtist = "Rodin Esquejo",
//                    Inker = "Joe Eisma",
//                    Colorist = "Alex Sollazzo",
//                    Letterer = "Johnny Lowe",
//                },

//                new Issue
//                {
//                    SeriesName = "Y: The Last Man",
//                    IssueNumber = "6",
//                    Date = DateTime.Parse("February 2003"),
//                    StoryArc = "Cycles",
//                    Publisher = "Vertigo",
//                    Writer = "Brian K. Vaughan",
//                    Penciller = "Pia Guerra",
//                    CoverArtist = "J.G. Jones",
//                    Inker = "Jose Marzan Jr.",
//                    Colorist = "Pamela Rambo",
//                    Letterer = "Clem Robins",
//                });
//            context.SaveChanges();
//        }
//    }
//}
