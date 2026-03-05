using Horizons.Data.Models;
using Horizons.Models;
using Horizons.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Json;
using Хоризонти.Models;

namespace Horizons.Controllers
{
    [Authorize]
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
                Seasons = GetSeasonSelectList()
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
                model.Seasons = GetSeasonSelectList();
                return View(model);
            }

            await service.AddDestinationAsync(model, GetUserId());
            return RedirectToAction(nameof(Index));
        }

        [AllowAnonymous]
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
                    .Where(d => d.Name.ToLower().Contains(normalized))
                    .ToList();
            }

            if (terrainId.HasValue)
                destinations = destinations.Where(d => d.TerrainId == terrainId).ToList();

            if (minPrice.HasValue)
                destinations = destinations.Where(d => d.TicketPrice >= minPrice).ToList();

            if (maxPrice.HasValue)
                destinations = destinations.Where(d => d.TicketPrice <= maxPrice).ToList();

            if (onlyFavorites)
            {
                var favorites = HttpContext.Session.GetString("favorites");

                if (favorites != null)
                {
                    var ids = JsonSerializer.Deserialize<List<int>>(favorites)!;
                    destinations = destinations.Where(d => ids.Contains(d.Id)).ToList();
                }
            }

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

        [AllowAnonymous]
        public async Task<IActionResult> Category(string category)
        {
            var userId = GetUserId();
            var destinations = (await service.GetAllDestinationsAsync(userId)).ToList();

            if (!string.IsNullOrWhiteSpace(category))
            {
                var normalized = category.Trim().ToLower();

                destinations = normalized switch
                {
                    "peshteri" => destinations.Where(d => d.Name.ToLower().Contains("пещер")).ToList(),

                    "zhdrela" => destinations.Where(d =>
                        d.Name.ToLower().Contains("ждрел") ||
                        d.Name.ToLower().Contains("каньон")).ToList(),

                    "skalni" => destinations.Where(d =>
                        d.Name.ToLower().Contains("скал")).ToList(),

                    "ekopateki" => destinations.Where(d =>
                        d.Name.ToLower().Contains("еко")).ToList(),

                    "vodopadi" => destinations.Where(d =>
                        d.Name.ToLower().Contains("водопад")).ToList(),

                    "ezera" => destinations.Where(d =>
                        d.Name.ToLower().Contains("езер")).ToList(),

                    "varhove" => destinations.Where(d =>
                        d.Name.ToLower().Contains("връх")).ToList(),

                    "gori" => destinations.Where(d =>
                        d.Name.ToLower().Contains("гора") ||
                        d.Name.ToLower().Contains("резерват")).ToList(),

                    _ => new List<DestinationListViewModel>()
                };
            }

            var model = new DestinationSearchViewModel
            {
                Results = destinations,
                Terrains = await service.GetAllTerrainsAsync()
            };

            return View("Index", model);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var destination = await service.GetDestinationDetailsAsync(id, GetUserId());

            if (destination == null)
                return NotFound();

            return View(destination);
        }

        // ADD FAVORITE

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddToFavorites(int id)
        {
            var favorites = HttpContext.Session.GetString("favorites");

            List<int> list;

            if (favorites == null)
                list = new List<int>();
            else
                list = JsonSerializer.Deserialize<List<int>>(favorites)!;

            if (!list.Contains(id))
                list.Add(id);

            HttpContext.Session.SetString("favorites",
                JsonSerializer.Serialize(list));

            return RedirectToAction(nameof(Details), new { id });
        }

        // REMOVE FAVORITE

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RemoveFromFavorites(int id)
        {
            var favorites = HttpContext.Session.GetString("favorites");

            if (favorites != null)
            {
                var list = JsonSerializer.Deserialize<List<int>>(favorites)!;

                list.Remove(id);

                HttpContext.Session.SetString("favorites",
                    JsonSerializer.Serialize(list));
            }

            return RedirectToAction(nameof(Details), new { id });
        }

        // FAVORITES PAGE

        public async Task<IActionResult> Favorites()
        {
            var favorites = HttpContext.Session.GetString("favorites");

            if (favorites == null)
                return View(new List<DestinationListViewModel>());

            var ids = JsonSerializer.Deserialize<List<int>>(favorites)!;

            var destinations = (await service.GetAllDestinationsAsync(GetUserId()))
                .Where(d => ids.Contains(d.Id))
                .ToList();

            return View(destinations);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Seasons()
        {
            var destinations = (await service.GetAllDestinationsAsync(GetUserId())).ToList();

            var model = new SeasonViewModel
            {
                Spring = destinations.Where(d => d.Season == Season.Spring).ToList(),
                Summer = destinations.Where(d => d.Season == Season.Summer).ToList(),
                Autumn = destinations.Where(d => d.Season == Season.Autumn).ToList(),
                Winter = destinations.Where(d => d.Season == Season.Winter).ToList()
            };

            return View(model);
        }

        private IEnumerable<SelectListItem> GetSeasonSelectList()
        {
            return Enum.GetValues(typeof(Season))
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
                });
        }
    }


}
