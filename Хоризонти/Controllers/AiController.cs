using Microsoft.AspNetCore.Mvc;
using Horizons.Data;
using Horizons.Services;
using Microsoft.EntityFrameworkCore;

namespace Horizons.Controllers
{
    public class AIController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly IAiService aiService;

        public AIController(ApplicationDbContext context, IAiService aiService)
        {
            this.context = context;
            this.aiService = aiService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Ask(string message)
        {
            if (string.IsNullOrWhiteSpace(message))
                return Json("Моля въведи въпрос 🙂");

            var lowerMessage = message.ToLower();

            var destinations = await context.Destinations
                .Where(d => !d.IsDeleted)
                .ToListAsync();

            var specificPlace = destinations
                .FirstOrDefault(d => lowerMessage.Contains(d.Name.ToLower()));

            if (specificPlace != null)
            {
                var result =
                    $"📍 {specificPlace.Name}\n" +
                    $"📌 Локация: {specificPlace.Location}\n" +
                    $"💰 Цена: {specificPlace.TicketPrice} лв\n" +
                    $"🎥 Видео: {specificPlace.VideoUrl}";

                return Json(result);
            }

            var aiAnswer = await aiService.AskAsync(message);

            if (string.IsNullOrWhiteSpace(aiAnswer))
                aiAnswer = "Не успях да намеря информация 🤔";

            return Json(aiAnswer);
        }
    }
}