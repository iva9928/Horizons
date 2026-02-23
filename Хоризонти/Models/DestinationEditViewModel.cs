

using Horizons.Data.Models;
using Horizons.Models;

public class DestinationEditViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public string PublishedOn { get; set; } = string.Empty;
        public string? Location { get; set; }
        public string? LocationUrl { get; set; }


        public int TerrainId { get; set; }

        public string PublisherId { get; set; } = string.Empty;

        public IEnumerable<TerrainViewModel> Terrains { get; set; }
            = new List<TerrainViewModel>();

        public decimal TicketPrice { get; set; }

    public Season Season { get; set; }

    public List<string> Images { get; set; } = new();
    }

