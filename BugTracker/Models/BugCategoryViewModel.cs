using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace BugTracker.Models
{
    public class BugCategoryViewModel
    {
        public List<Bug>? Bugs { get ; set; }
        public SelectList? Categories { get; set; }
        public string? BugCategory { get; set; }
        public string? SearchString { get; set; }
    }
}
