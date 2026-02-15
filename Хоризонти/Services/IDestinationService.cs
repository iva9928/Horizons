using Horizons.Data.Models;
using Horizons.Models;

namespace Horizons.Services
{
    /// <summary>
    /// Defines contract for destination-related operations,
    /// including CRUD functionality, favorites management,
    /// rating functionality, and terrain retrieval.
    /// </summary>
    public interface IDestinationService
    {
        /// <summary>
        /// Adds a new destination to the system.
        /// </summary>
        /// <param name="model">The destination data provided by the user.</param>
        /// <param name="userId">The identifier of the user publishing the destination.</param>
        Task AddDestinationAsync(DestinationAddViewModel model, string userId);

        /// <summary>
        /// Edits an existing destination.
        /// </summary>
        /// <param name="model">The updated destination data.</param>
        /// <param name="userId">The identifier of the user attempting the edit.</param>
        /// <exception cref="InvalidOperationException">
        /// Thrown when the destination does not exist.
        /// </exception>
        /// <exception cref="UnauthorizedAccessException">
        /// Thrown when the user is not authorized to edit the destination.
        /// </exception>
        Task EditDestinationAsync(DestinationEditViewModel model, string userId);

        /// <summary>
        /// Retrieves detailed information for a specific destination.
        /// </summary>
        /// <param name="id">The destination identifier.</param>
        /// <param name="userId">The identifier of the current user.</param>
        /// <returns>
        /// A <see cref="DestinationDetailsViewModel"/> if found; otherwise <c>null</c>.
        /// </returns>
        Task<DestinationDetailsViewModel?> GetDestinationDetailsAsync(int id, string userId);

        /// <summary>
        /// Retrieves all non-deleted destinations with user-specific data.
        /// </summary>
        /// <param name="userId">The identifier of the current user.</param>
        /// <returns>A collection of <see cref="DestinationListViewModel"/>.</returns>
        Task<IEnumerable<DestinationListViewModel>> GetAllDestinationsAsync(string userId);

        /// <summary>
        /// Retrieves a destination entity by its identifier.
        /// </summary>
        /// <param name="id">The destination identifier.</param>
        /// <returns>The <see cref="Destination"/> entity if found; otherwise <c>null</c>.</returns>
        Task<Destination?> GetDestinationByIdAsync(int id);

        /// <summary>
        /// Retrieves all favorite destinations for a specific user.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns>A collection of <see cref="FavoriteDestinationViewModel"/>.</returns>
        Task<IEnumerable<FavoriteDestinationViewModel>> GetFavoriteDestinationsAsync(string userId);

        /// <summary>
        /// Adds a destination to the user's favorites.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="destinationId">The destination identifier.</param>
        Task AddToFavoritesAsync(string userId, int destinationId);

        /// <summary>
        /// Removes a destination from the user's favorites.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <param name="destinationId">The destination identifier.</param>
        Task RemoveFromFavoritesAsync(string userId, int destinationId);

        /// <summary>
        /// Soft deletes a destination from the system.
        /// </summary>
        /// <param name="id">The destination identifier.</param>
        /// <param name="userId">The identifier of the user attempting the deletion.</param>
        /// <exception cref="InvalidOperationException">
        /// Thrown when the destination does not exist.
        /// </exception>
        /// <exception cref="UnauthorizedAccessException">
        /// Thrown when the user is not authorized to delete the destination.
        /// </exception>
        Task DeleteDestinationAsync(int id, string userId);

        /// <summary>
        /// Retrieves all available terrains.
        /// </summary>
        /// <returns>A collection of <see cref="TerrainViewModel"/>.</returns>
        Task<IEnumerable<TerrainViewModel>> GetAllTerrainsAsync();

        /// <summary>
        /// Retrieves the edit view model for a specific destination.
        /// </summary>
        /// <param name="id">The destination identifier.</param>
        /// <returns>
        /// A <see cref="DestinationEditViewModel"/> if found; otherwise <c>null</c>.
        /// </returns>
        Task<DestinationEditViewModel?> GetEditModelAsync(int id);

        /// <summary>
        /// Adds or updates a rating for a destination.
        /// </summary>
        /// <param name="userId">The identifier of the user providing the rating.</param>
        /// <param name="destinationId">The destination identifier.</param>
        /// <param name="stars">The rating value.</param>
        /// <param name="comment">Optional user comment.</param>
        Task AddRatingAsync(string userId, int destinationId, int stars, string comment);

        /// <summary>
        /// Retrieves all destinations (basic listing without user-specific metadata).
        /// </summary>
        /// <returns>A collection of <see cref="DestinationListViewModel"/>.</returns>
        Task<IEnumerable<DestinationListViewModel>> GetAllAsync();
    }
}
