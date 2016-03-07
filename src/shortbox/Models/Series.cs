using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shortbox.Models
{
    public class Series
    {
        [ScaffoldColumn(false)]
        public int SeriesId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Publisher { get; set; }

        public virtual ICollection<Issues> Issues { get; set; }
    }
}
