using Horizons.Data.Models;
using Horizons.Models;

namespace Horizons.Services
{
    public interface IDestinationService
    {
        Task AddDestinationAsync(DestinationAddViewModel model, string userId);

        Task EditDestinationAsync(DestinationEditViewModel model, string userId);

        Task DeleteDestinationAsync(int id, string userId);

        Task<DestinationDetailsViewModel?> GetDestinationDetailsAsync(int id, string userId);

        Task<IEnumerable<DestinationListViewModel>> GetAllDestinationsAsync(string userId);

        Task<IEnumerable<DestinationListViewModel>> GetAllAsync();

        Task<Destination?> GetDestinationByIdAsync(int id);

        Task<DestinationEditViewModel?> GetEditModelAsync(int id);

        Task AddToFavoritesAsync(int destinationId, string userId);

        Task RemoveFromFavoritesAsync(int destinationId, string userId);

        Task<IEnumerable<FavoriteDestinationViewModel>> GetFavoriteDestinationsAsync(string userId);

        Task<IEnumerable<TerrainViewModel>> GetAllTerrainsAsync();

        Task AddRatingAsync(string userId, int destinationId, int stars, string comment);
    }
}