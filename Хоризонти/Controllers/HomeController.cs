using Horizons.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Horizons.Controllers
{
    /// <summary>
    /// Controller responsible for handling general application entry points
    /// and system-level pages such as the home and error views.
    /// </summary>
    public class HomeController : BaseController
    {
        /// <summary>
        /// Displays the application home page.
        /// </summary>
        /// <remarks>
        /// If the user is authenticated, they are redirected
        /// to the destination listing page.
        /// </remarks>
        /// <returns>
        /// The home view for anonymous users or a redirect to
        /// <c>Destination/Index</c> for authenticated users.
        /// </returns>
        [AllowAnonymous]
        public IActionResult Index()
        {
            if (User?.Identity?.IsAuthenticated ?? false)
            {
                return RedirectToAction("Index", "Destination");
            }

            return View();
        }

        /// <summary>
        /// Displays the error page.
        /// </summary>
        /// <returns>
        /// A view containing error details including the request identifier.
        /// </returns>
        /// <remarks>
        /// Response caching is disabled for this action to ensure
        /// accurate error reporting.
        /// </remarks>
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}
