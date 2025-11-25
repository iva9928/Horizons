using System.ComponentModel.DataAnnotations;

namespace Horizons.Models
{
    public class ReservationCreateViewModel
    {
        public int DestinationId { get; set; }

        public string DestinationName { get; set; } = string.Empty;

        public string? DestinationImageUrl { get; set; }

        [Required(ErrorMessage = "Моля, изберете дата.")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Range(1, 1000, ErrorMessage = "Минимум 1 човек.")]
        public int PeopleCount { get; set; } = 1;

        public decimal TicketPrice { get; set; }

        public decimal TotalPrice => TicketPrice * PeopleCount;
    }
}
