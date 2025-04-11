using System.ComponentModel.DataAnnotations;

namespace WatchlistApp.Models
{
    public class WatchItem
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Type { get; set; } 

        [Required]
        public string Status { get; set; }
    }
}
