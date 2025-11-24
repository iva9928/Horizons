using System.ComponentModel.DataAnnotations;

namespace Horizons.Models
{
    public class DestinationAddViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        public string PublishedOn { get; set; } = string.Empty;

        [Required]
        public int TerrainId { get; set; }

        public IEnumerable<TerrainViewModel> Terrains { get; set; }
            = new List<TerrainViewModel>();


        public decimal TicketPrice { get; set; }

        public string? Location { get; set; }
        public string? LocationUrl { get; set; }

        public List<string> Images { get; set; } = new();
    }
}
