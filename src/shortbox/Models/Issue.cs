using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace shortbox.Models
{
    public class Issue
    {
        public int Id { get; set; }

        public string SeriesName { get; set; }

        public string IssueNumber { get; set; }

        public string StoryArc { get; set; }

        public string Writer { get; set; }

        public string Penciller { get; set; }

        public string Inker { get; set; }

        public string Colorist { get; set; }

        public string Letterer { get; set; }

    }
}
