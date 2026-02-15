using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Horizons.Controllers
{
    /// <summary>
    /// Provides a base controller for the application,
    /// containing shared functionality for all controllers.
    /// </summary>
    /// <remarks>
    /// This controller enforces authorization and provides
    /// helper methods related to the currently authenticated user.
    /// </remarks>
    [Authorize]
    public class BaseController : Controller
    {
        /// <summary>
        /// Retrieves the identifier of the currently authenticated user.
        /// </summary>
        /// <returns>
        /// The user's unique identifier if available; otherwise an empty string.
        /// </returns>
        /// <remarks>
        /// The user identifier is extracted from the 
        /// <see cref="ClaimTypes.NameIdentifier"/> claim.
        /// </remarks>
        protected string GetUserId()
        {
            string userId = string.Empty;

            if (User != null)
            {
                userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            }

            return userId;
        }
    }
}
