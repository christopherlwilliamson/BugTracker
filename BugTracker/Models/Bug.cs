using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models

{
    public class Bug
    {
        public int Id { get; set; }
        public string? Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateSubmitted { get; set; }
        public string? Category {  get; set; }
        public string? Description { get; set; }
    }
}
