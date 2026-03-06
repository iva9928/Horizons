using Horizons.Data.Models;
using Horizons.Models;
using Horizons.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.Json;
using Хоризонти.Models;

namespace Horizons.Controllers
{
    public class DestinationController : BaseController
    {
        private readonly IDestinationService service;
        private readonly UserManager<ApplicationUser> userManager;

        public DestinationController(
            IDestinationService service,
            UserManager<ApplicationUser> userManager)
        {
            this.service = service;
            this.userManager = userManager;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index(
            string? query,
            int? terrainId,
            decimal? minPrice,
            decimal? maxPrice)
        {
            var userId = User.Identity?.IsAuthenticated == true ? GetUserId() : null;

            var destinations = (await service.GetAllDestinationsAsync(userId)).ToList();

            if (!string.IsNullOrWhiteSpace(query))
                destinations = destinations
                    .Where(d => d.Name.ToLower().Contains(query.ToLower()))
                    .ToList();

            if (terrainId.HasValue)
                destinations = destinations.Where(d => d.TerrainId == terrainId).ToList();

            if (minPrice.HasValue)
                destinations = destinations.Where(d => d.TicketPrice >= minPrice).ToList();

            if (maxPrice.HasValue)
                destinations = destinations.Where(d => d.TicketPrice <= maxPrice).ToList();

            var model = new DestinationSearchViewModel
            {
                Query = query,
                TerrainId = terrainId,
                MinPrice = minPrice,
                MaxPrice = maxPrice,
                Terrains = await service.GetAllTerrainsAsync(),
                Results = destinations
            };

            return View(model);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var userId = User.Identity?.IsAuthenticated == true ? GetUserId() : null;

            var destination = await service.GetDestinationDetailsAsync(id, userId);

            if (destination == null)
                return NotFound();

            return View(destination);
        }

        [Authorize]
        public async Task<IActionResult> Favorites()
        {
            var destinations = await service.GetFavoriteDestinationsAsync(GetUserId());
            return View(destinations);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new DestinationAddViewModel
            {
                Terrains = await service.GetAllTerrainsAsync(),
                Seasons = GetSeasonSelectList(),
                PublishedOn = DateTime.Now.ToString("dd-MM-yyyy")
            };

            return View(model);
        }

        [Authorize(Roles = "Admin")]
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

        private IEnumerable<SelectListItem> GetSeasonSelectList()
        {
            return Enum.GetValues(typeof(Season))
                .Cast<Season>()
                .Select(s => new SelectListItem
                {
                    Value = ((int)s).ToString(),
                    Text = s.ToString()
                });
        }
    }
}