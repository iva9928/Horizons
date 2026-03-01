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

    // 🧭 Тур гайдове:
    // - ако логнатият е гид -> Dashboard
    // - иначе показва списък с всички гидове
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

        return View(guides); // Views/Guide/Index.cshtml (твоя списък)
    }

    // 👤 Публичен профил на конкретен гид (за потребители)
    public async Task<IActionResult> Profile(string id)
    {
        if (string.IsNullOrWhiteSpace(id))
            return NotFound();

        var guide = await _userManager.Users
            .FirstOrDefaultAsync(u => u.Id == id && u.IsGuide);

        if (guide == null)
            return NotFound();

        return View(guide); // Views/Guide/Profile.cshtml
    }

    // ✅ Само за гид: негов профил + поле за публикуване на обяви
    [Authorize]
    public async Task<IActionResult> Dashboard()
    {
        var user = await _userManager.GetUserAsync(User);

        if (user == null || !user.IsGuide)
            return RedirectToAction("Index", "Home");

        return View(user); // Views/Guide/Dashboard.cshtml
    }
}