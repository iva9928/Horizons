using Horizons.Data;
using Horizons.Data.Models;
using Horizons.Models;
using Microsoft.EntityFrameworkCore;

namespace Horizons.Services
{
    /// <summary>
    /// Service responsible for handling reservation-related business logic,
    /// including creation and retrieval of reservations.
    /// </summary>
    public class ReservationService : IReservationService
    {
        private readonly ApplicationDbContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReservationService"/> class.
        /// </summary>
        /// <param name="context">The application's database context.</param>
        public ReservationService(ApplicationDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Retrieves a reservation creation model for a specific destination.
        /// </summary>
        /// <param name="destinationId">The identifier of the destination to reserve.</param>
        /// <returns>
        /// A populated <see cref="ReservationCreateViewModel"/> if the destination exists and is not deleted;
        /// otherwise <c>null</c>.
        /// </returns>
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

        /// <summary>
        /// Creates a new reservation in the system.
        /// </summary>
        /// <param name="model">The reservation data provided by the user.</param>
        /// <param name="userId">The identifier of the user making the reservation.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when the reservation model or user identifier is invalid.
        /// </exception>
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

        /// <summary>
        /// Retrieves all reservations in the system.
        /// </summary>
        /// <remarks>
        /// Intended for administrative use.
        /// </remarks>
        /// <returns>A collection of <see cref="ReservationListViewModel"/> ordered by creation date (descending).</returns>
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

        /// <summary>
        /// Retrieves all reservations made by a specific user.
        /// </summary>
        /// <param name="userId">The identifier of the user.</param>
        /// <returns>
        /// A collection of <see cref="ReservationListViewModel"/> ordered by reservation date (descending).
        /// </returns>
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
                    UserName = "" // Not displayed in My.cshtml
                })
                .ToListAsync();
        }
    }
}
