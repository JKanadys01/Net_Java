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
        public double? Rate { get; set; }
    }
}
