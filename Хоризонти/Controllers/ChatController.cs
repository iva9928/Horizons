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
            => User.FindFirst(ClaimTypes.NameIdentifier)!.Value;

        // ================= GUIDE BOARD =================

        [HttpGet]
        public async Task<IActionResult> GuideBoard(string guideId)
        {
            var currentUserId = GetUserId();

            if (string.IsNullOrEmpty(guideId))
                return NotFound();

            if (currentUserId != guideId)
                return Unauthorized();

            var guide = await context.Users
                .FirstOrDefaultAsync(u => u.Id == guideId);

            if (guide == null)
                return NotFound();

            var messages = await context.Messages
                .Where(m => m.ReceiverId == guideId)
                .OrderByDescending(m => m.SentOn)
                .ToListAsync();

            ViewBag.GuideEmail = guide.Email;

            return View(messages);
        }

        // ================= USER → GUIDE CHAT =================

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

            return View(messages);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendToGuide(string guideId, string content)
        {
            var userId = GetUserId();

            if (string.IsNullOrWhiteSpace(content))
                return RedirectToAction(nameof(ChatWithGuide), new { guideId });

            var message = new Message
            {
                SenderId = userId,
                ReceiverId = guideId,
                Content = content,
                SentOn = DateTime.UtcNow,
                IsPublic = false
            };

            await context.Messages.AddAsync(message);
            await context.SaveChangesAsync();

            return RedirectToAction(nameof(ChatWithGuide), new { guideId });
        }
    }
}