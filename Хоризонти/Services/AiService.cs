using OpenAI;
using OpenAI.Chat;
using Microsoft.Extensions.Configuration;

namespace Horizons.Services
{
    public class AiService : IAiService
    {
        private readonly string apiKey;

        public AiService(IConfiguration configuration)
        {
            apiKey = configuration["OpenAI:ApiKey"];
        }

        public async Task<string> AskAsync(string question)
        {
            var client = new OpenAIClient(apiKey);

            var chat = client.GetChatClient("gpt-4o-mini");

            var response = await chat.CompleteChatAsync(
                $"Ти си туристически AI асистент за сайт Horizons. " +
                $"Препоръчвай дестинации от Родопите. " +
                $"Отговаряй на български.\n\nПотребител: {question}"
            );

            return response.Value.Content[0].Text;
        }
    }
}