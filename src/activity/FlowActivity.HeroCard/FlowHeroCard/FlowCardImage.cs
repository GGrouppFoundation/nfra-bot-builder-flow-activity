using System.Text.Json.Serialization;

namespace GGroupp.Infra.Bot.Builder;

public sealed record class FlowCardImage
{
    [JsonPropertyName("url")]
    public string? Url { get; init; }

    [JsonPropertyName("alt")]
    public string? Alt { get; init; }

    [JsonPropertyName("tap")]
    public FlowCardAction? Tap { get; init; }
}