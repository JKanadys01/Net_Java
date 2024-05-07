using System.ComponentModel.DataAnnotations;

namespace MovieRaitingBlazorApp.Components
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ReliseDate { get; set; }

        [Range(1, 10, ErrorMessage = "Rate must be between 1 and 10.")]
        public double? Rate { get; set; }
        public string ImageUrl { get; set; }
    }
}
