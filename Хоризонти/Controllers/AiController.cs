using Microsoft.AspNetCore.Mvc;
using Horizons.Data;
using Horizons.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

public class AIController : Controller
{
    private readonly ApplicationDbContext _context;

    public AIController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult Ask(string message)
    {
        if (string.IsNullOrWhiteSpace(message))
            return Json("Моля въведи въпрос 🙂");

        message = message.ToLower();

        var destinations = _context.Destinations
            .Where(d => !d.IsDeleted)
            .ToList();

        // =========================
        // 🎯 ТЪРСЕНЕ ПО ИМЕ
        // =========================
        var specificPlace = destinations
            .FirstOrDefault(d => message.Contains(d.Name.ToLower()));

        if (specificPlace != null)
        {
            return Json(
                $"📍 {specificPlace.Name}\n" +
                $"📌 Локация: {specificPlace.Location}\n" +
                $"💰 Цена: {specificPlace.TicketPrice} лв\n" +
                $"🎥 Видео: {specificPlace.VideoUrl}"
            );
        }

        // =========================
        // 🌤 СЕЗОН
        // =========================
        Season? season = null;

        if (message.Contains("зима")) season = Season.Winter;
        if (message.Contains("лято")) season = Season.Summer;
        if (message.Contains("пролет")) season = Season.Spring;
        if (message.Contains("есен")) season = Season.Autumn;

        // =========================
        // 🏔 ТЕРЕН
        // =========================
        int? terrainId = null;

        if (message.Contains("пещер")) terrainId = 1;
        if (message.Contains("ждрел") || message.Contains("каньон")) terrainId = 2;
        if (message.Contains("скал")) terrainId = 3;
        if (message.Contains("екопътека")) terrainId = 4;
        if (message.Contains("водопад")) terrainId = 5;
        if (message.Contains("езеро") || message.Contains("язовир")) terrainId = 6;
        if (message.Contains("гора") || message.Contains("резерват")) terrainId = 7;
        if (message.Contains("връх")) terrainId = 8;
        if (message.Contains("панорам")) terrainId = 9;
        if (message.Contains("светилище")) terrainId = 10;

        // =========================
        // 💰 ЦЕНА
        // =========================
        decimal? maxPrice = null;

        if (message.Contains("безплат")) maxPrice = 0;
        if (message.Contains("под 5")) maxPrice = 5;
        if (message.Contains("под 10")) maxPrice = 10;

        // =========================
        // 🔎 ФИЛТРИРАНЕ
        // =========================
        var query = destinations.AsQueryable();

        if (season.HasValue)
            query = query.Where(d => d.Season == season.Value);

        if (terrainId.HasValue)
            query = query.Where(d => d.TerrainId == terrainId.Value);

        if (maxPrice.HasValue)
            query = query.Where(d => d.TicketPrice <= maxPrice.Value);

        var results = query.Take(5).ToList();

        if (results.Any())
        {
            var response = "✨ Препоръчвам ти:\n\n";

            foreach (var d in results)
            {
                response += $"• {d.Name} ({d.TicketPrice} лв)\n";
            }

            return Json(response);
        }

        // =========================
        // 🤖 ПОМОЩ
        // =========================
        return Json(
            "Можеш да ме попиташ:\n" +
            "• Къде да отида през зимата?\n" +
            "• Безплатни водопади\n" +
            "• Езера под 5 лв\n" +
            "• Разкажи ми за Белинташ\n" +
            "• Пролетни екопътеки\n"
        );
    }
}
