using Horizons.Models;

namespace Horizons.Services
{
    /// <summary>
    /// Defines contract for reservation-related operations,
    /// including creation and retrieval of reservations.
    /// </summary>
    public interface IReservationService
    {
        /// <summary>
        /// Retrieves a reservation creation model for a given destination.
        /// </summary>
        /// <param name="destinationId">The identifier of the destination to be reserved.</param>
        /// <returns>
        /// A populated <see cref="ReservationCreateViewModel"/> if the destination exists;
        /// otherwise <c>null</c>.
        /// </returns>
        Task<ReservationCreateViewModel?> GetCreateModelAsync(int destinationId);

        /// <summary>
        /// Creates a new reservation for a specific user.
        /// </summary>
        /// <param name="model">The reservation data provided by the user.</param>
        /// <param name="userId">The identifier of the user making the reservation.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when the reservation data is invalid.
        /// </exception>
        Task CreateReservationAsync(ReservationCreateViewModel model, string userId);

        /// <summary>
        /// Retrieves all reservations in the system.
        /// </summary>
        /// <remarks>
        /// Intended for administrative usage.
        /// </remarks>
        /// <returns>A collection of <see cref="ReservationListViewModel"/>.</returns>
        Task<IEnumerable<ReservationListViewModel>> GetAllReservationsAsync();

        /// <summary>
        /// Retrieves all reservations made by a specific user.
        /// </summary>
        /// <param name="userId">The identifier of the user.</param>
        /// <returns>
        /// A collection of <see cref="ReservationListViewModel"/> belonging to the specified user.
        /// </returns>
        Task<IEnumerable<ReservationListViewModel>> GetUserReservationsAsync(string userId);
    }
}
