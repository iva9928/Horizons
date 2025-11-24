namespace Horizons.Models
{
    public class DestinationListViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public string Terrain { get; set; } = string.Empty;

        public bool IsFavorite { get; set; }

        public bool IsPublisher { get; set; }

        public int FavoritesCount { get; set; }
        public decimal TicketPrice { get; set; }
    }
}
