using Horizons.Models;
using Horizons.Services;
using Microsoft.AspNetCore.Mvc;
using System;
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

        public async Task<IActionResult> Index(decimal? minPrice, decimal? maxPrice)
        {
            var userId = GetUserId();
            var destinations = await service.GetAllDestinationsAsync(userId);

            if (minPrice.HasValue)
                destinations = destinations
                    .Where(d => d.TicketPrice >= minPrice.Value)
                    .ToList();

            if (maxPrice.HasValue)
                destinations = destinations
                    .Where(d => d.TicketPrice <= maxPrice.Value)
                    .ToList();

            ViewBag.MinPrice = minPrice;
            ViewBag.MaxPrice = maxPrice;

            return View(destinations);
        }

        [HttpGet]
        public async Task<IActionResult> Category(string category)
        {
            var userId = GetUserId();
            var destinations = await service.GetAllDestinationsAsync(userId);

            if (string.IsNullOrWhiteSpace(category))
                return View("Index", destinations);

            string keyword = category.ToLower() switch
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
                destinations = destinations
                    .Where(d =>
                        !string.IsNullOrEmpty(d.Name) &&
                        d.Name.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            return View("Index", destinations);
        }

        public async Task<IActionResult> Favorites()
        {
            var userId = GetUserId();
            var favoriteDestinations = await service.GetFavoriteDestinationsAsync(userId);

            return View(favoriteDestinations);
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
            catch (InvalidOperationException)
            {
                return NotFound();
            }
            catch (UnauthorizedAccessException)
            {
                return Unauthorized();
            }

            return RedirectToAction(nameof(Details), new { id = model.Id });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var destination = await service.GetDestinationByIdAsync(id);

            if (destination == null)
                return BadRequest();

            string userId = GetUserId();

            if (destination.PublisherId != userId && !IsAdmin())
                return Unauthorized();

            if (destination.Publisher == null)
                return BadRequest("Publisher details missing.");

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
            if (userId == null)
                return Unauthorized();

            try
            {
                await service.DeleteDestinationAsync(model.Id, userId);
            }
            catch (InvalidOperationException)
            {
                return BadRequest();
            }
            catch (UnauthorizedAccessException)
            {
                return Unauthorized();
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
