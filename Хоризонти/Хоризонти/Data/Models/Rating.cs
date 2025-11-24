using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizons.Data.Models
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }

        [Range(1, 5)]
        public int Stars { get; set; }

        [MaxLength(500)]
        public string? Comment { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        [Required]
        public string UserId { get; set; }
        public IdentityUser User { get; set; }

        public int DestinationId { get; set; }
        public Destination Destination { get; set; }
    }
}
