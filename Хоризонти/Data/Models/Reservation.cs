using Horizons.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizons.Data.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int DestinationId { get; set; }
        public Destination Destination { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;

        [Required]
        public DateTime Date { get; set; }

        [Range(1, 1000)]
        public int PeopleCount { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(0, 100)]
        public decimal TicketPrice { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(0, 100)]
        public decimal TotalPrice => TicketPrice * PeopleCount;

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    }
}
