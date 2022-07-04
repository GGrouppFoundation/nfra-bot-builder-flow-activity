using System.Text.Json.Serialization;

namespace GGroupp.Infra.Bot.Builder;

public sealed record class FlowTgKeyboardButton
{
    public FlowTgKeyboardButton(string text)
        =>
        Text = text ?? string.Empty;

    [JsonPropertyName("text")]
    public string Text { get; }
}