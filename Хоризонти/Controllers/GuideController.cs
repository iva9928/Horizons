using Horizons.Data;
using Horizons.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Horizons.Controllers
{
    public class GuideController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<ApplicationUser> userManager;

        public GuideController(ApplicationDbContext context,
                               UserManager<ApplicationUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            if (User.IsInRole("Guide"))
            {
                var currentUser = await userManager.GetUserAsync(User);
                return RedirectToAction("Profile", new { id = currentUser.Id });
            }

            var guides = await context.Users
                .Where(u => u.Bio != null)
                .ToListAsync();

            return View(guides);
        }

        public async Task<IActionResult> Profile(string id)
        {
            var guide = await context.Users
                .FirstOrDefaultAsync(u => u.Id == id);

            if (guide == null)
                return NotFound();

            return View(guide);
        }

        [Authorize(Roles = "Guide")]
        public async Task<IActionResult> MyProfile()
        {
            var user = await userManager.GetUserAsync(User);

            if (user == null)
                return NotFound();

            return View("Profile", user);
        }
    }
}