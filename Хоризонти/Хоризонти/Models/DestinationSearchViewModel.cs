namespace Horizons.Models
{
    public class DestinationSearchViewModel
    {
        public string? Query { get; set; }

        public int? TerrainId { get; set; }

        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }

        public bool? OnlyFavorites { get; set; }

        public IEnumerable<DestinationListViewModel> Results { get; set; }
            = new List<DestinationListViewModel>();

        public IEnumerable<TerrainViewModel> Terrains { get; set; }
            = new List<TerrainViewModel>();
    }
}
