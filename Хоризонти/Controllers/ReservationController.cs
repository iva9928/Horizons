using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Horizons.Models;
using Horizons.Services;

namespace Horizons.Controllers
{
    [Authorize]
    public class ReservationController : BaseController
    {
        private readonly IReservationService reservationService;

        public ReservationController(IReservationService reservationService)
        {
            this.reservationService = reservationService;
        }

        [HttpGet]
        public async Task<IActionResult> Create(int destinationId)
        {
            var model = await reservationService.GetCreateModelAsync(destinationId);
            if (model == null)
            {
                return NotFound();
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ReservationCreateViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userId = GetUserId();
            await reservationService.CreateReservationAsync(model, userId);

            // по желание – можеш да редиректнеш към "Моите резервации"
            return RedirectToAction(nameof(My));
        }

        [HttpGet]
        public async Task<IActionResult> My()
        {
            var userId = GetUserId();
            var reservations = await reservationService.GetUserReservationsAsync(userId);
            return View(reservations);
        }

        [HttpGet]
        public async Task<IActionResult> Admin()
        {
            if (!User.Identity!.Name!.Equals("admin@horizons.com",
                    StringComparison.OrdinalIgnoreCase))
            {
                return Forbid();
            }

            var reservations = await reservationService.GetAllReservationsAsync();
            return View(reservations);
        }
    }
}
