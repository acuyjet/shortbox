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

        [Required]
        [Display(Name = "Series Name")]
        public string SeriesName { get; set; }

        [Required]
        [RegularExpression(@"[0 - 9]*\w+")]
        [Display(Name = "Issue Number")]
        public string IssueNumber { get; set; }

        [DisplayFormat(DataFormatString = "{0:MMMM yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date (Month and Year)")]
        public DateTime Date { get; set; }

        public string Publisher { get; set; }

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
