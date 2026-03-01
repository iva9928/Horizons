// =========================
// ✅ НОВ: TourController + Details (минимално, за да имаш "тур във вюто")
// Път: Controllers/TourController.cs
// =========================
using Horizons.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Horizons.Controllers
{
    public class TourController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TourController(ApplicationDbContext context)
        {
            _context = context;
        }

        // /Tour/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var tour = await _context.Tours
                .Include(t => t.Guide)
                .Include(t => t.Destination)
                .FirstOrDefaultAsync(t => t.Id == id);

            if (tour == null) return NotFound();

            return View(tour); // Views/Tour/Details.cshtml
        }
    }
}