namespace Horizons.Models
{
    public class ReservationListViewModel
    {
        public int Id { get; set; }

        public string DestinationName { get; set; } = string.Empty;

        public string UserName { get; set; } = string.Empty;

        public DateTime Date { get; set; }

        public int PeopleCount { get; set; }

        public decimal TicketPrice { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
