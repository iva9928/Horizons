using Horizons.Data.Models;

namespace Horizons.Services
{
    public interface IMessageService
    {
        Task SendMessageAsync(string senderId, string receiverId, string content);

        Task<List<Message>> GetConversationAsync(string user1, string user2);

        Task<List<string>> GetUsersWhoMessagedGuideAsync(string guideId);

        Task<List<Message>> GetPublicMessagesAsync();

        Task SendPublicMessageAsync(string senderId, string content);
    }
}