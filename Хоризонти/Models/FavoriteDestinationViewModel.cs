namespace Horizons.Models
{
    public class FavoriteDestinationViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string? ImageUrl { get; set; }

        public string Terrain { get; set; } = string.Empty;

        public decimal TicketPrice { get; set; }

        public bool IsFavorite { get; set; }

        public bool IsPublisher { get; set; }
    }
}
