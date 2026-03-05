using Horizons.Data;
using Horizons.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Horizons.Controllers
{
    [Authorize]
    public class ChatController : Controller
    {
        private readonly ApplicationDbContext context;


    public ChatController(ApplicationDbContext context)
        {
            this.context = context;
        }

        private string GetUserId()
        {
            return User.FindFirst(ClaimTypes.NameIdentifier)!.Value;
        }

        // GUIDE BOARD (гидът вижда всички съобщения към него)

        [HttpGet]
        public async Task<IActionResult> GuideBoard(string guideId)
        {
            var currentUserId = GetUserId();

            if (currentUserId != guideId)
                return Unauthorized();

            var guide = await context.Users
                .FirstOrDefaultAsync(u => u.Id == guideId);

            if (guide == null)
                return NotFound();

            var messages = await context.Messages
                .Where(m => m.ReceiverId == guideId)
                .Include(m => m.Sender)
                .OrderByDescending(m => m.SentOn)
                .ToListAsync();

            ViewBag.GuideEmail = guide.Email;

            return View(messages);
        }

        // ЛИЧЕН ЧАТ МЕЖДУ ПОТРЕБИТЕЛ И ГИД

        [HttpGet]
        public async Task<IActionResult> ChatWithGuide(string guideId)
        {
            var userId = GetUserId();

            var messages = await context.Messages
                .Where(m =>
                    (m.SenderId == userId && m.ReceiverId == guideId) ||
                    (m.SenderId == guideId && m.ReceiverId == userId))
                .Include(m => m.Sender)
                .OrderBy(m => m.SentOn)
                .ToListAsync();

            ViewBag.GuideId = guideId;

            return View("ConversationView", messages);
        }

        // ПОТРЕБИТЕЛ → ПИШЕ НА ГИД

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendToGuide(string guideId, string content)
        {
            var userId = GetUserId();

            if (string.IsNullOrWhiteSpace(content))
                return RedirectToAction("ChatWithGuide", new { guideId });

            var message = new Message
            {
                SenderId = userId,
                ReceiverId = guideId,
                Content = content,
                SentOn = DateTime.UtcNow,
                IsPublic = false
            };

            context.Messages.Add(message);
            await context.SaveChangesAsync();

            return RedirectToAction("ChatWithGuide", new { guideId });
        }

        // ГИД → ПИШЕ ОБЩО СЪОБЩЕНИЕ (виждат го всички)

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendPublic(string content)
        {
            var guideId = GetUserId();

            var message = new Message
            {
                SenderId = guideId,
                ReceiverId = null,
                Content = content,
                SentOn = DateTime.UtcNow,
                IsPublic = true
            };

            context.Messages.Add(message);
            await context.SaveChangesAsync();

            return RedirectToAction("Dashboard", "Guide");
        }

        // ПОТРЕБИТЕЛСКИ INBOX

        [HttpGet]
        public async Task<IActionResult> Inbox()
        {
            var userId = GetUserId();

            var messages = await context.Messages
                .Where(m =>
                    m.IsPublic ||
                    m.ReceiverId == userId ||
                    m.SenderId == userId)
                .Include(m => m.Sender)
                .OrderByDescending(m => m.SentOn)
                .ToListAsync();

            return View(messages);
        }
    }


}
