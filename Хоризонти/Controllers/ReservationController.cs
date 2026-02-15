using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Horizons.Models;
using Horizons.Services;

namespace Horizons.Controllers
{
    /// <summary>
    /// Controller responsible for handling reservation-related operations,
    /// including creating reservations and viewing user or administrator reservations.
    /// </summary>
    /// <remarks>
    /// All actions in this controller require authenticated users.
    /// </remarks>
    [Authorize]
    public class ReservationController : BaseController
    {
        private readonly IReservationService reservationService;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReservationController"/> class.
        /// </summary>
        /// <param name="reservationService">
        /// Service responsible for reservation business logic and data access.
        /// </param>
        public ReservationController(IReservationService reservationService)
        {
            this.reservationService = reservationService;
        }

        /// <summary>
        /// Displays the reservation creation form for a specific destination.
        /// </summary>
        /// <param name="destinationId">The identifier of the destination to reserve.</param>
        /// <returns>
        /// A populated reservation creation view model if the destination exists;
        /// otherwise returns <see cref="NotFoundResult"/>.
        /// </returns>
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

        /// <summary>
        /// Processes the reservation creation form submission.
        /// </summary>
        /// <param name="model">The reservation data submitted by the user.</param>
        /// <returns>
        /// Redirects to the user's reservations page if successful;
        /// otherwise returns the form view with validation errors.
        /// </returns>
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

            return RedirectToAction(nameof(My));
        }

        /// <summary>
        /// Displays all reservations made by the currently authenticated user.
        /// </summary>
        /// <returns>A view containing the user's reservations.</returns>
        [HttpGet]
        public async Task<IActionResult> My()
        {
            var userId = GetUserId();
            var reservations = await reservationService.GetUserReservationsAsync(userId);
            return View(reservations);
        }

        /// <summary>
        /// Displays all reservations in the system (administrator only).
        /// </summary>
        /// <returns>
        /// A view containing all reservations if the current user is an administrator;
        /// otherwise returns <see cref="ForbidResult"/>.
        /// </returns>
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
