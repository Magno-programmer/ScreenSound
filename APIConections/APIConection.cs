using OpenAI_API;

namespace ScreenSound.APIConections;

internal class APIConection
{
    public static string Conectar(string nomeBanda)
    {
        var apiKey = Environment.GetEnvironmentVariable("OPEN_AI_KEY");
        var client = new OpenAIAPI(apiKey);

        var chat = client.Chat.CreateConversation();

        chat.AppendSystemMessage($"Resuma a banda {nomeBanda} em 1 parágrafo. Adote um estilo informal.");

        string conection = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();

        return conection;
    }

}
