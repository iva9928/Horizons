using Horizons.Models;

namespace Horizons.Services
{
    public interface IReservationService
    {
        Task<ReservationCreateViewModel?> GetCreateModelAsync(int destinationId);

        Task CreateReservationAsync(ReservationCreateViewModel model, string userId);

        Task<IEnumerable<ReservationListViewModel>> GetAllReservationsAsync();

        Task<IEnumerable<ReservationListViewModel>> GetUserReservationsAsync(string userId);
    }
}
