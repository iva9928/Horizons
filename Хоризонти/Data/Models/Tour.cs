using Horizons.Data.Models;
using System;
using System.ComponentModel.DataAnnotations;

public class Tour
{
    public int Id { get; set; }

    [Required]
    public int DestinationId { get; set; }
    public Destination Destination { get; set; }

    [Required]
    public string GuideId { get; set; }
    public ApplicationUser Guide { get; set; }

    [Required]
    public DateTime Date { get; set; }

    public int MaxPeople { get; set; }

    public decimal PricePerPerson { get; set; }

    public string? Description { get; set; }

    public ICollection<TourReservation> Reservations { get; set; }
    = new List<TourReservation>();
}