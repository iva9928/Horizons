using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public DateTime SentOn { get; set; }

        public bool IsPublic { get; set; }

        public int? DestinationId { get; set; }
    }
}