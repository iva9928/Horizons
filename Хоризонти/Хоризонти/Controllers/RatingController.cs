using Horizons.Controllers;
using Horizons.Data;
using Horizons.Data.Models;
using Horizons.Extensions;
using Horizons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class RatingController : BaseController
{
    private readonly ApplicationDbContext context;

    public RatingController(ApplicationDbContext ctx)
    {
        context = ctx;
    }

    public async Task<IActionResult> All()
    {
        if (User.Identity?.Name != "admin@horizons.com")
            return Unauthorized();

        var list = await context.Ratings
            .Include(r => r.User)
            .Include(r => r.Destination)
            .Select(r => new RatingAdminViewModel
            {
                Id = r.Id,
                UserName = r.User.UserName!,
                DestinationName = r.Destination.Name,
                Stars = r.Stars,
                Comment = r.Comment,
                CreatedOn = r.CreatedOn.ToString("dd-MM-yyyy")
            })
            .ToListAsync();

        return View(list);
    }

    [HttpPost]
    public async Task<IActionResult> Add(int destinationId, int stars, string comment)
    {
        var userId = User.GetUserId();

        await context.Ratings.AddAsync(new Rating
        {
            UserId = userId,
            DestinationId = destinationId,
            Stars = stars,
            Comment = comment,
            CreatedOn = DateTime.Now
        });

        await context.SaveChangesAsync();

        return RedirectToAction("Details", "Destination", new { id = destinationId });
    }
}
