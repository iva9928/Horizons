using Horizons.Data.Models;
using Horizons.Models;

namespace Horizons.Services
{
    public interface IDestinationService
    {
        Task AddDestinationAsync(DestinationAddViewModel model, string userId);

        Task EditDestinationAsync(DestinationEditViewModel model, string userId);

        Task<DestinationDetailsViewModel?> GetDestinationDetailsAsync(int id, string userId);

        Task<IEnumerable<DestinationListViewModel>> GetAllDestinationsAsync(string userId);

        Task<IEnumerable<DestinationListViewModel>> GetAllAsync();

        Task<Destination?> GetDestinationByIdAsync(int id);

        Task<IEnumerable<FavoriteDestinationViewModel>> GetFavoriteDestinationsAsync(string userId);

        Task AddToFavoritesAsync(string userId, int destinationId);

        Task RemoveFromFavoritesAsync(string userId, int destinationId);

        Task DeleteDestinationAsync(int id, string userId);

        Task<IEnumerable<TerrainViewModel>> GetAllTerrainsAsync();

        Task<DestinationEditViewModel?> GetEditModelAsync(int id);

        Task AddRatingAsync(string userId, int destinationId, int stars, string comment);
    }
}
