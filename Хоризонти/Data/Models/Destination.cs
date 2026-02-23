using Horizons.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace Horizons.Data.Models
{
    public class Destination
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;

        public decimal TicketPrice { get; set; }
        public DateTime PublishedOn { get; set; }
        public bool IsDeleted { get; set; }

        public int TerrainId { get; set; }
        public Terrain Terrain { get; set; } = null!;

        public string PublisherId { get; set; } = null!;
        public ApplicationUser Publisher { get; set; } = null!;
        public Season Season { get; set; }

        public string? VideoUrl { get; set; }

        public string Location { get; set; } = null!;
        public string? LocationUrl { get; set; }
    }
}
