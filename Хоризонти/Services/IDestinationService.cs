using Horizons.Data.Models;
using Horizons.Models;

namespace Horizons.Services
{
    public interface IDestinationService
    {
        // ================= DESTINATION =================

        Task AddDestinationAsync(DestinationAddViewModel model, string userId);

        Task EditDestinationAsync(DestinationEditViewModel model, string userId);

        Task DeleteDestinationAsync(int id, string userId);

        Task<DestinationDetailsViewModel?> GetDestinationDetailsAsync(int id, string userId);

        Task<IEnumerable<DestinationListViewModel>> GetAllDestinationsAsync(string userId);

        Task<IEnumerable<DestinationListViewModel>> GetAllAsync();

        Task<Destination?> GetDestinationByIdAsync(int id);

        Task<DestinationEditViewModel?> GetEditModelAsync(int id);

        // ================= FAVORITES =================
        // !!! СЪОБРАЗЕНО С КОНТРОЛЕРА

        Task AddToFavoritesAsync(int destinationId, string userId);

        Task RemoveFromFavoritesAsync(int destinationId, string userId);

        Task<IEnumerable<FavoriteDestinationViewModel>> GetFavoriteDestinationsAsync(string userId);

        // ================= TERRAIN =================

        Task<IEnumerable<TerrainViewModel>> GetAllTerrainsAsync();

        // ================= RATING =================

        Task AddRatingAsync(string userId, int destinationId, int stars, string comment);
    }
}