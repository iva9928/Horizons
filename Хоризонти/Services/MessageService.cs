using Horizons.Data;
using Horizons.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Horizons.Services
{
    public class MessageService : IMessageService
    {
        private readonly ApplicationDbContext context;

        public MessageService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task SendMessageAsync(string senderId, string receiverId, string content)
        {
            var message = new Message
            {
                SenderId = senderId,
                ReceiverId = receiverId,
                Content = content,
                IsPublic = false
            };

            await context.Messages.AddAsync(message);
            await context.SaveChangesAsync();
        }

        public async Task<List<Message>> GetConversationAsync(string user1, string user2)
        {
            return await context.Messages
                .Include(m => m.Sender)
                .Where(m =>
                    !m.IsPublic &&
                    ((m.SenderId == user1 && m.ReceiverId == user2) ||
                     (m.SenderId == user2 && m.ReceiverId == user1)))
                .OrderBy(m => m.SentOn)
                .ToListAsync();
        }

        public async Task<List<string>> GetUsersWhoMessagedGuideAsync(string guideId)
        {
            return await context.Messages
                .Where(m => !m.IsPublic &&
                    (m.ReceiverId == guideId || m.SenderId == guideId))
                .Select(m => m.SenderId == guideId ? m.ReceiverId! : m.SenderId)
                .Distinct()
                .ToListAsync();
        }

        public async Task<List<Message>> GetPublicMessagesAsync()
        {
            return await context.Messages
                .Include(m => m.Sender)
                .Where(m => m.IsPublic)
                .OrderByDescending(m => m.SentOn)
                .ToListAsync();
        }

        public async Task SendPublicMessageAsync(string senderId, string content)
        {
            var message = new Message
            {
                SenderId = senderId,
                Content = content,
                IsPublic = true
            };

            await context.Messages.AddAsync(message);
            await context.SaveChangesAsync();
        }
    }
}