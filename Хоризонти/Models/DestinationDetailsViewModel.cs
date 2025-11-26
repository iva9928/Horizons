
    public class DestinationDetailsViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;

        public string Terrain { get; set; } = null!;
        public string Publisher { get; set; } = null!;
        public string PublishedOn { get; set; } = null!;
        public decimal TicketPrice { get; set; }

        public bool IsPublisher { get; set; }
        public bool IsFavorite { get; set; }

      
        public string? Location { get; set; }
        public string? LocationUrl { get; set; }

     
        public double AverageRating { get; set; }
        public bool HasRated { get; set; }

        public IEnumerable<RatingViewModel> Ratings { get; set; } = new List<RatingViewModel>();
    }

