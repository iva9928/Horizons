using System.ComponentModel.DataAnnotations;

namespace Horizons.Data.Models
{
    public class Message
    {
        public int Id { get; set; }

        [Required]
        public string SenderId { get; set; } = null!;
        public ApplicationUser Sender { get; set; } = null!;

        [Required]
        public string ReceiverId { get; set; } = null!;
        public ApplicationUser Receiver { get; set; } = null!;

        [Required]
        [MaxLength(1000)]
        public string Content { get; set; } = null!;

        public DateTime SentOn { get; set; } = DateTime.UtcNow;

        public bool IsPublic { get; set; } = false;

        public int? DestinationId { get; set; }
        public Destination? Destination { get; set; }
        public int? TourId { get; set; }
        public Tour? Tour { get; set; }
    }
}