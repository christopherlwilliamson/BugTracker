using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugTracker.Models

{
    public class Bug
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }
        
        [Display(Name = "Date Submitted")]
        [DataType(DataType.Date)]
        public DateTime DateSubmitted { get; set; }

        //Must only use letters.
        //The first letter is required to be uppercase.
        //White spaces are allowed while numbers, and special characters are not allowed.
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(30)]
        [Required]
        public string Category {  get; set; }

        [StringLength(300, MinimumLength = 3)]
        [Required]
        public string Description { get; set; }

        //Requires that the first character be an uppercase letter.
        //Allows special characters and numbers in subsequent spaces.
        //"A-10" is valid for a Severity, but fails for a "Category".
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(5)]
        [Required]
        public string Severity { get; set; }
    }
}
