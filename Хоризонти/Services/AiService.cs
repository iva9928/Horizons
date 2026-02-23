using OpenAI;
using OpenAI.Chat;
using Microsoft.Extensions.Configuration;

public class AiService : IAiService
{
    private readonly string _apiKey;

    public AiService(IConfiguration configuration)
    {
        _apiKey = configuration["OpenAI:ApiKey"];
    }

    public async Task<string> AskAsync(string question)
    {
        var client = new OpenAIClient(_apiKey);

        var chat = client.GetChatClient("gpt-4o-mini");

        var response = await chat.CompleteChatAsync(
            $"You are a travel assistant for a Bulgarian tourism website called Horizons. " +
            $"Recommend destinations only from the Rhodope mountains. Be friendly.\n\nUser: {question}"
        );

        return response.Value.Content[0].Text;
    }
}
