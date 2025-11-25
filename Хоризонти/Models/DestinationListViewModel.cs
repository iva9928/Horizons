public class DestinationListViewModel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string ImageUrl { get; set; } = null!;
    public string Terrain { get; set; } = null!;
    public int TerrainId { get; set; }    
    public decimal TicketPrice { get; set; }
    public int FavoritesCount { get; set; }
    public bool IsPublisher { get; set; }
    public bool IsFavorite { get; set; }
}
