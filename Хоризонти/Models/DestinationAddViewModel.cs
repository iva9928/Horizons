using Horizons.Models;
using System.ComponentModel.DataAnnotations;
using Horizons.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;


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

        [Required(ErrorMessage = "Локацията е задължителна.")]
        public string Location { get; set; } = string.Empty;

        public string? LocationUrl { get; set; }

    public Season Season { get; set; }

    public IEnumerable<SelectListItem> Seasons { get; set; }
        = new List<SelectListItem>();

    public List<string> Images { get; set; } = new();
    }

