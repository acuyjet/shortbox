using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shortbox.Models
{
    public class Issue
    {
        public int Id { get; set; }

        [Display(Name = "Series Name")]
        public string SeriesName { get; set; }

        [Display(Name = "Issue Number")]
        public string IssueNumber { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MMMM yyyy}")]
        public DateTime Date { get; set; }

        [Display(Name = "Story Arc")]
        public string StoryArc { get; set; }

        public string Writer { get; set; }

        public string Penciller { get; set; }

        [Display(Name = "Cover Artist")]
        public string CoverArtist { get; set; }

        public string Inker { get; set; }

        public string Colorist { get; set; }

        public string Letterer { get; set; }
    }
}
