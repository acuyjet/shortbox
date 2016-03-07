using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shortbox.Models
{
    public class Issues
    {
        [ScaffoldColumn(false)]
        public int IssueId { get; set; }

        [Required]
        [Display(Name = "Series")]
        public string SeriesName { get; set; }

        [Required]
        [Display(Name = "Issue #")]
        public string IssueNumber { get; set; }

        public string Publisher { get; set; }

        [Display(Name="Story Arc")]
        public string StoryArc { get; set; }
        
        public string Writer { get; set; }

        public string Artist { get; set; }

        public string Inker { get; set; }

        public string Colorist { get; set; }

        public string Letterer { get; set; }

        //Navigation property
        public virtual Series Series { get; set; }

    }
}
