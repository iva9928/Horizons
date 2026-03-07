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

        // ================= PUBLIC CHAT =================

        public async Task<IActionResult> PublicChat()
        {
            var messages = await context.Messages
                .Include(m => m.Sender)
                .Where(m => m.IsPublic)
                .OrderByDescending(m => m.SentOn)
                .ToListAsync();

            return View(messages);
        }

        [Authorize(Roles = "Guide")]
        [HttpPost]
        public async Task<IActionResult> SendPublic(string content)
        {
            if (string.IsNullOrWhiteSpace(content))
                return RedirectToAction("PublicChat");

            var message = new Message
            {
                SenderId = GetUserId(),
                Content = content,
                SentOn = DateTime.UtcNow,
                IsPublic = true
            };

            context.Messages.Add(message);
            await context.SaveChangesAsync();

            return RedirectToAction("PublicChat");
        }

        // ================= GUIDE BOARD =================
        [Authorize(Roles = "Guide")]
        public async Task<IActionResult> GuideBoard()
        {
            var guideId = GetUserId();

            var users = await context.Messages
                .Where(m => !m.IsPublic && m.ReceiverId == guideId && m.SenderId != guideId)
                .Select(m => m.Sender)
                .Distinct()
                .ToListAsync();

            return View(users);
        }
        // ================= USER CHAT =================

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

            var guide = await context.Users.FirstOrDefaultAsync(u => u.Id == guideId);

            ViewBag.GuideId = guideId;
            ViewBag.GuideEmail = guide?.Email;

            return View("ConversationView", messages);
        }
        // ================= GUIDE CHAT =================

        [Authorize(Roles = "Guide")]
        public async Task<IActionResult> ChatWithUser(string userId)
        {
            var guideId = GetUserId();

            var messages = await context.Messages
                .Where(m =>
                    (m.SenderId == userId && m.ReceiverId == guideId) ||
                    (m.SenderId == guideId && m.ReceiverId == userId))
                .Include(m => m.Sender)
                .OrderBy(m => m.SentOn)
                .ToListAsync();

            var user = await context.Users.FirstOrDefaultAsync(u => u.Id == userId);

            ViewBag.UserId = userId;
            ViewBag.UserEmail = user?.Email;

            return View("ConversationView", messages);
        }
        // ================= SEND PRIVATE =================

        [HttpPost]
        public async Task<IActionResult> SendToGuide(string guideId, string content)
        {
            if (string.IsNullOrWhiteSpace(content))
                return RedirectToAction("ChatWithGuide", new { guideId });

            var message = new Message
            {
                SenderId = GetUserId(),
                ReceiverId = guideId,
                Content = content,
                SentOn = DateTime.UtcNow,
                IsPublic = false
            };

            context.Messages.Add(message);
            await context.SaveChangesAsync();

            return RedirectToAction("ChatWithGuide", new { guideId });
        }

        [HttpPost]
        public async Task<IActionResult> SendToUser(string userId, string content)
        {
            if (string.IsNullOrWhiteSpace(content))
                return RedirectToAction("ChatWithUser", new { userId });

            var message = new Message
            {
                SenderId = GetUserId(),
                ReceiverId = userId,
                Content = content,
                SentOn = DateTime.UtcNow,
                IsPublic = false
            };

            context.Messages.Add(message);
            await context.SaveChangesAsync();

            return RedirectToAction("ChatWithUser", new { userId });
        }
    }
}