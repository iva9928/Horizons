using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

[Authorize]
public class GuideController : Controller
{
    private readonly UserManager<ApplicationUser> _userManager;

    public GuideController(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IActionResult> Index()
    {
        return await Dashboard();
    }

    public async Task<IActionResult> Dashboard()
    {
        var user = await _userManager.GetUserAsync(User);

        if (!user!.IsGuide)
            return RedirectToAction("Index", "Home");

        return View("Dashboard", user);
    }
}