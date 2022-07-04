using System.Text.Json.Serialization;

namespace GGroupp.Infra.Bot.Builder;

public sealed record class FlowCardAction
{
    public FlowCardAction(FlowCardActionType type)
        =>
        Type = type;

    [JsonPropertyName("type")]
    public FlowCardActionType Type { get; }

    [JsonPropertyName("title")]
    public string? Title { get; init; }

    [JsonPropertyName("image")]
    public string? Image { get; init; }

    [JsonPropertyName("text")]
    public string? Text { get; init; }

    [JsonPropertyName("displayText")]
    public string? DisplayText { get; init; }

    [JsonPropertyName("value")]
    public object? Value { get; init; }

    [JsonPropertyName("channelData")]
    public object? ChannelData { get; init; }

    [JsonPropertyName("imageAltText")]
    public string? ImageAltText { get; init; }
}