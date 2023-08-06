using System.ComponentModel.DataAnnotations;

namespace auth.Models
{
    public class MovieDetail
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string MovieName { get; set; }
        [Required]
        public int Rating { get; set; }
        [Required]
        public string Url { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
