using Horizons.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class GuideController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;


public GuideController(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IActionResult> Index()
    {
        if (User.Identity?.IsAuthenticated == true)
        {
            var current = await _userManager.GetUserAsync(User);

            if (current != null && current.IsGuide)
            {
                return RedirectToAction(nameof(Dashboard));
            }
        }

        var guides = await _userManager.Users
            .Where(u => u.IsGuide)
            .ToListAsync();

        return View(guides);
    }

    public async Task<IActionResult> Profile(string id)
    {
        if (string.IsNullOrWhiteSpace(id))
            return NotFound();

        var guide = await _userManager.Users
            .FirstOrDefaultAsync(u => u.Id == id && u.IsGuide);

        if (guide == null)
            return NotFound();

        return View(guide);
    }

    [Authorize]
    public async Task<IActionResult> Dashboard()
    {
        var user = await _userManager.GetUserAsync(User);

        if (user == null || !user.IsGuide)
            return RedirectToAction("Index", "Home");

        return View(user);
    }


}
