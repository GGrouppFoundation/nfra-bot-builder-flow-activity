using System.Text.Json.Serialization;

namespace GarageGroup.Infra.Bot.Builder;

public sealed record class FlowTgParameters
{
    [JsonPropertyName("reply_markup")]
    public FlowTgReplyMarkup? ReplyMarkup { get; init; }

    [JsonPropertyName("text")]
    public string? Text { get; init; }

    [JsonPropertyName("parse_mode")]
    public FlowTgParseMode? ParseMode { get; init; }

    [JsonPropertyName("disable_notification")]
    public bool DisableNotification { get; init; }
}