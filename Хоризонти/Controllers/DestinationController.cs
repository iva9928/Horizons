using Horizons.Data.Models;
using Horizons.Models;
using Horizons.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;
using Хоризонти.Models;

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
                Terrains = await service.GetAllTerrainsAsync(),
                Seasons = Enum.GetValues(typeof(Season))
                    .Cast<Season>()
                    .Select(s => new SelectListItem
                    {
                        Value = ((int)s).ToString(),
                        Text = s switch
                        {
                            Season.Spring => "Пролет",
                            Season.Summer => "Лято",
                            Season.Autumn => "Есен",
                            Season.Winter => "Зима",
                            _ => s.ToString()
                        }
                    })
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
                model.Seasons = Enum.GetValues(typeof(Season))
                    .Cast<Season>()
                    .Select(s => new SelectListItem
                    {
                        Value = ((int)s).ToString(),
                        Text = s.ToString()
                    });

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

        public async Task<IActionResult> Details(int id)
        {
            var userId = GetUserId();
            var destinationDetails = await service.GetDestinationDetailsAsync(id, userId);

            if (destinationDetails == null)
                return NotFound();

            return View(destinationDetails);
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

        public async Task<IActionResult> Seasons()
        {
            var userId = GetUserId();
            var destinations = (await service.GetAllDestinationsAsync(userId)).ToList();

            var model = new SeasonViewModel
            {
                Spring = destinations.Where(d => d.Season == Season.Spring).ToList(),
                Summer = destinations.Where(d => d.Season == Season.Summer).ToList(),
                Autumn = destinations.Where(d => d.Season == Season.Autumn).ToList(),
                Winter = destinations.Where(d => d.Season == Season.Winter).ToList()
            };

            return View(model);
        }

        private bool IsAdmin()
        {
            return User.Identity?.Name == "admin@horizons.com";
        }
    }
}
