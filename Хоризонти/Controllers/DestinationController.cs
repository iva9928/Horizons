using Horizons.Models;
using Horizons.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Horizons.Controllers
{
    public class DestinationController : BaseController
    {
        private readonly IDestinationService service;

        public DestinationController(IDestinationService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new DestinationAddViewModel
            {
                Terrains = await service.GetAllTerrainsAsync()
            };

            return View(model);
        }

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

        public async Task<IActionResult> Details(int id)
        {
            var userId = GetUserId();
            var destinationDetails = await service.GetDestinationDetailsAsync(id, userId);

            if (destinationDetails == null)
                return NotFound();

            return View(destinationDetails);
        }

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddToFavorites(int id)
        {
            var userId = GetUserId();
            await service.AddToFavoritesAsync(userId, id);
            return RedirectToAction(nameof(Details), new { id });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveFromFavorites(int id)
        {
            var userId = GetUserId();
            await service.RemoveFromFavoritesAsync(userId, id);
            return RedirectToAction(nameof(Details), new { id });
        }

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

        private bool IsAdmin()
        {
            return User.Identity?.Name == "admin@horizons.com";
        }
    }
}
