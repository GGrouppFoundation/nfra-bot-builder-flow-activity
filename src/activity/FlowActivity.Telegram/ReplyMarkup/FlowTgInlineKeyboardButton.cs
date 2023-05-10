using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Bot.Builder;

public sealed record class FlowTgInlineKeyboardButton
{
    public FlowTgInlineKeyboardButton(string text)
        =>
        Text = text ?? string.Empty;

    [JsonPropertyName("text")]
    public string Text { get; }

    [JsonPropertyName("url")]
    public string? Url { get; init; }

    [JsonPropertyName("callback_data")]
    public string? CallbackData { get; init; }
}