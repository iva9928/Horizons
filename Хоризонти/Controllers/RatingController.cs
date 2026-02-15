using Horizons.Controllers;
using Horizons.Data;
using Horizons.Data.Models;
using Horizons.Extensions;
using Horizons.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

/// <summary>
/// Controller responsible for managing rating-related operations,
/// including listing all ratings (admin only) and adding new ratings.
/// </summary>
public class RatingController : BaseController
{
    private readonly ApplicationDbContext context;

    /// <summary>
    /// Initializes a new instance of the <see cref="RatingController"/> class.
    /// </summary>
    /// <param name="ctx">The application database context used for data access.</param>
    public RatingController(ApplicationDbContext ctx)
    {
        context = ctx;
    }

    /// <summary>
    /// Displays all ratings in the system.
    /// </summary>
    /// <remarks>
    /// This action is accessible only to the administrator.
    /// </remarks>
    /// <returns>
    /// A view containing a list of all ratings if the user is an administrator;
    /// otherwise returns <see cref="UnauthorizedResult"/>.
    /// </returns>
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

    /// <summary>
    /// Adds a new rating for a specific destination.
    /// </summary>
    /// <param name="destinationId">The identifier of the destination being rated.</param>
    /// <param name="stars">The rating value given by the user.</param>
    /// <param name="comment">Optional comment provided by the user.</param>
    /// <returns>
    /// Redirects to the destination details page after successfully saving the rating.
    /// </returns>
    /// <remarks>
    /// The rating is associated with the currently authenticated user.
    /// </remarks>
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
