using Horizons.Data;
using Horizons.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Horizons.Controllers
{
    [Authorize]
    public class ChatController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ChatController(ApplicationDbContext context,
            UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> PublicChat(int destinationId)
        {
            var messages = await _context.Messages
                .Where(m => m.IsPublic && m.DestinationId == destinationId)
                .Include(m => m.Sender)
                .OrderBy(m => m.SentOn)
                .ToListAsync();

            ViewBag.DestinationId = destinationId;
            return View(messages);
        }

        [HttpPost]
        public async Task<IActionResult> SendPublic(int destinationId, string content)
        {
            var user = await _userManager.GetUserAsync(User);

            var message = new Message
            {
                SenderId = user!.Id,
                ReceiverId = user.Id,
                Content = content,
                SentOn = DateTime.Now,
                IsPublic = true,
                DestinationId = destinationId
            };

            _context.Messages.Add(message);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(PublicChat), new { destinationId });
        }

        public async Task<IActionResult> Inbox()
        {
            var user = await _userManager.GetUserAsync(User);

            var messages = await _context.Messages
                .Where(m => !m.IsPublic &&
                            (m.SenderId == user!.Id || m.ReceiverId == user.Id))
                .Include(m => m.Sender)
                .Include(m => m.Receiver)
                .OrderByDescending(m => m.SentOn)
                .ToListAsync();

            return View(messages);
        }

        [HttpPost]
        public async Task<IActionResult> SendPrivate(string receiverId, string content)
        {
            var sender = await _userManager.GetUserAsync(User);

            var message = new Message
            {
                SenderId = sender!.Id,
                ReceiverId = receiverId,
                Content = content,
                SentOn = DateTime.Now,
                IsPublic = false
            };

            _context.Messages.Add(message);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Inbox));
        }
    }
}