using System.ComponentModel.DataAnnotations;

namespace Horizons.Data.Models
{
    public class UserDestination
    {
        public string UserId { get; set; } = null!;

        public ApplicationUser User { get; set; } = null!;

        public int DestinationId { get; set; }

        public Destination Destination { get; set; } = null!;
    }
}