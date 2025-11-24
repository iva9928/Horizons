using Horizons.Data;
using Horizons.Data.Models;
using Horizons.Models;
using Microsoft.EntityFrameworkCore;

namespace Horizons.Services
{
    public class ReservationService : IReservationService
    {
        private readonly ApplicationDbContext context;

        public ReservationService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<ReservationCreateViewModel?> GetCreateModelAsync(int destinationId)
        {
            var dest = await context.Destinations
                .Where(d => !d.IsDeleted)
                .FirstOrDefaultAsync(d => d.Id == destinationId);

            if (dest == null)
                return null;

            return new ReservationCreateViewModel
            {
                DestinationId = dest.Id,
                DestinationName = dest.Name,
                DestinationImageUrl = dest.ImageUrl,
                Date = DateTime.Today,
                PeopleCount = 1,
                TicketPrice = dest.TicketPrice
            };
        }

        public async Task CreateReservationAsync(ReservationCreateViewModel model, string userId)
        {
            if (model == null || userId == null)
                throw new ArgumentException("Invalid reservation data");

            var reservation = new Reservation
            {
                DestinationId = model.DestinationId,
                UserId = userId,
                Date = model.Date.Date,
                PeopleCount = model.PeopleCount,
                TicketPrice = model.TicketPrice,
                CreatedOn = DateTime.UtcNow
            };

            await context.Reservations.AddAsync(reservation);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ReservationListViewModel>> GetAllReservationsAsync()
        {
            return await context.Reservations
                .Include(r => r.Destination)
                .Include(r => r.User)
                .OrderByDescending(r => r.CreatedOn)
                .Select(r => new ReservationListViewModel
                {
                    Id = r.Id,
                    DestinationName = r.Destination.Name,
                    UserName = r.User.UserName ?? "—",
                    Date = r.Date,
                    PeopleCount = r.PeopleCount,
                    TicketPrice = r.TicketPrice,
                    TotalPrice = r.TicketPrice * r.PeopleCount,
                    CreatedOn = r.CreatedOn
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<ReservationListViewModel>> GetUserReservationsAsync(string userId)
        {
            return await context.Reservations
                .Include(r => r.Destination)
                .Where(r => r.UserId == userId)
                .OrderByDescending(r => r.Date)
                .Select(r => new ReservationListViewModel
                {
                    Id = r.Id,
                    DestinationName = r.Destination.Name,
                    Date = r.Date,
                    PeopleCount = r.PeopleCount,
                    TicketPrice = r.TicketPrice,
                    TotalPrice = r.TicketPrice * r.PeopleCount,
                    CreatedOn = r.CreatedOn,
                    UserName = "" // Не се показва в My.cshtml
                })
                .ToListAsync();
        }
    }
}
