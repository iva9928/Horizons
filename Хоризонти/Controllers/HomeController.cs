using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Horizons.Data.Models;
using System.Security.Claims;

namespace Horizons.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                if (User.IsInRole("Guide"))
                {
                    var guideId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

                    return RedirectToAction("Profile", "Guide", new { id = guideId });
                }

                if (User.IsInRole("Admin") || User.IsInRole("User"))
                {
                    return RedirectToAction("Index", "Destination");
                }
            }

            return RedirectToAction("Index", "Destination");
        }
    }
}