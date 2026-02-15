using Horizons.Models;
using Horizons.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Хоризонти.Models;

namespace Horizons.Controllers
{
    /// <summary>
    /// Controller responsible for managing destinations including 
    /// creation, editing, deletion, searching, favorites, and rating functionality.
    /// </summary>
    public class DestinationController : BaseController
    {
        private readonly IDestinationService service;

        /// <summary>
        /// Initializes a new instance of the <see cref="DestinationController"/> class.
        /// </summary>
        /// <param name="service">Service used for destination-related operations.</param>
        public DestinationController(IDestinationService service)
        {
            this.service = service;
        }

        /// <summary>
        /// Displays the form for adding a new destination.
        /// </summary>
        /// <returns>A view with populated terrain options.</returns>
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new DestinationAddViewModel
            {
                Terrains = await service.GetAllTerrainsAsync()
            };

            return View(model);
        }

        /// <summary>
        /// Processes the submission of a new destination.
        /// </summary>
        /// <param name="model">The destination data submitted by the user.</param>
        /// <returns>
        /// Redirects to the index page if successful; 
        /// otherwise returns the form view with validation errors.
        /// </returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(DestinationAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Terrains = await service.GetAllTerrainsAsync();
                return View(model);
            }

            var userId = GetUserId();
            await service.AddDestinationAsync(model, userId);

            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Displays a list of destinations with optional filtering options.
        /// </summary>
        /// <param name="query">Search keyword for destination name.</param>
        /// <param name="terrainId">Optional terrain filter.</param>
        /// <param name="minPrice">Minimum ticket price filter.</param>
        /// <param name="maxPrice">Maximum ticket price filter.</param>
        /// <param name="onlyFavorites">Indicates whether only favorite destinations should be displayed.</param>
        /// <returns>A filtered list of destinations.</returns>
        public async Task<IActionResult> Index(
            string? query,
            int? terrainId,
            decimal? minPrice,
            decimal? maxPrice,
            bool onlyFavorites = false)
        {
            var userId = GetUserId();
            var destinations = (await service.GetAllDestinationsAsync(userId)).ToList();

            if (!string.IsNullOrWhiteSpace(query))
            {
                var normalized = query.Trim().ToLower();
                destinations = destinations
                    .Where(d => d.Name.Trim().ToLower().Contains(normalized))
                    .ToList();
            }

            if (terrainId.HasValue)
                destinations = destinations.Where(d => d.TerrainId == terrainId).ToList();

            if (minPrice.HasValue)
                destinations = destinations.Where(d => d.TicketPrice >= minPrice).ToList();

            if (maxPrice.HasValue)
                destinations = destinations.Where(d => d.TicketPrice <= maxPrice).ToList();

            if (onlyFavorites && userId != null)
                destinations = destinations.Where(d => d.IsFavorite).ToList();

            var model = new DestinationSearchViewModel
            {
                Query = query,
                TerrainId = terrainId,
                MinPrice = minPrice,
                MaxPrice = maxPrice,
                OnlyFavorites = onlyFavorites,
                Terrains = await service.GetAllTerrainsAsync(),
                Results = destinations
            };

            return View(model);
        }

        /// <summary>
        /// Displays destinations filtered by predefined category keywords.
        /// </summary>
        /// <param name="category">Category identifier used for filtering destinations.</param>
        /// <returns>The filtered destinations displayed in the index view.</returns>
        [HttpGet]
        public async Task<IActionResult> Category(string category)
        {
            var userId = GetUserId();
            var all = (await service.GetAllDestinationsAsync(userId)).ToList();

            string keyword = category?.ToLower() switch
            {
                "peshteri" => "пещер",
                "zhdrela" => "ждрел",
                "skali" => "скал",
                "ekopateki" => "екопът",
                "vodopadi" => "водопад",
                "ezera" => "езер",
                "gori" => "гор",
                "varhove" => "връх",
                "panorami" => "панорам",
                "svetilishta" => "светилищ",
                _ => ""
            };

            if (!string.IsNullOrEmpty(keyword))
            {
                all = all
                    .Where(d => d.Name != null &&
                                d.Name.Contains(keyword, System.StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            var model = new DestinationSearchViewModel
            {
                Results = all,
                Terrains = await service.GetAllTerrainsAsync()
            };

            return View("Index", model);
        }

        /// <summary>
        /// Displays the currently authenticated user's favorite destinations.
        /// </summary>
        /// <returns>A view containing favorite destinations.</returns>
        public async Task<IActionResult> Favorites()
        {
            var userId = GetUserId();
            var favs = await service.GetFavoriteDestinationsAsync(userId);

            var favorites = favs.Select(d => new DestinationListViewModel
            {
                Id = d.Id,
                Name = d.Name,
                ImageUrl = d.ImageUrl,
                Terrain = d.Terrain,
                TicketPrice = d.TicketPrice,
                IsFavorite = true,
                IsPublisher = false
            }).ToList();

            var model = new DestinationSearchViewModel
            {
                Results = favorites,
                Terrains = await service.GetAllTerrainsAsync()
            };

            return View("Index", model);
        }

        /// <summary>
        /// Displays detailed information for a specific destination.
        /// </summary>
        /// <param name="id">The unique identifier of the destination.</param>
        /// <returns>The destination details view or NotFound if it does not exist.</returns>
        public async Task<IActionResult> Details(int id)
        {
            var userId = GetUserId();
            var destinationDetails = await service.GetDestinationDetailsAsync(id, userId);

            if (destinationDetails == null)
                return NotFound();

            return View(destinationDetails);
        }

        /// <summary>
        /// Displays the edit form for a destination.
        /// </summary>
        /// <param name="id">The destination identifier.</param>
        /// <returns>The edit view if authorized; otherwise NotFound or Unauthorized.</returns>
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await service.GetEditModelAsync(id);
            if (model == null)
                return NotFound();

            var userId = GetUserId();
            if (model.PublisherId != userId && !IsAdmin())
                return Unauthorized();

            return View(model);
        }

        /// <summary>
        /// Processes the destination edit form submission.
        /// </summary>
        /// <param name="model">The updated destination data.</param>
        /// <returns>
        /// Redirects to details page if successful; 
        /// otherwise returns appropriate error response.
        /// </returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(DestinationEditViewModel model)
        {
            var userId = GetUserId();
            if (userId == null)
                return Unauthorized();

            if (!ModelState.IsValid)
            {
                model.Terrains = await service.GetAllTerrainsAsync();
                return View(model);
            }

            try
            {
                await service.EditDestinationAsync(model, userId);
            }
            catch
            {
                return BadRequest();
            }

            return RedirectToAction(nameof(Details), new { id = model.Id });
        }

        /// <summary>
        /// Displays the confirmation page for deleting a destination.
        /// </summary>
        /// <param name="id">The destination identifier.</param>
        /// <returns>The delete confirmation view.</returns>
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var destination = await service.GetDestinationByIdAsync(id);

            if (destination == null)
                return NotFound();

            var userId = GetUserId();

            if (destination.PublisherId != userId && !IsAdmin())
                return Unauthorized();

            DestinationDeleteViewModel model = new DestinationDeleteViewModel
            {
                Id = destination.Id,
                Name = destination.Name,
                PublisherId = destination.PublisherId,
                Publisher = destination.Publisher.UserName
            };

            return View(model);
        }

        /// <summary>
        /// Deletes a destination after confirmation.
        /// </summary>
        /// <param name="model">The delete confirmation model.</param>
        /// <returns>Redirects to index page if successful.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(DestinationDeleteViewModel model)
        {
            var userId = GetUserId();

            try
            {
                await service.DeleteDestinationAsync(model.Id, userId);
            }
            catch
            {
                return BadRequest();
            }

            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Adds a destination to the user's favorites.
        /// </summary>
        /// <param name="id">The destination identifier.</param>
        /// <returns>Redirects to the destination details page.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddToFavorites(int id)
        {
            var userId = GetUserId();
            await service.AddToFavoritesAsync(userId, id);
            return RedirectToAction(nameof(Details), new { id });
        }

        /// <summary>
        /// Removes a destination from the user's favorites.
        /// </summary>
        /// <param name="id">The destination identifier.</param>
        /// <returns>Redirects to the destination details page.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveFromFavorites(int id)
        {
            var userId = GetUserId();
            await service.RemoveFromFavoritesAsync(userId, id);
            return RedirectToAction(nameof(Details), new { id });
        }

        /// <summary>
        /// Adds a rating and optional comment to a destination.
        /// </summary>
        /// <param name="id">The destination identifier.</param>
        /// <param name="stars">The rating value.</param>
        /// <param name="comment">Optional user comment.</param>
        /// <returns>Redirects to the destination details page.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Rate(int id, int stars, string comment)
        {
            if (!User.Identity.IsAuthenticated)
                return Unauthorized();

            var userId = GetUserId();
            await service.AddRatingAsync(userId, id, stars, comment);

            return RedirectToAction("Details", new { id });
        }

        /// <summary>
        /// Determines whether the currently authenticated user is an administrator.
        /// </summary>
        /// <returns>True if the user is administrator; otherwise false.</returns>
        private bool IsAdmin()
        {
            return User.Identity?.Name == "admin@horizons.com";
        }
    }
}
